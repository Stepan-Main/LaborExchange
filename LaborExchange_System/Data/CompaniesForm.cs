using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using LaborExchange_System.Data;

namespace LaborExchange_System
{
    public partial class CompaniesForm : Form
    {
        public CompaniesForm()
        {
            InitializeComponent();
            LoadCities();
            LoadSpecializations();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            const string sql = @"
                    SELECT 
                        C.company_id AS 'ID', 
                        C.name AS 'Назва компанії', 
                        C.contact_person AS 'Контактна особа', 
                        C.phone AS 'Телефон', 
                        C.website AS 'Веб-сайт',
                        Cit.name AS 'Місто',
                        S.name AS 'Спеціалізація',
                        C.description AS 'Опис'
                    FROM labor_exchange_db.companies C
                    LEFT JOIN labor_exchange_db.cities Cit ON C.city_id = Cit.city_id
                    LEFT JOIN labor_exchange_db.specializations S ON C.spec_id = S.spec_id
                    WHERE 
                        (@name = '' OR C.name LIKE @name) AND 
                        (@city_id IS NULL OR C.city_id = @city_id) AND 
                        (@spec_id IS NULL OR C.spec_id = @spec_id)
                    ORDER BY C.company_id DESC;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConfig.ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + textBoxCompName.Text.Trim() + "%");
                    cmd.Parameters.AddWithValue("@city_id", GetSelectedFilterId(comboBoxCity));
                    cmd.Parameters.AddWithValue("@spec_id", GetSelectedFilterId(comboBoxSpec));

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    ConfigureGridColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Помилка завантаження компаній: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Допоміжний метод: безпечне отримання ID з фільтрів ComboBox
        private static object GetSelectedFilterId(ComboBox comboBox)
        {
            if (comboBox?.SelectedValue != null && comboBox.SelectedIndex > 0)
            {
                return comboBox.SelectedValue;
            }
            return DBNull.Value;
        }

        // Допоміжний метод: компактне налаштування вигляду таблиці
        private void ConfigureGridColumns()
        {
            if (dataGridView1.Columns.Count == 0) return;

            string[] hiddenColumns = { "ID", "Опис", "Веб-сайт", "Телефон" };
            foreach (var colName in hiddenColumns.Where(col => dataGridView1.Columns.Contains(col)))
            {
                dataGridView1.Columns[colName].Visible = false;
            }

            if (dataGridView1.Columns.Contains("Назва компанії"))
            {
                dataGridView1.Columns["Назва компанії"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteCompany_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int companyId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                string companyName = dataGridView1.SelectedRows[0].Cells["Назва компанії"].Value.ToString();

                var confirmResult = MessageBox.Show($"Ви впевнені, що хочете видалити компанію: {companyName}?\nЦе видалить усі пов'язані вакансії!",
                                             "Підтвердження каскадного видалення",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    DeleteCompany(companyId);
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть компанію у списку.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Зроблено static відповідно до зауваження SonarQube
        private static void DeleteCompany(int id)
        {
            string sql = "DELETE FROM labor_exchange_db.companies WHERE company_id = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConfig.ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Компанію успішно видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Неможливо видалити компанію, оскільки вона має активні вакансії або контракти.",
                                    "Помилка зв'язків", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Помилка БД: " + ex.Message);
            }
        }

        private void LoadCities()
        {
            string sql = "SELECT city_id, name FROM cities ORDER BY name";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Додаємо порожній рядок "Всі міста" на початок
                    DataRow dr = dt.NewRow();
                    dr["city_id"] = 0;
                    dr["name"] = "--- Всі міста ---";
                    dt.Rows.InsertAt(dr, 0);

                    comboBoxCity.DataSource = dt;
                    comboBoxCity.DisplayMember = "name";
                    comboBoxCity.ValueMember = "city_id";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Помилка бази даних при завантаженні міст: {ex.Message}",
                                "Помилка SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Непередбачена помилка: {ex.Message}",
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LoadSpecializations()
        {
            string sql = "SELECT spec_id, name FROM specializations ORDER BY name";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Додаємо порожній рядок "Всі спеціалізації" на початок
                    DataRow dr = dt.NewRow();
                    dr["spec_id"] = 0;
                    dr["name"] = "--- Всі спеціалізації ---";
                    dt.Rows.InsertAt(dr, 0);

                    comboBoxSpec.DataSource = dt;
                    comboBoxSpec.DisplayMember = "name";
                    comboBoxSpec.ValueMember = "spec_id";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Помилка бази даних при завантаженні спеціалізацій: {ex.Message}",
                                "Помилка SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Непередбачена помилка: {ex.Message}",
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // TODO
        private void InsertCompany(AddCompanyForm form)
        {
            string sql = @"INSERT INTO companies (name, description, contact_person, phone, website, city_id, spec_id) 
                   VALUES (@name, @desc, @c_person, @phone, @web, @city, @spec)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConfig.ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@name", form.textBoxCompName.Text.Trim());
                    cmd.Parameters.AddWithValue("@c_person", form.textBoxContactPerson.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", form.textBoxDecription.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", form.textBoxPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@web", form.textBoxWeb.Text.Trim());

                    // Додаємо параметри для випадаючих списків
                    cmd.Parameters.AddWithValue("@city", form.comboBoxCity.SelectedValue);
                    cmd.Parameters.AddWithValue("@spec", form.comboBoxSpec.SelectedValue);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Компанію успішно додано!", "Успіх");
                    RefreshGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка при додаванні: " + ex.Message); }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр вікна
            AddCompanyForm addForm = new AddCompanyForm();

            // Відкриваємо модально
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Якщо користувач натиснув "Зберегти"
                InsertCompany(addForm);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Перевіряємо, що клікнули по рядку з даними, а не по заголовку
            if (e.RowIndex >= 0)
            {
                // Отримуємо рядок даних, прив'язаний до цього рядка таблиці
                // Це працює, бо DataSource — це DataTable
                DataRowView rowView = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                DataRow selectedRow = rowView.Row;

                // Створюємо та відкриваємо форму деталей
                CompanyDetailsForm detailsForm = new CompanyDetailsForm(selectedRow);

                // Використовуємо центрування відносно поточної форми
                detailsForm.StartPosition = FormStartPosition.CenterParent;
                detailsForm.ShowDialog(this);
            }
        }
    }
}

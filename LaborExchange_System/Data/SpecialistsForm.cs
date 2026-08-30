using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Polyclinic_e_reception.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace LaborExchange_System
{
    public partial class SpecialistsForm : Form
    {
        public SpecialistsForm()
        {
            InitializeComponent();
            LoadCities(comboBoxSpecialty);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            string sql = @"SELECT 
                                S.specialist_id, 
                                S.last_name AS Прізвище, 
                                S.first_name AS Імʼя, 
                                TIMESTAMPDIFF(YEAR, S.birth_date, CURDATE()) AS Вік,
                                S.phone AS Телефон, 
                                S.email AS Email,
                                C.name AS Місто, 
                                E.name AS Освіта
                            FROM specialists S
                            JOIN cities C ON S.city_id = C.city_id
                            JOIN education_levels E ON S.education_id = E.education_id
                            WHERE(S.last_name LIKE @sname
                                AND S.first_name LIKE @name
                                AND (@city_id IS NULL OR C.city_id = @city_id))
                            ORDER BY S.specialist_id DESC; ";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, connection);

                    // Налаштування параметрів пошуку
                    cmd.Parameters.AddWithValue("@sname", "%" + textBoxSName.Text + "%");
                    cmd.Parameters.AddWithValue("@name", "%" + textBoxName.Text + "%");

                    // Логіка фільтрації по місту
                    if (comboBoxSpecialty.SelectedValue != null && comboBoxSpecialty.SelectedIndex != 0)
                        cmd.Parameters.AddWithValue("@city_id", comboBoxSpecialty.SelectedValue);
                    else
                        cmd.Parameters.AddWithValue("@city_id", DBNull.Value);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dataGridView1.Columns.Count > 0)
                    {
                        // Налаштування по конкретних іменах
                        if (dataGridView1.Columns.Contains("№"))
                            dataGridView1.Columns["№"].Width = 30;

                        if (dataGridView1.Columns.Contains("Прізвище"))
                            dataGridView1.Columns["Прізвище"].Width = 90;

                        if (dataGridView1.Columns.Contains("Імʼя"))
                            dataGridView1.Columns["Імʼя"].Width = 90;

                        if (dataGridView1.Columns.Contains("Вік"))
                            dataGridView1.Columns["Вік"].Width = 30;

                        // Встановлюємо ширину лівої колонки (RowHeader)
                        dataGridView1.RowHeadersWidth = 25;
                        // Вимикаємо можливість користувача розтягувати її вручну
                        dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    }

                    dataGridView1.DataSource = dt;

                    // Ховаємо ID, щоб користувач його не бачив
                    if (dataGridView1.Columns.Contains("specialist_id"))
                        dataGridView1.Columns["specialist_id"].Visible = false;

                    // Знімаємо виділення з усіх комірок
                    dataGridView1.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                // Не виводимо MessageBox при кожній букві, щоб не заважати вводу, 
                // або робимо це тільки при критичних помилках
                Console.WriteLine("Помилка завантаження даних: " + ex.Message);
            }
        }

        private void InsertSpecialist(AddSpecialistForm form)
        {
            // Оновлений SQL запит для таблиці specialists
            string sql = @"INSERT INTO specialists 
                   (last_name, first_name, phone, email, birth_date, city_id, education_id) 
                   VALUES (@lname, @fname, @phone, @email, @bdate, @city, @edu)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Наповнюємо параметри даними з полів форми
                    cmd.Parameters.AddWithValue("@lname", form.textBoxLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@fname", form.textBoxFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", form.textBoxPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", form.textBoxEmail.Text.Trim());

                    // Перетворюємо дату у формат SQL (YYYY-MM-DD)
                    cmd.Parameters.AddWithValue("@bdate", form.dateTimePickerBirth.Value.ToString("yyyy-MM-dd"));

                    // Отримуємо ID з випадаючих списків
                    cmd.Parameters.AddWithValue("@city", form.comboBoxCity.SelectedValue);
                    cmd.Parameters.AddWithValue("@edu", form.comboBoxEducation.SelectedValue);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(form, "Спеціаліста успішно додано до бази!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Оновлюємо таблицю на головній формі
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні в БД: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCities(ComboBox cmb)
        {
            string sql = "SELECT city_id, name FROM cities ORDER BY name;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Додаємо порожній рядок для скидання фільтру
                    DataRow dr = dt.NewRow();
                    dr["name"] = "Всі міста";
                    dr["city_id"] = DBNull.Value;
                    dt.Rows.InsertAt(dr, 0);

                    cmb.DataSource = dt;
                    cmb.DisplayMember = "name";
                    cmb.ValueMember = "city_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження міст: " + ex.Message);
            }
        }

        private void DeleteSpecialist(int id)
        {
            string sql = "DELETE FROM specialists WHERE specialist_id = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Спеціаліста видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні: " + ex.Message, "Помилка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AddSpecialistForm form = new AddSpecialistForm())
            {
                // Показуємо форму як діалог
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Якщо користувач натиснув "Зберегти", викликаємо наш метод вставки
                    InsertSpecialist(form);
                }
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void buttonDeleteSpec_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи виділено рядок у таблиці
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Отримуємо дані з виділеного рядка
                // specialist_id має бути в SELECT вашого RefreshGrid()
                int specId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["specialist_id"].Value);
                string lastName = dataGridView1.SelectedRows[0].Cells["Прізвище"].Value.ToString();
                string firstName = dataGridView1.SelectedRows[0].Cells["Імʼя"].Value.ToString();

                // Запитуємо підтвердження
                var confirmResult = MessageBox.Show(this,
                    $"Ви впевнені, що хочете видалити спеціаліста: {lastName} {firstName}?\n\n" +
                    "Увага: Це також видалить усі пов'язані з ним резюме та відгуки!",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Викликаємо видалення
                    DeleteSpecialist(specId);

                    // Оновлюємо список
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show(this, "Будь ласка, спочатку оберіть спеціаліста у списку.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Отримуємо рядок через DataBoundItem
                DataRowView rowView = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                DataRow selectedRow = rowView.Row;

                // Відкриваємо вікно
                SpecialistDetailsForm frm = new SpecialistDetailsForm(selectedRow);
                frm.ShowDialog(this);
            }
        }
    }
}

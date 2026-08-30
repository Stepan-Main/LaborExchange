using LaborExchange_System;
using LaborExchange_System.Date.References;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaborExchange_System.Data
{
    public partial class ReferencesManagerForm : Form
    {
        private string _table;
        private string _idCol;


        // Повертає статичний константний запит, безпечний для SonarQube
        private static string GetSelectSql(string table)
        {
            switch (table.ToLowerInvariant())
            {
                case "cities":
                    return "SELECT city_id AS ID, name AS 'Назва' FROM cities ORDER BY name";
                case "countries":
                    return "SELECT country_id AS ID, name AS 'Назва' FROM countries ORDER BY name";
                case "currencies":
                    return "SELECT currency_id AS ID, code AS 'Назва' FROM currencies ORDER BY code";
                case "education_levels":
                    return "SELECT education_id AS ID, name AS 'Назва' FROM education_levels ORDER BY name";
                case "industries":
                    return "SELECT industry_id AS ID, name AS 'Назва' FROM industries ORDER BY name";
                case "skills":
                    return "SELECT skill_id AS ID, name AS 'Назва' FROM skills ORDER BY name";
                case "specializations":
                    return "SELECT spec_id AS ID, name AS 'Назва' FROM specializations ORDER BY name";
                default:
                    throw new ArgumentException("Невідома таблиця для довідника: " + table);
            }
        }

        // Повертає статичний константний запит для видалення
        private static string GetDeleteSql(string table)
        {
            switch (table.ToLowerInvariant())
            {
                case "cities":
                    return "DELETE FROM cities WHERE city_id = @id";
                case "countries":
                    return "DELETE FROM countries WHERE country_id = @id";
                case "currencies":
                    return "DELETE FROM currencies WHERE currency_id = @id";
                case "education_levels":
                    return "DELETE FROM education_levels WHERE education_id = @id";
                case "industries":
                    return "DELETE FROM industries WHERE industry_id = @id";
                case "skills":
                    return "DELETE FROM skills WHERE skill_id = @id";
                case "specializations":
                    return "DELETE FROM specializations WHERE spec_id = @id";
                default:
                    throw new ArgumentException("Невідома таблиця для довідника: " + table);
            }
        }

        public ReferencesManagerForm(string table, string idCol, string title)
        {
            InitializeComponent();

            _table = table;
            _idCol = idCol;
            this.Text = "Довідник: " + title;

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            // Отримуємо чистий константний SQL-рядок без форматування
            string sql = GetSelectSql(_table);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    // Використовуємо MySqlDataAdapter для заповнення DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Прив'язуємо дані до DataGridView
                    dataGridView1.DataSource = dt;

                    // Налаштування вигляду таблиці
                    if (dataGridView1.Columns.Count > 0)
                    {
                        // Ховаємо колонку з ID
                        dataGridView1.Columns["ID"].Visible = false;

                        // Розтягуємо колонку "Назва" на всю ширину вікна
                        dataGridView1.Columns["Назва"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    // Забороняємо редагування безпосередньо в таблиці
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;

                    // Знімаємо виділення з першого рядка
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження довідника ({_table}): " + ex.Message,
                                "Помилка бази даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = dataGridView1.SelectedRows[0].Cells["ID"].Value;
                var name = dataGridView1.SelectedRows[0].Cells["Назва"].Value.ToString();

                if (MessageBox.Show($"Видалити '{name}' з довідника?", "Підтвердження",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = GetDeleteSql(_table);

                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                        {
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            RefreshGrid();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Неможливо видалити цей запис, оскільки він використовується в інших таблицях. {ex.Message}",
                                        "Помилка зв'язків", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Відкриваємо ту саму форму редагування, але з порожніми даними
            // Передаємо: таблицю, назву ID колонки, ID = -1 (ознака нового запису) та порожню назву
            using (EditReferencesForm addForm = new EditReferencesForm(_table, _idCol, -1, ""))
            {
                addForm.StartPosition = FormStartPosition.CenterParent;
                addForm.Text = "Додавання нового запису";

                // Якщо користувач натиснув "Зберегти" у формі
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Оновлюємо таблицю, щоб побачити новий запис
                    RefreshGrid();
                }
            }
        }
    }
}

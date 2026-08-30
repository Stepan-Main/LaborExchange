using LaborExchange_System;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaborExchange_System.Date.References
{
    public partial class EditReferencesForm : Form
    {
        private string _tableName;
        private string _idColumn;
        private int _id;
        private string _displayColumn;

        // Конструктор, який викликаю викликаєте з DirectoryManagerForm
        public EditReferencesForm(string table, string idCol, int id, string currentName)
        {
            InitializeComponent();

            _tableName = table;
            _idColumn = idCol;
            _id = id;
            _displayColumn = (table == "currencies") ? "code" : "name";

            // Заповнюємо поле поточним значенням
            textBoxName.Text = currentName;

            string directoryName = GetFriendlyName(table);
            labelInfo.Text = (id == -1) ? $"Додавання в: {directoryName}" : $"Редагування в: {directoryName}";

            // Встановлюємо заголовок вікна залежно від режиму
            this.Text = (_id == -1) ? "Додавання запису" : "Редагування запису";
        }

        // Допоміжний метод для гарних назв у Label
        private static string GetFriendlyName(string table)
        {
            switch (table)
            {
                case "cities": return "Міста";
                case "specializations": return "Спеціалізації";
                case "skills": return "Навички";
                case "employment_types": return "Типи зайнятості";
                case "education_levels": return "Рівень освіти";
                case "currencies": return "Валюти";
                default: return table;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string newValue = textBoxName.Text.Trim();

            // Валідація. Поле не повинно бути порожнім
            if (string.IsNullOrEmpty(newValue))
            {
                MessageBox.Show("Будь ласка, введіть значення.", "Помилка валідації",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Формуємо SQL запит
            string sql;
            if (_id == -1)
            {
                // Режим додавання
                sql = $"INSERT INTO `{_tableName}` (`{_displayColumn}`) VALUES (@val)";
            }
            else
            {
                // Режим редагування
                sql = $"UPDATE `{_tableName}` SET `{_displayColumn}` = @val WHERE `{_idColumn}` = @id";
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@val", newValue);

                    if (_id != -1)
                    {
                        cmd.Parameters.AddWithValue("@id", _id);
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Повертаємо OK, щоб головна форма знала, що треба оновити Grid
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (MySqlException ex)
            {
                // Обробка дублікатів, якщо в базі стоїть UNIQUE на назву.
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Такий запис уже існує в цьому довіднику!", "Дублікат",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Помилка бази даних: " + ex.Message, "Помилка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

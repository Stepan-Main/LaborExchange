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

namespace LaborExchange_System
{
    public partial class AddCompanyForm : Form
    {
        public AddCompanyForm()
        {
            InitializeComponent();
            LoadCities();
            LoadSpecializations();
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

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            // Проста валідація
            if (string.IsNullOrWhiteSpace(textBoxCompName.Text) || 
                string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Назва та телефон є обов'язковими!");
                return;
            }

            // Валідація комбобоксів: перевіряємо, що ID не дорівнює 0 
            if (Convert.ToInt32(comboBoxCity.SelectedValue) <= 0 || 
                Convert.ToInt32(comboBoxSpec.SelectedValue) <= 0)
            {
                MessageBox.Show("Будь ласка, оберіть місто та спеціалізацію зі списку!", "Помилка вибору", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

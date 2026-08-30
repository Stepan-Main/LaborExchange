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
    public partial class AddSpecialistForm : Form
    {
        public AddSpecialistForm()
        {
            InitializeComponent();
        }

        private void AddSpecialistForm_Load(object sender, EventArgs e)
        {
            LoadCities();
            LoadEducationLevels();
        }

        private void LoadCities()
        {
            string sql = "SELECT city_id, name FROM cities ORDER BY name;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxCity.DataSource = dt;
                    comboBoxCity.DisplayMember = "name";
                    comboBoxCity.ValueMember = "city_id";
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка завантаження міст: " + ex.Message); }
        }

        private void LoadEducationLevels()
        {
            string sql = "SELECT education_id, name FROM education_levels ORDER BY education_id;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxEducation.DataSource = dt;
                    comboBoxEducation.DisplayMember = "name";
                    comboBoxEducation.ValueMember = "education_id";
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка завантаження освіти: " + ex.Message); }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddNewSpec_Click(object sender, EventArgs e)
        {
            // Тільки валідація
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Заповніть обов'язкові поля!");
                return;
            }

            // Просто закриваємо форму з результатом OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

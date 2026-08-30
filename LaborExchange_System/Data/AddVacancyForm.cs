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
using System.Windows.Forms.VisualStyles;

namespace LaborExchange_System
{
    public partial class AddVacancyForm : Form
    {
        public AddVacancyForm()
        {
            InitializeComponent();
        }

        private void AddVacancyForm_Load(object sender, EventArgs e)
        {
            LoadCompanies();
            LoadCurrencies();
            LoadStatuses();
        }

        private void LoadCompanies()
        {
            string sql = "SELECT company_id, name FROM companies ORDER BY name;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxCompany.DataSource = dt;
                    comboBoxCompany.DisplayMember = "name";
                    comboBoxCompany.ValueMember = "company_id";
                    comboBoxCompany.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка компаній: " + ex.Message); }
        }

        private void LoadCurrencies()
        {
            string sql = "SELECT currency_id, code FROM currencies;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxCurrency.DataSource = dt;
                    comboBoxCurrency.DisplayMember = "code";
                    comboBoxCurrency.ValueMember = "currency_id";
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка валют: " + ex.Message); }
        }

        private void LoadStatuses()
        {
            string sql = "SELECT status_id, name FROM vacancy_statuses;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxStatus.DataSource = dt;
                    comboBoxStatus.DisplayMember = "name";
                    comboBoxStatus.ValueMember = "status_id";
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка статусів: " + ex.Message); }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Валідація
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) || comboBoxCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка, вкажіть назву вакансії та компанію.");
                return;
            }

            string sql = @"INSERT INTO vacancies (title, description, salary, company_id, currency_id, status_id, created_at) 
                       VALUES (@title, @desc, @salary, @comp_id, @curr_id, @stat_id, NOW());";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", textBoxTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", textBoxDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@salary", numericUpDownSalary.Value);
                    cmd.Parameters.AddWithValue("@comp_id", comboBoxCompany.SelectedValue);
                    cmd.Parameters.AddWithValue("@curr_id", comboBoxCurrency.SelectedValue);
                    cmd.Parameters.AddWithValue("@stat_id", comboBoxStatus.SelectedValue);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Вакансію успішно додано!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка додавання: " + ex.Message);
            }
        }

        private void buttonCancelInsertion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
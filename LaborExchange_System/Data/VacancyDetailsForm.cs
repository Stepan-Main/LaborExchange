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

namespace LaborExchange_System.Data
{
    public partial class VacancyDetailsForm : Form
    {
        private int _vacancyId;

        public VacancyDetailsForm(int vacancyId)
        {
            InitializeComponent();
            _vacancyId = vacancyId;
            LoadFullInfo();
        }

        private void LoadFullInfo()
        {
            string sql = @"
            SELECT V.title, C.name, V.description, V.salary, Curr.code, S.name, V.created_at
            FROM labor_exchange_db.vacancies V
            JOIN labor_exchange_db.companies C ON V.company_id = C.company_id
            JOIN labor_exchange_db.currencies Curr ON V.currency_id = Curr.currency_id
            JOIN labor_exchange_db.vacancy_statuses S ON V.status_id = S.status_id
            WHERE V.vacancy_id = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _vacancyId);
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.Text = "Вакансія: " + reader["title"].ToString();
                            labelTitle.Text = reader["title"].ToString();
                            labelCompany.Text = "Компанія: " + reader["name"].ToString();
                            labelSalary.Text = $"Зарплата: {reader["salary"]} {reader["code"]}";

                            // Повний текст опису вакансії
                            string rawDescription = reader["description"].ToString();
                            textBoxDescription.Text = rawDescription.Replace("\n", Environment.NewLine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження деталей: " + ex.Message);
            }
        }
    }
}

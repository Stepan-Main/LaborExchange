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

namespace LaborExchange_System.Analitic
{
    public partial class AnalyticsCandidateProfileForm : Form
    {
        public AnalyticsCandidateProfileForm()
        {
            InitializeComponent();
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            LoadAnalyticsData();
        }

        private void LoadAnalyticsData()
        {
            string sql = @"
                    SELECT 
                        CONCAT(s.first_name, ' ', s.last_name) AS 'Кандидат',
                        sc.name AS 'Місто проживання',
                        edu.name AS 'Освіта',
                        r.title AS 'Назва резюме',
                        r.salary AS 'Бажана з/п',
                        cur.code AS 'Валюта',
                        v.title AS 'Вакансія',
                        com.name AS 'Компанія',
                        cc.name AS 'Місто компанії',
                        ast.name AS 'Статус відгуку'
                    FROM specialists s
                    JOIN cities sc ON s.city_id = sc.city_id
                    JOIN education_levels edu ON s.education_id = edu.education_id
                    JOIN resumes r ON s.specialist_id = r.specialist_id
                    JOIN currencies cur ON r.currency_id = cur.currency_id
                    JOIN job_applications ja ON r.resume_id = ja.resume_id
                    JOIN app_statuses ast ON ja.status_id = ast.status_id
                    JOIN vacancies v ON ja.vacancy_id = v.vacancy_id
                    JOIN companies com ON v.company_id = com.company_id
                    JOIN cities cc ON com.city_id = cc.city_id
                    ORDER BY 1 DESC;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewAnalytics.DataSource = dt;

                    // Візуальне покращення: виділення статусу
                    FormatStatusCells();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при формуванні аналітичного звіту: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatStatusCells()
        {
            foreach (DataGridViewRow row in dataGridViewAnalytics.Rows)
            {
                var statusCell = row.Cells["Статус відгуку"];
                if (statusCell.Value != null)
                {
                    string status = statusCell.Value.ToString();
                    if (status == "Прийнято") statusCell.Style.BackColor = Color.LightGreen;
                    else if (status == "Відхилено") statusCell.Style.BackColor = Color.LightCoral;
                    else if (status == "В очікуванні") statusCell.Style.BackColor = Color.LightYellow;
                }
            }
        }
    }
}

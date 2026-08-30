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
    public partial class AnalyticsDataIntegrityForm : Form
    {
        public AnalyticsDataIntegrityForm()
        {
            InitializeComponent();
            LoadIntegrityData();
        }

        private void LoadIntegrityData()
        {
            string sql = @"
                        SELECT 
                            CONCAT(s.first_name, ' ', s.last_name) AS 'Об’єкт', 
                            'Спеціаліст без резюме' AS 'Проблема'
                        FROM specialists s
                        LEFT JOIN resumes r ON s.specialist_id = r.specialist_id
                        WHERE r.resume_id IS NULL

                        UNION ALL

                        SELECT 
                            v.title AS 'Об’єкт', 
                            'Вакансія без вимог (skills)' AS 'Проблема'
                        FROM vacancies v
                        LEFT JOIN vacancy_reqnts vr ON v.vacancy_id = vr.vac_id
                        WHERE vr.skill_id IS NULL;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewIntegrity.DataSource = dt;

                    // Додамо візуальне виділення, щоб легше було розрізняти типи проблем
                    HighlightIssues();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка перевірки цілісності даних: " + ex.Message);
            }
        }
        private void HighlightIssues()
        {
            foreach (DataGridViewRow row in dataGridViewIntegrity.Rows)
            {
                if (row.Cells["Проблема"].Value.ToString().Contains("Спеціаліст"))
                {
                    row.Cells["Проблема"].Style.ForeColor = Color.DarkBlue;
                }
                else
                {
                    row.Cells["Проблема"].Style.ForeColor = Color.DarkRed;
                }
            }
        }
    }
}

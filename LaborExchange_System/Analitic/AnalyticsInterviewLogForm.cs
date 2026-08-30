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
    public partial class AnalyticsInterviewLogForm : Form
    {
        public AnalyticsInterviewLogForm()
        {
            InitializeComponent();
        }

        private void AnalyticsInterviewLogForm_Load(object sender, EventArgs e)
        {
            LoadLogData();
        }

        private void LoadLogData()
        {
            // Використовуємо ваш запит з LEFT JOIN
            string sql = @"
                    SELECT 
                        CONCAT(s.first_name, ' ', s.last_name) AS 'Кандидат',
                        v.title AS 'Вакансія',
                        r.title AS 'Резюме',
                        ast.name AS 'Поточний статус',
                        ih.interview_date AS 'Дата співбесіди',
                        ih.result AS 'Результат/Фідбек'
                    FROM job_applications ja
                    JOIN vacancies v ON ja.vacancy_id = v.vacancy_id
                    JOIN resumes r ON ja.resume_id = r.resume_id
                    JOIN specialists s ON r.specialist_id = s.specialist_id
                    JOIN app_statuses ast ON ja.status_id = ast.status_id
                    LEFT JOIN interview_history ih ON ja.app_id = ih.app_id
                    ORDER BY 1 DESC;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewLog.DataSource = dt;

                    // Обробка відображення NULL значень для користувача
                    FormatNullCells();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження логу інтерв'ю: " + ex.Message, "Помилка БД");
            }
        }

        private void FormatNullCells()
        {
            foreach (DataGridViewRow row in dataGridViewLog.Rows)
            {
                if (row.Cells["Дата співбесіди"].Value == DBNull.Value)
                {
                    row.Cells["Дата співбесіди"].Value = "Не призначено";
                    row.Cells["Результат/Фідбек"].Value = "Очікує розгляду";
                    row.DefaultCellStyle.ForeColor = Color.Gray; // Сірий колір для нових відгуків
                }
            }
        }
    }
}

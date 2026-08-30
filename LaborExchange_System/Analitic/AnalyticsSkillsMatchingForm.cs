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
    public partial class AnalyticsSkillsMatchingForm : Form
    {
        public AnalyticsSkillsMatchingForm()
        {
            InitializeComponent();
            LoadMatchingData();
        }

        private void LoadMatchingData()
        {
            string sql = @"
        SELECT 
            CONCAT(s.first_name, ' ', s.last_name) AS 'Спеціаліст',
            sk.name AS 'Спільна навичка',
            v.title AS 'Відповідна вакансія'
        FROM specialists s
        JOIN specialist_skills ss ON s.specialist_id = ss.spec_id
        JOIN skills sk ON ss.skill_id = sk.skill_id
        JOIN vacancy_reqnts vr ON sk.skill_id = vr.skill_id
        JOIN vacancies v ON vr.vac_id = v.vacancy_id
        ORDER BY s.last_name;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewMatching.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка аналітики навичок: " + ex.Message, "Помилка БД");
            }
        }
    }
}

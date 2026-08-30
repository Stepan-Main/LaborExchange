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
    public partial class AnalyticsCleanupForm : Form
    {
        public AnalyticsCleanupForm()
        {
            InitializeComponent();
            LoadCleanupData();
        }

        private void LoadCleanupData()
        {
            string sql = @"
                        SELECT 
                            sk.name AS 'Навичка', 
                            'Ніким не використовується' AS 'Статус'
                        FROM labor_exchange_db.skills sk
                        LEFT JOIN specialist_skills ss ON sk.skill_id = ss.skill_id
                        LEFT JOIN vacancy_reqnts vr ON sk.skill_id = vr.skill_id
                        WHERE ss.skill_id IS NULL AND vr.skill_id IS NULL
                        ORDER BY sk.name;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewCleanup.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при аналізі навичок: " + ex.Message, "Помилка БД");
            }
        }
    }
}

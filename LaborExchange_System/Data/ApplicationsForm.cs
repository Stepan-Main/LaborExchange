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
using LaborExchange_System.Data;

namespace LaborExchange_System.Data
{
    public partial class ApplicationsForm : Form
    {
        public ApplicationsForm()
        {
            InitializeComponent();
            LoadStatuses();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            // Використовуємо JOIN для зв'язку всіх сутностей
            string sql = @"
                    SELECT 
                        ja.app_id AS 'ID',
                        CONCAT(s.last_name, ' ', s.first_name) AS 'Кандидат',
                        v.title AS 'Вакансія',
                        ast.name AS 'Статус',
                        ja.app_date AS 'Дата відгуку'
                    FROM job_applications ja
                    JOIN resumes r ON ja.resume_id = r.resume_id
                    JOIN specialists s ON r.specialist_id = s.specialist_id
                    JOIN vacancies v ON ja.vacancy_id = v.vacancy_id
                    JOIN app_statuses ast ON ja.status_id = ast.status_id
                    WHERE 
                        (@lastName = '' OR s.last_name LIKE @lastName) AND
                        (@statusId = 0 OR ja.status_id = @statusId)
                    ORDER BY ja.app_date DESC;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@lastName", "%" + textBoxSpecSearch.Text.Trim() + "%");

                    int statusFilter = comboBoxStatusFilter.SelectedValue is int val ? val : 0;

                    cmd.Parameters.AddWithValue("@statusId", statusFilter);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewApps.DataSource = dt;

                    if (dataGridViewApps.Columns.Contains("ID")) dataGridViewApps.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка фільтрації: " + ex.Message);
            }
        }

        private void LoadStatuses()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    string sql = "SELECT status_id, name FROM app_statuses ORDER BY name";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["status_id"] = 0;
                    dr["name"] = "--- Всі статуси ---";
                    dt.Rows.InsertAt(dr, 0);

                    comboBoxStatusFilter.DataSource = dt;
                    comboBoxStatusFilter.DisplayMember = "name";
                    comboBoxStatusFilter.ValueMember = "status_id";
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка довідників: " + ex.Message); }
        }

        private void textBoxSpecSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void comboBoxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}

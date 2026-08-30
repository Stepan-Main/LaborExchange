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
    public partial class CompanyDetailsForm : Form
    {
        public CompanyDetailsForm(DataRow companyRow)
        {
            InitializeComponent();

            // Заповнюємо дані з переданого рядка DataTable
            this.Text = "Детальна інформація: " + companyRow["Назва компанії"].ToString();

            labelName.Text = companyRow["Назва компанії"].ToString();
            labelCity.Text = "Місто: " + companyRow["Місто"].ToString();
            labelSpec.Text = "Спеціалізація: " + companyRow["Спеціалізація"].ToString();
            labelContact.Text = "Контактна особа: " + companyRow["Контактна особа"].ToString();
            labelPhone.Text = "Телефон: " + companyRow["Телефон"].ToString();
            labelWeb.Text = companyRow["Веб-сайт"].ToString();

            // Використовуємо RichTextBox для опису
            textBoxDescription.Text = companyRow["Опис"].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Додамо можливість відкрити сайт прямо з цього вікна
        private void lblWeb_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelWeb.Text) && labelWeb.Text.StartsWith("http"))
            {
                System.Diagnostics.Process.Start(labelWeb.Text);
            }
        }
    }
}

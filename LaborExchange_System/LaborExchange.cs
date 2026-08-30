using LaborExchange_System.Analitic;
using LaborExchange_System.Data;
using LaborExchange_System.Help;
using MySql.Data.MySqlClient;
using LaborExchange_System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void buttonAddVacancy_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр нової форми
            AddVacancyForm vacancyForm = new AddVacancyForm();
            vacancyForm.StartPosition = FormStartPosition.CenterParent;

            // Відображаємо модально
            if (vacancyForm.ShowDialog() == DialogResult.OK)
            {
                // Оновлюємо дані на головній формі після додавання
                this.RefreshGrid();
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void buttonResetFilters_Click(object sender, EventArgs e)
        {
            // Скидаємо комбобокси в перший пункт ("Всі...")
            comboBoxStatus.SelectedIndex = 0;
            comboBoxCurrencies.SelectedIndex = 0;

            // Знімаємо галочку з дати
            dateTimePicker.Checked = false;
            textBoxCompany.Text = null;
            textBoxSalaryFrom.Text = null;

            // Оновлюємо таблицю
            RefreshGrid();
        }

        private void MenuPatientForm_Click(object sender, EventArgs e)
        {
            CompaniesForm patientsForm = new CompaniesForm();

            // Встановлюємо позицію по центру батьківського вікна програмно
            patientsForm.StartPosition = FormStartPosition.CenterParent;

            // ShowDialog() відображає форму модально
            patientsForm.ShowDialog();
            RefreshGrid();
        }

        private void MenuDoctorsForm_Click(object sender, EventArgs e)
        {
            SpecialistsForm doctorsForm = new SpecialistsForm();
            // Встановлюємо позицію по центру батьківського вікна програмно
            doctorsForm.StartPosition = FormStartPosition.CenterParent;

            // ShowDialog() відображає форму модально
            doctorsForm.ShowDialog();
            RefreshGrid();
        }

        private void вийтиЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void аналізЗавантаженостіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new Help.AboutForm();
            // Встановлюємо позицію по центру батьківського вікна програмно
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new Help.AuthorForm();
            // Встановлюємо позицію по центру батьківського вікна програмно
            authorForm.StartPosition = FormStartPosition.CenterParent;
            authorForm.ShowDialog();
        }

        // Універсальний метод відкриття
        private void OpenDirectory(string table, string idCol, string title)
        {
            ReferencesManagerForm f = new ReferencesManagerForm(table, idCol, title);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }
        private void містаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDirectory("cities", "city_id", "Міста");
        }

        private void спеціалізаціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDirectory("specializations", "spec_id", "Спеціалізації");
        }

        private void навичкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDirectory("skills", "skill_id", "Навички");
        }

        private void типиЗайнятостіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDirectory("employment_types", "employment_id", "Типи зайнятості");
        }

        private void рівніОсвітиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDirectory("education_levels", "education_id", "Рівні освіти");
        }

        private void валютиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDirectory("currencies", "currency_id", "Валюти");
        }

        private void аналітикаПрофіліТаВідгукиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalyticsCandidateProfileForm statusAnalyticsForm = new AnalyticsCandidateProfileForm();
            // Встановлюємо позицію по центру батьківського вікна програмно
            statusAnalyticsForm.StartPosition = FormStartPosition.CenterParent;
            statusAnalyticsForm.ShowDialog();
        }

        private void аналізВідповідностіНавичокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalyticsSkillsMatchingForm statusAnalyticsForm = new AnalyticsSkillsMatchingForm();    
            // Встановлюємо позицію по центру батьківського вікна програмно
            statusAnalyticsForm.StartPosition = FormStartPosition.CenterParent;
            statusAnalyticsForm.ShowDialog();
        }

        private void журналСпівбесідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalyticsInterviewLogForm statusAnalyticsForm = new AnalyticsInterviewLogForm();
            // Встановлюємо позицію по центру батьківського вікна програмно
            statusAnalyticsForm.StartPosition = FormStartPosition.CenterParent;
            statusAnalyticsForm.ShowDialog();
        }

        private void звітПроНеповнотуДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalyticsDataIntegrityForm statusAnalyticsForm = new AnalyticsDataIntegrityForm();
            // Встановлюємо позицію по центру батьківського вікна програмно
            statusAnalyticsForm.StartPosition = FormStartPosition.CenterParent;
            statusAnalyticsForm.ShowDialog();
        }

        private void аналізАктуальностіДовідниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalyticsCleanupForm statusAnalyticsForm = new AnalyticsCleanupForm();
            // Встановлюємо позицію по центру батьківського вікна програмно
            statusAnalyticsForm.StartPosition = FormStartPosition.CenterParent;
            statusAnalyticsForm.ShowDialog();
        }

        private void відгукиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationsForm statusAnalyticsForm = new ApplicationsForm();
            // Встановлюємо позицію по центру батьківського вікна програмно
            statusAnalyticsForm.StartPosition = FormStartPosition.CenterParent;
            statusAnalyticsForm.ShowDialog();
        }
    }
}

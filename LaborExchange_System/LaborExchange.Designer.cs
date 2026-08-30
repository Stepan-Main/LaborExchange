using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using LaborExchange_System.Data;

namespace LaborExchange_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddNewAppoitment = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиЗПрограмиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роботаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вакансіїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відгукиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лікаріToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналітикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналітикаПрофіліТаВідгукиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналізВідповідностіНавичокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналСпівбесідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звітПроНеповнотуДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналізАктуальностіДовідниківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.містаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спеціалізаціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.навичкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типиЗайнятостіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рівніОсвітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.валютиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSalaryFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCurrencies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonAddNewAppoitment
            // 
            this.buttonAddNewAppoitment.Location = new System.Drawing.Point(12, 408);
            this.buttonAddNewAppoitment.Name = "buttonAddNewAppoitment";
            this.buttonAddNewAppoitment.Size = new System.Drawing.Size(197, 30);
            this.buttonAddNewAppoitment.TabIndex = 1;
            this.buttonAddNewAppoitment.Text = "Додати нову вакансію";
            this.buttonAddNewAppoitment.UseVisualStyleBackColor = true;
            this.buttonAddNewAppoitment.Click += new System.EventHandler(this.buttonAddVacancy_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.роботаToolStripMenuItem,
            this.toolStripMenuItem1,
            this.аналітикаToolStripMenuItem,
            this.довідникиToolStripMenuItem,
            this.допомогаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вийтиЗПрограмиToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // вийтиЗПрограмиToolStripMenuItem
            // 
            this.вийтиЗПрограмиToolStripMenuItem.Name = "вийтиЗПрограмиToolStripMenuItem";
            this.вийтиЗПрограмиToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.вийтиЗПрограмиToolStripMenuItem.Text = "Вийти з програми";
            this.вийтиЗПрограмиToolStripMenuItem.Click += new System.EventHandler(this.вийтиЗПрограмиToolStripMenuItem_Click);
            // 
            // роботаToolStripMenuItem
            // 
            this.роботаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вакансіїToolStripMenuItem,
            this.відгукиToolStripMenuItem});
            this.роботаToolStripMenuItem.Name = "роботаToolStripMenuItem";
            this.роботаToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.роботаToolStripMenuItem.Text = "Робота";
            // 
            // вакансіїToolStripMenuItem
            // 
            this.вакансіїToolStripMenuItem.Name = "вакансіїToolStripMenuItem";
            this.вакансіїToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.вакансіїToolStripMenuItem.Text = "Вакансії";
            // 
            // відгукиToolStripMenuItem
            // 
            this.відгукиToolStripMenuItem.Name = "відгукиToolStripMenuItem";
            this.відгукиToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.відгукиToolStripMenuItem.Text = "Відгуки";
            this.відгукиToolStripMenuItem.Click += new System.EventHandler(this.відгукиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employersToolStripMenuItem,
            this.лікаріToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.toolStripMenuItem1.Text = "Учасники";
            // 
            // employersToolStripMenuItem
            // 
            this.employersToolStripMenuItem.Name = "employersToolStripMenuItem";
            this.employersToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.employersToolStripMenuItem.Text = "Роботодавці";
            this.employersToolStripMenuItem.Click += new System.EventHandler(this.MenuPatientForm_Click);
            // 
            // лікаріToolStripMenuItem
            // 
            this.лікаріToolStripMenuItem.Name = "лікаріToolStripMenuItem";
            this.лікаріToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.лікаріToolStripMenuItem.Text = "Спеціалісти";
            this.лікаріToolStripMenuItem.Click += new System.EventHandler(this.MenuDoctorsForm_Click);
            // 
            // аналітикаToolStripMenuItem
            // 
            this.аналітикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аналітикаПрофіліТаВідгукиToolStripMenuItem,
            this.аналізВідповідностіНавичокToolStripMenuItem,
            this.журналСпівбесідToolStripMenuItem,
            this.звітПроНеповнотуДанихToolStripMenuItem,
            this.аналізАктуальностіДовідниківToolStripMenuItem});
            this.аналітикаToolStripMenuItem.Name = "аналітикаToolStripMenuItem";
            this.аналітикаToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.аналітикаToolStripMenuItem.Text = "Аналітика";
            // 
            // аналітикаПрофіліТаВідгукиToolStripMenuItem
            // 
            this.аналітикаПрофіліТаВідгукиToolStripMenuItem.Name = "аналітикаПрофіліТаВідгукиToolStripMenuItem";
            this.аналітикаПрофіліТаВідгукиToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.аналітикаПрофіліТаВідгукиToolStripMenuItem.Text = "Аналітика: Профілі та Відгуки";
            this.аналітикаПрофіліТаВідгукиToolStripMenuItem.Click += new System.EventHandler(this.аналітикаПрофіліТаВідгукиToolStripMenuItem_Click);
            // 
            // аналізВідповідностіНавичокToolStripMenuItem
            // 
            this.аналізВідповідностіНавичокToolStripMenuItem.Name = "аналізВідповідностіНавичокToolStripMenuItem";
            this.аналізВідповідностіНавичокToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.аналізВідповідностіНавичокToolStripMenuItem.Text = "Аналіз відповідності навичок";
            this.аналізВідповідностіНавичокToolStripMenuItem.Click += new System.EventHandler(this.аналізВідповідностіНавичокToolStripMenuItem_Click);
            // 
            // журналСпівбесідToolStripMenuItem
            // 
            this.журналСпівбесідToolStripMenuItem.Name = "журналСпівбесідToolStripMenuItem";
            this.журналСпівбесідToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.журналСпівбесідToolStripMenuItem.Text = "Журнал співбесід";
            this.журналСпівбесідToolStripMenuItem.Click += new System.EventHandler(this.журналСпівбесідToolStripMenuItem_Click);
            // 
            // звітПроНеповнотуДанихToolStripMenuItem
            // 
            this.звітПроНеповнотуДанихToolStripMenuItem.Name = "звітПроНеповнотуДанихToolStripMenuItem";
            this.звітПроНеповнотуДанихToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.звітПроНеповнотуДанихToolStripMenuItem.Text = "Звіт про неповноту даних";
            this.звітПроНеповнотуДанихToolStripMenuItem.Click += new System.EventHandler(this.звітПроНеповнотуДанихToolStripMenuItem_Click);
            // 
            // аналізАктуальностіДовідниківToolStripMenuItem
            // 
            this.аналізАктуальностіДовідниківToolStripMenuItem.Name = "аналізАктуальностіДовідниківToolStripMenuItem";
            this.аналізАктуальностіДовідниківToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.аналізАктуальностіДовідниківToolStripMenuItem.Text = "Аналіз актуальності довідників";
            this.аналізАктуальностіДовідниківToolStripMenuItem.Click += new System.EventHandler(this.аналізАктуальностіДовідниківToolStripMenuItem_Click);
            // 
            // довідникиToolStripMenuItem
            // 
            this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.містаToolStripMenuItem,
            this.спеціалізаціїToolStripMenuItem,
            this.навичкиToolStripMenuItem,
            this.типиЗайнятостіToolStripMenuItem,
            this.рівніОсвітиToolStripMenuItem,
            this.валютиToolStripMenuItem});
            this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
            this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.довідникиToolStripMenuItem.Text = "Довідники";
            // 
            // містаToolStripMenuItem
            // 
            this.містаToolStripMenuItem.Name = "містаToolStripMenuItem";
            this.містаToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.містаToolStripMenuItem.Text = "Міста";
            this.містаToolStripMenuItem.Click += new System.EventHandler(this.містаToolStripMenuItem_Click);
            // 
            // спеціалізаціїToolStripMenuItem
            // 
            this.спеціалізаціїToolStripMenuItem.Name = "спеціалізаціїToolStripMenuItem";
            this.спеціалізаціїToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.спеціалізаціїToolStripMenuItem.Text = "Спеціалізації";
            this.спеціалізаціїToolStripMenuItem.Click += new System.EventHandler(this.спеціалізаціїToolStripMenuItem_Click);
            // 
            // навичкиToolStripMenuItem
            // 
            this.навичкиToolStripMenuItem.Name = "навичкиToolStripMenuItem";
            this.навичкиToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.навичкиToolStripMenuItem.Text = "Навички";
            this.навичкиToolStripMenuItem.Click += new System.EventHandler(this.навичкиToolStripMenuItem_Click);
            // 
            // типиЗайнятостіToolStripMenuItem
            // 
            this.типиЗайнятостіToolStripMenuItem.Name = "типиЗайнятостіToolStripMenuItem";
            this.типиЗайнятостіToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.типиЗайнятостіToolStripMenuItem.Text = "Типи зайнятості";
            this.типиЗайнятостіToolStripMenuItem.Click += new System.EventHandler(this.типиЗайнятостіToolStripMenuItem_Click);
            // 
            // рівніОсвітиToolStripMenuItem
            // 
            this.рівніОсвітиToolStripMenuItem.Name = "рівніОсвітиToolStripMenuItem";
            this.рівніОсвітиToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.рівніОсвітиToolStripMenuItem.Text = "Рівні освіти";
            this.рівніОсвітиToolStripMenuItem.Click += new System.EventHandler(this.рівніОсвітиToolStripMenuItem_Click);
            // 
            // валютиToolStripMenuItem
            // 
            this.валютиToolStripMenuItem.Name = "валютиToolStripMenuItem";
            this.валютиToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.валютиToolStripMenuItem.Text = "Валюти";
            this.валютиToolStripMenuItem.Click += new System.EventHandler(this.валютиToolStripMenuItem_Click);
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.авторToolStripMenuItem});
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Статус";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(843, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(163, 22);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Компанія";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(62, 26);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 4;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(1012, 23);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(133, 30);
            this.btnResetFilters.TabIndex = 11;
            this.btnResetFilters.Text = "Скинути фільтри";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.buttonResetFilters_Click);
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(261, 27);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(178, 22);
            this.textBoxCompany.TabIndex = 12;
            this.textBoxCompany.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSalaryFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxCurrencies);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCompany);
            this.groupBox1.Controls.Add(this.btnResetFilters);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтри даних";
            // 
            // textBoxSalaryFrom
            // 
            this.textBoxSalaryFrom.Location = new System.Drawing.Point(717, 26);
            this.textBoxSalaryFrom.Name = "textBoxSalaryFrom";
            this.textBoxSalaryFrom.Size = new System.Drawing.Size(115, 22);
            this.textBoxSalaryFrom.TabIndex = 16;
            this.textBoxSalaryFrom.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Зарплата";
            // 
            // comboBoxCurrencies
            // 
            this.comboBoxCurrencies.FormattingEnabled = true;
            this.comboBoxCurrencies.Location = new System.Drawing.Point(508, 26);
            this.comboBoxCurrencies.Name = "comboBoxCurrencies";
            this.comboBoxCurrencies.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCurrencies.TabIndex = 13;
            this.comboBoxCurrencies.SelectedValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Валюта";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddNewAppoitment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Електронна реєстратура біржі праці";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddNewAppoitment;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Запускаємо завантаження даних
            LoadVacancyStatuses(comboBoxStatus);
            LoadCurrencies(comboBoxCurrencies);
            RefreshGrid();
        }

        // Екземпляр сервісу для взаємодії з даними вакансій
        private readonly GridDataLoaderService _dataLoaderService = new GridDataLoaderService(DbConfig.ConnectionString);

        // Оновлює вміст таблиці DataGridView на основі обраних користувачем фільтрів.
        // Викликається при зміні елементів керування або завантаженні форми.
        private void RefreshGrid()
        {
            try
            {
                // Зчитуємо параметри фільтрації з елементів UI
                VacancyFilterParameters filters = BuildFilterQuery();

                // Отримуємо дані з БД через ізольований сервіс
                DataTable dt = _dataLoaderService.GetVacanciesData(filters);

                // Прив'язуємо отриману таблицю до табличного компонента UI
                dataGridView1.DataSource = dt;

                // Застосовуємо стилізацію та розміри колонок
                ApplyGridFormatting();
            }
            catch (Exception ex)
            {
                // Відображення повідомлення про помилку користувачеві
                MessageBox.Show(this, "Помилка: " + ex.Message);
            }
        }

        // Збирає значення з графічних елементів керування у структуровану модель параметрів.
        // return - Заповнений об'єкт VacancyFilterParameters
        private VacancyFilterParameters BuildFilterQuery()
        {
            VacancyFilterParameters filters = new VacancyFilterParameters
            {
                // Очищення тексту від зайвих пробілів
                CompanyName = textBoxCompany.Text.Trim(),
                // Перевірка вибору значення в comboBoxStatus (індекс 0 відповідає пункту "Усі")
                StatusId = (comboBoxStatus.SelectedValue != null && comboBoxStatus.SelectedIndex != 0)
                    ? comboBoxStatus.SelectedValue
                    : null,
                // Перевірка вибору значення в comboBoxCurrencies (індекс 0 відповідає пункту "Усі")
                CurrencyId = (comboBoxCurrencies.SelectedValue != null && comboBoxCurrencies.SelectedIndex != 0)
                    ? comboBoxCurrencies.SelectedValue
                    : null,
                // Перевірка стану прапорця в полі вибору дати
                VacancyDate = dateTimePicker.Checked ? dateTimePicker.Value.Date : (DateTime?)null
            };

            // Парсинг числового значення заробітної плати
            if (decimal.TryParse(textBoxSalaryFrom.Text, out decimal sFrom))
            {
                filters.SalaryFrom = sFrom;
            }

            return filters;
        }

        // Налаштовує зовнішній вигляд, ширину та режим розтягування колонок DataGridView.
        private void ApplyGridFormatting()
        {
            // Якщо дані відсутні або колонки ще не створені — перериваємо виконання
            if (dataGridView1.Columns.Count == 0) return;

            // Встановлення фіксованої ширини для ідентифікатора
            if (dataGridView1.Columns.Contains("№"))
                dataGridView1.Columns["№"].Width = 40;

            // Автоматичне розтягування колонки з назвою вакансії по всій ширині
            if (dataGridView1.Columns.Contains("Назва вакансії"))
                dataGridView1.Columns["Назва вакансії"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Ширина колонки із заробітною платою
            if (dataGridView1.Columns.Contains("Зарплата"))
                dataGridView1.Columns["Зарплата"].Width = 100;

            // Фіксація розміру лівого заголовка рядка
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Перевіряємо, чи користувач клікнув на рядок з даними, а не на заголовок
            if (e.RowIndex >= 0)
            {
                // Отримуємо ID вакансії з першої колонки (яку ми назвали "№")
                int vacancyId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["№"].Value);

                // Відкриваємо вікно з деталями
                VacancyDetailsForm detailsForm = new VacancyDetailsForm(vacancyId);
                detailsForm.StartPosition = FormStartPosition.CenterParent;
                detailsForm.ShowDialog();
            }
        }
        private void LoadVacancyStatuses(ComboBox cmb)
        {
            // Оновлений запит до нової бази даних labor_exchange_db та таблиці vacancy_statuses
            string sql = "SELECT status_id, name FROM labor_exchange_db.vacancy_statuses;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConfig.ConnectionString))
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Додаємо дефолтний варіант для фільтрації
                    DataRow row = dt.NewRow();
                    row["status_id"] = 0; // Для цілих чисел краще використовувати 0 або спеціальний маркер
                    row["name"] = "Всі статуси";
                    dt.Rows.InsertAt(row, 0);

                    // Прив'язка даних
                    cmb.DataSource = dt;
                    cmb.DisplayMember = "name";    // Текст, який бачить користувач
                    cmb.ValueMember = "status_id"; // ID, яке ми будемо використовувати в SQL запиті

                    cmb.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Помилка завантаження статусів вакансій: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrencies(ComboBox cmb)
        {
            // Запит: вибираємо ID для значення та об'єднуємо код з назвою для відображення
            string sql = "SELECT currency_id, CONCAT(code, ' - ', name) AS display_name FROM labor_exchange_db.currencies;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConfig.ConnectionString))
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Додаємо варіант "Всі валюти" для фільтрації на головній формі
                    DataRow row = dt.NewRow();
                    row["currency_id"] = 0;
                    row["display_name"] = "Всі валюти";
                    dt.Rows.InsertAt(row, 0);

                    cmb.DataSource = dt;
                    cmb.DisplayMember = "display_name"; // Користувач бачить "UAH - Гривня"
                    cmb.ValueMember = "currency_id";    // Програма оперує числом ID

                    cmb.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Помилка завантаження валют: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem аналітикаToolStripMenuItem;
        private ToolStripMenuItem допомогаToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStripMenuItem авторToolStripMenuItem;
        private ToolStripMenuItem employersToolStripMenuItem;
        private ToolStripMenuItem лікаріToolStripMenuItem;
        private ToolStripMenuItem вийтиЗПрограмиToolStripMenuItem;
        private ToolStripMenuItem довідникиToolStripMenuItem;
        private ToolStripMenuItem містаToolStripMenuItem;
        private ToolStripMenuItem спеціалізаціїToolStripMenuItem;
        private ToolStripMenuItem навичкиToolStripMenuItem;
        private ToolStripMenuItem рівніОсвітиToolStripMenuItem;
        private ToolStripMenuItem валютиToolStripMenuItem;
        private ToolStripMenuItem роботаToolStripMenuItem;
        private ToolStripMenuItem вакансіїToolStripMenuItem;
        private ToolStripMenuItem відгукиToolStripMenuItem;
        private ToolStripMenuItem типиЗайнятостіToolStripMenuItem;
        private Label label3;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private ComboBox comboBoxStatus;
        private Button btnResetFilters;
        private TextBox textBoxCompany;
        private GroupBox groupBox1;
        private ComboBox comboBoxCurrencies;
        private Label label1;
        private TextBox textBoxSalaryFrom;
        private Label label2;
        private ToolStripMenuItem аналітикаПрофіліТаВідгукиToolStripMenuItem;
        private ToolStripMenuItem аналізВідповідностіНавичокToolStripMenuItem;
        private ToolStripMenuItem журналСпівбесідToolStripMenuItem;
        private ToolStripMenuItem звітПроНеповнотуДанихToolStripMenuItem;
        private ToolStripMenuItem аналізАктуальностіДовідниківToolStripMenuItem;
    }
}


using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LaborExchange_System
{
    partial class AddVacancyForm
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
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.buttonSetInsertion = new System.Windows.Forms.Button();
            this.buttonCancelInsertion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.Currency = new System.Windows.Forms.Label();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(110, 203);
            this.comboBoxCompany.MaxDropDownItems = 5;
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(364, 24);
            this.comboBoxCompany.TabIndex = 0;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.ItemHeight = 16;
            this.comboBoxStatus.Location = new System.Drawing.Point(370, 241);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(104, 24);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(231, 241);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(74, 24);
            this.comboBoxCurrency.TabIndex = 3;
            // 
            // buttonSetInsertion
            // 
            this.buttonSetInsertion.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonSetInsertion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetInsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetInsertion.ForeColor = System.Drawing.Color.White;
            this.buttonSetInsertion.Location = new System.Drawing.Point(12, 277);
            this.buttonSetInsertion.Name = "buttonSetInsertion";
            this.buttonSetInsertion.Size = new System.Drawing.Size(213, 30);
            this.buttonSetInsertion.TabIndex = 4;
            this.buttonSetInsertion.Text = "Записати";
            this.buttonSetInsertion.UseVisualStyleBackColor = false;
            this.buttonSetInsertion.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancelInsertion
            // 
            this.buttonCancelInsertion.BackColor = System.Drawing.Color.Red;
            this.buttonCancelInsertion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelInsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelInsertion.ForeColor = System.Drawing.Color.White;
            this.buttonCancelInsertion.Location = new System.Drawing.Point(259, 277);
            this.buttonCancelInsertion.Name = "buttonCancelInsertion";
            this.buttonCancelInsertion.Size = new System.Drawing.Size(215, 30);
            this.buttonCancelInsertion.TabIndex = 5;
            this.buttonCancelInsertion.Text = "Відмінити";
            this.buttonCancelInsertion.UseVisualStyleBackColor = false;
            this.buttonCancelInsertion.Click += new System.EventHandler(this.buttonCancelInsertion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Компанія";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(311, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Статус";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(110, 13);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(364, 22);
            this.textBoxTitle.TabIndex = 11;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(8, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(77, 16);
            this.Title.TabIndex = 12;
            this.Title.Text = "Заголовок";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(8, 55);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(95, 16);
            this.Description.TabIndex = 14;
            this.Description.Text = "Опис вакансії";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AcceptsReturn = true;
            this.textBoxDescription.Location = new System.Drawing.Point(110, 52);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(364, 137);
            this.textBoxDescription.TabIndex = 13;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salary.Location = new System.Drawing.Point(8, 245);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(63, 16);
            this.Salary.TabIndex = 16;
            this.Salary.Text = "Зрплата";
            // 
            // Currency
            // 
            this.Currency.AutoSize = true;
            this.Currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Currency.Location = new System.Drawing.Point(168, 245);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(57, 16);
            this.Currency.TabIndex = 17;
            this.Currency.Text = "Валюта";
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSalary.Location = new System.Drawing.Point(77, 241);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(85, 22);
            this.numericUpDownSalary.TabIndex = 18;
            // 
            // AddVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 323);
            this.ControlBox = false;
            this.Controls.Add(this.numericUpDownSalary);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelInsertion);
            this.Controls.Add(this.buttonSetInsertion);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxCompany);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddVacancyForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = " Додавання вакансії";
            this.Load += new System.EventHandler(this.AddVacancyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Button buttonSetInsertion;
        private System.Windows.Forms.Button buttonCancelInsertion;
        private Label label2;
        private Label label3;
        private TextBox textBoxTitle;
        private Label Title;
        private Label Description;
        private TextBox textBoxDescription;
        private Label Salary;
        private Label Currency;
        private NumericUpDown numericUpDownSalary;
    }
}
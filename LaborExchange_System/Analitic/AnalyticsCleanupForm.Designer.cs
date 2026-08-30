using System.Windows.Forms;

namespace LaborExchange_System.Analitic
{
    partial class AnalyticsCleanupForm
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
            this.dataGridViewCleanup = new System.Windows.Forms.DataGridView();
            this.labelWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCleanup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCleanup
            // 
            this.dataGridViewCleanup.AllowUserToAddRows = false;
            this.dataGridViewCleanup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCleanup.ColumnHeadersHeight = 29;
            this.dataGridViewCleanup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCleanup.Location = new System.Drawing.Point(10, 60);
            this.dataGridViewCleanup.Name = "dataGridViewCleanup";
            this.dataGridViewCleanup.ReadOnly = true;
            this.dataGridViewCleanup.RowHeadersWidth = 51;
            this.dataGridViewCleanup.Size = new System.Drawing.Size(580, 203);
            this.dataGridViewCleanup.TabIndex = 0;
            // 
            // labelWarning
            // 
            this.labelWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelWarning.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelWarning.Location = new System.Drawing.Point(10, 10);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(580, 50);
            this.labelWarning.TabIndex = 1;
            this.labelWarning.Text = "Увага! Навички в списку нижче не прив\'язані до жодного спеціаліста або вакансії.";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnalyticsCleanupForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 273);
            this.Controls.Add(this.dataGridViewCleanup);
            this.Controls.Add(this.labelWarning);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalyticsCleanupForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аналіз актуальності довідників";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCleanup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCleanup;
        private System.Windows.Forms.Label labelWarning;
    }
}
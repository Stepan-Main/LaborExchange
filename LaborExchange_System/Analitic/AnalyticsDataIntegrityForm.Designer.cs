using System.Windows.Forms;

namespace LaborExchange_System.Analitic
{
    partial class AnalyticsDataIntegrityForm
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
            this.dataGridViewIntegrity = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntegrity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIntegrity
            // 
            this.dataGridViewIntegrity.AllowUserToAddRows = false;
            this.dataGridViewIntegrity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIntegrity.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewIntegrity.ColumnHeadersHeight = 29;
            this.dataGridViewIntegrity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIntegrity.Location = new System.Drawing.Point(10, 70);
            this.dataGridViewIntegrity.Name = "dataGridViewIntegrity";
            this.dataGridViewIntegrity.ReadOnly = true;
            this.dataGridViewIntegrity.RowHeadersWidth = 51;
            this.dataGridViewIntegrity.Size = new System.Drawing.Size(422, 193);
            this.dataGridViewIntegrity.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelInfo.Location = new System.Drawing.Point(10, 10);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(422, 60);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Звіт про неповноту даних: Спеціалісти без резюме та Вакансії без вказаних навичок" +
    "";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnalyticsDataIntegrityForm
            // 
            this.ClientSize = new System.Drawing.Size(442, 273);
            this.Controls.Add(this.dataGridViewIntegrity);
            this.Controls.Add(this.labelInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalyticsDataIntegrityForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аналіз повноти заповнення (Data Integrity)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntegrity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIntegrity;
        private System.Windows.Forms.Label labelInfo;
    }
}
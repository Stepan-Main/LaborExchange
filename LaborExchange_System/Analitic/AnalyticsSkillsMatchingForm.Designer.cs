using System.Windows.Forms;

namespace LaborExchange_System.Analitic
{
    partial class AnalyticsSkillsMatchingForm
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
            this.dataGridViewMatching = new System.Windows.Forms.DataGridView();
            this.labelHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatching)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatching
            // 
            this.dataGridViewMatching.AllowUserToAddRows = false;
            this.dataGridViewMatching.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatching.ColumnHeadersHeight = 29;
            this.dataGridViewMatching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatching.Location = new System.Drawing.Point(10, 60);
            this.dataGridViewMatching.Name = "dataGridViewMatching";
            this.dataGridViewMatching.ReadOnly = true;
            this.dataGridViewMatching.RowHeadersWidth = 51;
            this.dataGridViewMatching.Size = new System.Drawing.Size(482, 203);
            this.dataGridViewMatching.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(10, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(482, 50);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Аналіз відповідності навичок кандидатів вимогам вакансій";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnalyticsSkillsMatchingForm
            // 
            this.ClientSize = new System.Drawing.Size(502, 273);
            this.Controls.Add(this.dataGridViewMatching);
            this.Controls.Add(this.labelHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalyticsSkillsMatchingForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матчинг навичок";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatching)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatching;
        private System.Windows.Forms.Label labelHeader;
    }
}
using System.Windows.Forms;

namespace LaborExchange_System.Analitic
{
    partial class AnalyticsCandidateProfileForm
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
            this.dataGridViewAnalytics = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalytics)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAnalytics
            // 
            this.dataGridViewAnalytics.AllowUserToAddRows = false;
            this.dataGridViewAnalytics.AllowUserToDeleteRows = false;
            this.dataGridViewAnalytics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewAnalytics.ColumnHeadersHeight = 29;
            this.dataGridViewAnalytics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAnalytics.Location = new System.Drawing.Point(10, 60);
            this.dataGridViewAnalytics.Name = "dataGridViewAnalytics";
            this.dataGridViewAnalytics.ReadOnly = true;
            this.dataGridViewAnalytics.RowHeadersVisible = false;
            this.dataGridViewAnalytics.RowHeadersWidth = 51;
            this.dataGridViewAnalytics.Size = new System.Drawing.Size(782, 161);
            this.dataGridViewAnalytics.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(10, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(782, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(782, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Повний профіль кандидата та історія відгуків";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnalyticsCandidateProfileForm
            // 
            this.ClientSize = new System.Drawing.Size(802, 221);
            this.Controls.Add(this.dataGridViewAnalytics);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalyticsCandidateProfileForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Text = "Аналітика: Профілі та Відгуки";
            this.Load += new System.EventHandler(this.AnalyticsForm_Load);
            // ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalytics)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewAnalytics;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPrintSchedule;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFilters;
    }
}
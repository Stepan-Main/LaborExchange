using System.Windows.Forms;

namespace LaborExchange_System.Data
{
    partial class ApplicationsForm
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
            this.dataGridViewApps = new System.Windows.Forms.DataGridView();
            this.comboBoxStatusFilter = new System.Windows.Forms.ComboBox();
            this.textBoxSpecSearch = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApps)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewApps
            // 
            this.dataGridViewApps.AllowUserToAddRows = false;
            this.dataGridViewApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewApps.ColumnHeadersHeight = 29;
            this.dataGridViewApps.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewApps.Name = "dataGridViewApps";
            this.dataGridViewApps.ReadOnly = true;
            this.dataGridViewApps.RowHeadersWidth = 51;
            this.dataGridViewApps.Size = new System.Drawing.Size(762, 163);
            this.dataGridViewApps.TabIndex = 0;
            // 
            // comboBoxStatusFilter
            // 
            this.comboBoxStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusFilter.Location = new System.Drawing.Point(251, 48);
            this.comboBoxStatusFilter.Name = "comboBoxStatusFilter";
            this.comboBoxStatusFilter.Size = new System.Drawing.Size(180, 24);
            this.comboBoxStatusFilter.TabIndex = 2;
            this.comboBoxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusFilter_SelectedIndexChanged);
            // 
            // textBoxSpecSearch
            // 
            this.textBoxSpecSearch.Location = new System.Drawing.Point(12, 50);
            this.textBoxSpecSearch.Name = "textBoxSpecSearch";
            this.textBoxSpecSearch.Size = new System.Drawing.Size(200, 22);
            this.textBoxSpecSearch.TabIndex = 1;
            this.textBoxSpecSearch.TextChanged += new System.EventHandler(this.textBoxSpecSearch_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(802, 40);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Управління відгуками на вакансії";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApplicationsForm
            // 
            this.ClientSize = new System.Drawing.Size(802, 273);
            this.Controls.Add(this.dataGridViewApps);
            this.Controls.Add(this.textBoxSpecSearch);
            this.Controls.Add(this.comboBoxStatusFilter);
            this.Controls.Add(this.labelTitle);
            this.Name = "ApplicationsForm";
            this.Text = "Вікно відгуків";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewApps;
        private System.Windows.Forms.ComboBox comboBoxStatusFilter;
        private System.Windows.Forms.TextBox textBoxSpecSearch;
        private System.Windows.Forms.Label labelTitle;
    }
}
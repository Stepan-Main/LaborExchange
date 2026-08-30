namespace LaborExchange_System.Data
{
    partial class VacancyDetailsForm
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
            this.components = new System.ComponentModel.Container();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // labelCompany
            // 
            this.labelCompany.Location = new System.Drawing.Point(12, 45);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Padding = new System.Windows.Forms.Padding(10);
            this.labelCompany.Size = new System.Drawing.Size(215, 36);
            this.labelCompany.TabIndex = 0;
            this.labelCompany.Text = "labelCompany";
            this.labelCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSalary
            // 
            this.labelSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalary.Location = new System.Drawing.Point(233, 45);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Padding = new System.Windows.Forms.Padding(10);
            this.labelSalary.Size = new System.Drawing.Size(221, 36);
            this.labelSalary.TabIndex = 1;
            this.labelSalary.Text = "labelSalary";
            this.labelSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 84);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(443, 155);
            this.textBoxDescription.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(10);
            this.labelTitle.Size = new System.Drawing.Size(443, 36);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "labelTitle";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // VacancyDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 251);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VacancyDetailsForm";
            this.Text = "Подробиці вакансії";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
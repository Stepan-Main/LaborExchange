namespace LaborExchange_System.Data
{
    partial class CompanyDetailsForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelWeb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName (Назва компанії)
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(5);
            this.labelName.Size = new System.Drawing.Size(442, 36);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "labelName";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCity (Місто)
            // 
            this.labelCity.Location = new System.Drawing.Point(12, 45);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(215, 25);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "Місто:";
            // 
            // labelSpec (Спеціалізація)
            // 
            this.labelSpec.Location = new System.Drawing.Point(233, 45);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(221, 25);
            this.labelSpec.TabIndex = 2;
            this.labelSpec.Text = "Сфера:";
            // 
            // labelContact (Контактна особа)
            // 
            this.labelContact.Location = new System.Drawing.Point(12, 70);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(442, 25);
            this.labelContact.TabIndex = 3;
            this.labelContact.Text = "Контакт:";
            // 
            // labelPhone (Телефон)
            // 
            this.labelPhone.Location = new System.Drawing.Point(12, 95);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(215, 25);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Тел:";
            // 
            // labelWeb (Сайт)
            // 
            this.labelWeb.ForeColor = System.Drawing.Color.Blue;
            this.labelWeb.Location = new System.Drawing.Point(233, 95);
            this.labelWeb.Name = "labelWeb";
            this.labelWeb.Size = new System.Drawing.Size(221, 25);
            this.labelWeb.TabIndex = 5;
            this.labelWeb.Text = "Сайт";
            this.labelWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // textBoxDescription (Опис)
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDescription.Location = new System.Drawing.Point(12, 130);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(442, 120);
            this.textBoxDescription.TabIndex = 6;
            // 
            // CompanyDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 265);
            this.Controls.Add(this.labelWeb);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanyDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Детальна інформація про компанію";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelWeb;
    }
}
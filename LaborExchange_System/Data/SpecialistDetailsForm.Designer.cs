namespace Polyclinic_e_reception.Data
{
    partial class SpecialistDetailsForm
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
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.textBoxResume = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // labelFullName (ПІБ - Головний заголовок)
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelFullName.Location = new System.Drawing.Point(12, 9);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(442, 35);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelBirthDate
            this.labelBirthDate.Location = new System.Drawing.Point(12, 50);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(215, 25);
            this.labelBirthDate.Text = "Дата народж:";

            // labelCity
            this.labelCity.Location = new System.Drawing.Point(233, 50);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(221, 25);
            this.labelCity.Text = "Місто:";

            // labelSpec
            this.labelSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelSpec.Location = new System.Drawing.Point(12, 75);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(442, 25);
            this.labelSpec.Text = "Спеціалізація:";

            // labelPhone
            this.labelPhone.Location = new System.Drawing.Point(12, 100);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(215, 25);
            this.labelPhone.Text = "Тел:";

            // labelEmail
            this.labelEmail.Location = new System.Drawing.Point(233, 100);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(221, 25);
            this.labelEmail.Text = "Email:";

            // textBoxResume (Повна інформація/Резюме)
            this.textBoxResume.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResume.Location = new System.Drawing.Point(12, 135);
            this.textBoxResume.Multiline = true;
            this.textBoxResume.Name = "textBoxResume";
            this.textBoxResume.ReadOnly = true;
            this.textBoxResume.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResume.Size = new System.Drawing.Size(442, 140);
            this.textBoxResume.TabIndex = 1;

            // Form SpecialistDetailsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 290);
            this.Controls.Add(this.textBoxResume);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpecialistDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Картка спеціаліста";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.TextBox textBoxResume;
        private System.Windows.Forms.Label labelCity;

        #endregion
    }
}
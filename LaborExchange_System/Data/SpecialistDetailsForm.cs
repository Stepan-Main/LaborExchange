using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic_e_reception.Data
{
    public partial class SpecialistDetailsForm : Form
    {
        public SpecialistDetailsForm(DataRow row)
        {
            InitializeComponent();

            labelFullName.Text = $"{row["Прізвище"]} {row["Імʼя"]}";
            labelBirthDate.Text = "Вік: " + row["Вік"].ToString();
            labelCity.Text = "Місто: " + row["Місто"].ToString();
            labelSpec.Text = "Освіта: " + row["Освіта"].ToString();
            labelPhone.Text = "Тел: " + row["Телефон"].ToString();
            labelEmail.Text = "Email: " + row["Email"].ToString();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaborExchange_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Встановлюємо українську культуру для потоку
            CultureInfo culture = new CultureInfo("uk-UA");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open(); // Намагаємось відкрити з'єднання
                }
                // Якщо все добре, запускаємо програму
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                // Якщо сервер MySQL не відповідає, показуємо помилку і не запускаємо форму
                MessageBox.Show("Не вдалося підключитися до бази даних!\nПеревірте, чи запущено сервер MySQL.\n\nДеталі: " + ex.Message,
                                "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LaborExchange_System
{
    // Модель для передачі параметрів фільтрації списку вакансій з UI до сервісу даних.
    public class VacancyFilterParameters
    {
        // Назва компанії або її частина для пошуку через LIKE
        public string CompanyName { get; set; }

        // Унікальний ідентифікатор статусу вакансії 
        public object StatusId { get; set; }

        // Унікальний ідентифікатор валюти
        public object CurrencyId { get; set; }

        // Точна дата публікації вакансії для фільтрації 
        public DateTime? VacancyDate { get; set; }

        // Мінімальний поріг заробітної плати
        public decimal? SalaryFrom { get; set; }
    }

    // Сервіс для виконання завантаження та вибірки даних вакансій із бази даних MySQL.
    // Забезпечує відокремлення SQL-логіки від інтерфейсу користувача (SRP).
    internal class GridDataLoaderService
    {
        // Рядок підключення до бази даних MySQL
        private readonly string _connectionString;

        // Ініціалізує новий екземпляр сервісу завантаження даних.
        // param connectionString - Рядок підключення до БД MySQL
        public GridDataLoaderService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Отримує відфільтрований список вакансій у вигляді структури DataTable.
        // param filters - Об'єкт із критеріями фільтрації
        public DataTable GetVacanciesData(VacancyFilterParameters filters)
        {
            // SQL-запит із параметризованими умовами для запобігання SQL-ін'єкціям
            string sql = @"
                SELECT 
                    V.vacancy_id AS '№', 
                    V.title AS 'Назва вакансії', 
                    C.name AS 'Компанія', 
                    V.salary AS 'Зарплата', 
                    Curr.code AS 'Валюта',
                    S.name AS 'Статус',
                    V.created_at AS 'Дата публікації'
                FROM labor_exchange_db.vacancies V
                JOIN labor_exchange_db.companies C ON V.company_id = C.company_id
                JOIN labor_exchange_db.currencies Curr ON V.currency_id = Curr.currency_id
                JOIN labor_exchange_db.vacancy_statuses S ON V.status_id = S.status_id
                WHERE (@company_name = '' OR C.name LIKE @company_name) AND 
                    (@status_id IS NULL OR V.status_id = @status_id) AND 
                    (@currency_id IS NULL OR V.currency_id = @currency_id) AND 
                    (V.salary >= @salary_from OR @salary_from IS NULL) AND
                    (DATE(V.created_at) = DATE(@vac_date) OR @vac_date IS NULL)
                ORDER BY V.created_at DESC;";

            // Автоматичне закриття з'єднання та звільнення ресурсів через блок using
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    // Підготовка параметрів фільтрації
                    cmd.Parameters.AddWithValue("@company_name", "%" + (filters.CompanyName ?? string.Empty) + "%");
                    cmd.Parameters.AddWithValue("@status_id", filters.StatusId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@currency_id", filters.CurrencyId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@vac_date", filters.VacancyDate.HasValue ? (object)filters.VacancyDate.Value.Date : DBNull.Value);
                    cmd.Parameters.AddWithValue("@salary_from", filters.SalaryFrom.HasValue ? (object)filters.SalaryFrom.Value : DBNull.Value);

                    // Виконання запиту та заповнення таблиці результатів
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}

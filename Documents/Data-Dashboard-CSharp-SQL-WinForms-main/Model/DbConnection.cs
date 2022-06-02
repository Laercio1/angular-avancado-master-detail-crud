using System.Data.SqlClient;

namespace DashboardApp.Model
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = @"Data Source = NSYS-CDS-0301\SQLDESENVOLVEDOR; Initial Catalog = NorthwindStore; Integrated Security = True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

using MySql.Data.MySqlClient;
using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace EF_Console
{
    class AppDbDapperConnectionFactory
    {

        public IDbConnection CreateConnection()
        {
            var setting = AppConfig.Instance.DatabaseSetting;

            var connectionString = AppDbConnectionBuilder.Build(setting);

            var dbType = setting.DatabaseType.ToLower();
            if (dbType == "postgres")
                return new NpgsqlConnection(connectionString);
            else if (dbType == "sqlserver")
                return new SqlConnection(connectionString);
            else if (dbType == "sqlserver")
                return new SqlConnection(connectionString);
            else if (dbType == "mysql")
                return new MySqlConnection(connectionString);
            else { }

            return null;
        }
    }
}

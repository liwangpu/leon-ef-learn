using Microsoft.Extensions.Configuration;
using System.IO;

namespace EF_Console
{
    class AppConfig
    {
        public static AppConfig Instance { get; protected set; }
        public DatabaseSetting DatabaseSetting { get; protected set; }

        private AppConfig() { }

        public static void Config()
        {
            if (Instance == null)
            {
                Instance = new AppConfig();


                var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                var configuration = builder.Build();
                var server = configuration["DatabaseSetting:Server"];
                var port = configuration["DatabaseSetting:Port"];
                var databaseType = configuration["DatabaseSetting:Type"];
                var database = configuration["DatabaseSetting:Database"];
                var userId = configuration["DatabaseSetting:UserId"];
                var password = configuration["DatabaseSetting:Password"];

                Instance.DatabaseSetting = new DatabaseSetting(server, port, database, userId, password, databaseType);
            }

        }

    }

    class DatabaseSetting
    {
        public string Server { get; }
        public string Port { get; }
        public string Database { get; }
        public string DatabaseType { get; }
        public string UserId { get; }
        public string Password { get; }

        #region ctor
        public DatabaseSetting(string server, string port, string database, string userId, string password, string databaseType)
        {
            Server = server;
            Port = port;
            Database = database;
            UserId = userId;
            Password = password;
            DatabaseType = databaseType;
        }
        #endregion
    }
}

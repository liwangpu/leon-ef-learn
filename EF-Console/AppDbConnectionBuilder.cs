namespace EF_Console
{
    class AppDbConnectionBuilder
    {
        public static string Build(DatabaseSetting setting)
        {
            var dbType = setting.DatabaseType.ToLower();
            if (dbType == "postgres")
            {
                return $"Server={setting.Server};Port={setting.Port};Database={setting.Database};User Id={setting.UserId};Password={setting.Password}";
            }
            else if (dbType == "sqlserver")
            {
                return $"Data Source={setting.Server},{setting.Port};Initial Catalog={setting.Database};User ID={setting.UserId};Password={setting.Password};Persist Security Info=True";
            }
            else if (dbType == "mysql")
            {
                return $"Server={setting.Server};Port={setting.Port};Database={setting.Database};Uid={setting.UserId};Pwd={setting.Password}";
            }
            else { }

            //"Data Source=qds116703363.my3w.com;Initial Catalog=qds116703363_db;Persist Security Info=True;User ID=qds116703363;Password=AAaa123456"

            return "";
        }
    }
}

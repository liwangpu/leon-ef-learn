using Microsoft.EntityFrameworkCore.Design;

namespace EF_Console.Libraries
{
    class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext()
        {
            return CreateDbContext(null);
        }

        public AppDbContext CreateDbContext(string[] args)
        {
            AppConfig.Config();
            return new AppDbContext(AppConfig.Instance.DatabaseSetting);
        }
    }
}

using EF_Console.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace EF_Console
{
    class AppDbContext : DbContext
    {
        public DatabaseSetting Setting { get; protected set; }
        public string ConnectionString { get; protected set; }

        #region ctor
        public AppDbContext(DatabaseSetting setting) :
          base()
        {
            Setting = setting;
        }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConnectionString = AppDbConnectionBuilder.Build(Setting);

            var dbType = Setting.DatabaseType.ToLower();
            if (dbType == "postgres")
            {
                optionsBuilder
                    .UseLoggerFactory(new MyLoggerFactory())
                    .UseNpgsql(ConnectionString);
            }
            else if (dbType == "sqlserver")
            {
                optionsBuilder
                    .UseLoggerFactory(new MyLoggerFactory())
                    .UseSqlServer(ConnectionString);
            }
            else if (dbType == "mysql")
            {
                optionsBuilder
                    .UseLoggerFactory(new MyLoggerFactory())
                    .UseMySQL(ConnectionString);
            }
            else { }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("learning");
            modelBuilder.ApplyConfiguration(new AccountEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AccountTagEntityTypeConfiguration());


            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                // Replace table names
                entity.Relational().TableName = entity.Relational().TableName.ToSnakeCase();

                // Replace column names            
                foreach (var property in entity.GetProperties())
                {
                    property.Relational().ColumnName = property.Name.ToSnakeCase();
                }

                foreach (var key in entity.GetKeys())
                {
                    key.Relational().Name = key.Relational().Name.ToSnakeCase();
                }

                foreach (var key in entity.GetForeignKeys())
                {
                    key.Relational().Name = key.Relational().Name.ToSnakeCase();
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.Relational().Name = index.Relational().Name.ToSnakeCase();
                }
            }
        }

    }
}

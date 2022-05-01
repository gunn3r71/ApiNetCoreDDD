using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ApiNetCoreDDD.Infrastructure.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        /// <summary>
        /// Create a context for design time (Migrations)
        /// </summary>
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=3306;Database=dddAPI;Uid=nse;Pwd=development@lucas1A;";
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), options => {
                options.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
                options.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                options.CommandTimeout(30);
            });

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
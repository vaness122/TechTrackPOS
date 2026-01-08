using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace ByteTech.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var connectionString = Environment.GetEnvironmentVariable("DefaultConnection")
                ?? "Server=localhost;Database=ByteTechPOS;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

            builder.UseSqlServer(connectionString,
                sqlServerOptions => sqlServerOptions.MigrationsAssembly("ByteTech.Infrastructure"));

            return new ApplicationDbContext(builder.Options);
        }
    }
}
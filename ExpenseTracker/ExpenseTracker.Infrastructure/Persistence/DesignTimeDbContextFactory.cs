using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ExpenseTracker.Infrastructure.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ExpenseTrackerDbContext>
{
    public ExpenseTrackerDbContext CreateDbContext(string[] args)
    {
        // Try environment variable first, then look for appsettings.json in parent projects
        var conn = Environment.GetEnvironmentVariable("ConnectionStrings__ExpenseTrackerDbContextConnection");

        if (string.IsNullOrWhiteSpace(conn))
        {
            var basePath = Directory.GetCurrentDirectory();
            // Look up until we find an appsettings.json (covers running from different working dirs)
            for (var i = 0; i < 6 && !File.Exists(Path.Combine(basePath, "appsettings.json")); i++)
            {
                basePath = Path.GetDirectoryName(basePath) ?? basePath;
            }

            var config = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            conn = config.GetConnectionString("ExpenseTrackerDbContextConnection");
        }

        if (string.IsNullOrWhiteSpace(conn))
            throw new InvalidOperationException("Connection string 'ExpenseTrackerDbContextConnection' not found. Set it in environment or appsettings.json.");

        var optionsBuilder = new DbContextOptionsBuilder<ExpenseTrackerDbContext>();
        optionsBuilder.UseSqlServer(conn, b=> b.MigrationsAssembly("ExpenseTracker"));

        return new ExpenseTrackerDbContext(optionsBuilder.Options);
    }
}
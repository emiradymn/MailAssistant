using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MailAssistant.Infrastructure.Persistence.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // API projesinin bulunduğu konuma git
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../MailAssistant.API");

            // appsettings + user secrets birleşsin
            var config = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: false)
               .AddUserSecrets("6bc6a70e-9be4-47e1-b3b3-5be9129f5d23") // 🔥 User Secrets’ı da ekledik
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseNpgsql(connectionString);

            return new AppDbContext(builder.Options);
        }
    }
}

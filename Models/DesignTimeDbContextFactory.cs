using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ECSalon.Models
{
  public class ECSalonContextFactory : IDesignTimeDbContextFactory<ECSalonContext>
  {

    ECSalonContext IDesignTimeDbContextFactory<ECSalonContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ECSalonContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new ECSalonContext(builder.Options);
    }
  }
}

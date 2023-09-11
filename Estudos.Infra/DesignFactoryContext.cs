using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Estudos.Infra;

public class DesignFactoryContext: IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var config =  new ConfigurationBuilder().AddUserSecrets<DataContext>().Build();
        var builder = new DbContextOptionsBuilder<DataContext>();
        var connectionString = config.GetConnectionString("Default");
        builder.UseNpgsql(connectionString);
        Console.WriteLine(connectionString);
        return new DataContext(builder.Options);
    }
}
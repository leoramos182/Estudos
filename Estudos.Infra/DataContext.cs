using System.Reflection;
using Jwks.Manager;
using Jwks.Manager.Store.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Estudos.Infra;

public class DataContext: DbContext, ISecurityKeyContext
{
    public const string Schema = "public";

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        DbContext = this;
    }

    public DbContext DbContext { get; }
    public DbSet<SecurityKeyWithPrivate> SecurityKeys { get; set; }
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.HasDefaultSchema(Schema);
    }
}
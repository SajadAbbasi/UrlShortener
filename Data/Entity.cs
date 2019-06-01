using System.Data.Entity;
using Data.Migrations;
using Model;
namespace Data
{
    public class EFFirstContext : DbContext
    {
        public EFFirstContext() : base("name=UrlShortener")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFFirstContext, Configuration>());
        }

        public DbSet<Url> Urls { get; set; }

    }
}

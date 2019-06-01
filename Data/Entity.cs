using System.Data.Entity;
using Model;
namespace Data
{
    public class EFFirstContext : DbContext
    {
        public EFFirstContext() : base("name=UrlShortener")
        { }

        public DbSet<Url> Urls { get; set; }

    }
}

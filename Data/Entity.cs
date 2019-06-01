using System.Data.Entity;
using Model;
namespace Data
{
    public class Entity
    {
        public class EFFirstContext : DbContext
        {
            public EFFirstContext()
            { }

            public DbSet<Url> Urls { get; set; }

        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace FIREE.MasterDb
{
    public class MasterDb(DbContextOptions<MasterDb> options) : DbContext(options)
    {
        public DbSet<Organisation> Organisations { get; set; }
    }
}

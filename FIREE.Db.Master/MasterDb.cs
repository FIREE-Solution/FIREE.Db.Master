using FIREE.Db.Master.Entities;
using Microsoft.EntityFrameworkCore;

namespace FIREE.Db.Master;

public class MasterDb(DbContextOptions<MasterDb> options) : DbContext(options)
{
    public DbSet<Organisation> Organisations { get; set; }
}

using Microsoft.EntityFrameworkCore;

namespace Praktinis_Baigiamasis_Darbas.DataBase
{
    public class RegistryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=localhost\\MSSQLSERVER01;Database=EgzaminasDb;Trusted_Connection=True;encrypt=false;");
        }
    }
}

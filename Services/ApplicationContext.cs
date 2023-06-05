using Microsoft.EntityFrameworkCore;
using PrototypeApp.Model;

namespace PrototypeApp.Services
{
    public class ApplicationContext : DbContext
    {
        public DbSet<BendingMachine> BendingMachines { get; set; }
        public DbSet<DrillingMachine> DrillingMachines { get; set; }

        public DbSet<Settings> Settings { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<CuttingMachine> CuttingMachines { get; set; }
        public DbSet<WeldingMachine> WeldingMachines { get; set; }
        public DbSet<Report> Reports { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = "Server=localhost;Database=PrototypeAppDB;user=root;password=110899";
            optionsBuilder.UseMySql(connStr, ServerVersion.AutoDetect(connStr));
        }
    }
}

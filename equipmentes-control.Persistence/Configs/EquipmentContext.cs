using equipments_control.Domain;
using Microsoft.EntityFrameworkCore;

namespace equipmentes_control.Persistence.Configs
{
    public class EquipmentContext : DbContext
    {
        public EquipmentContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Equipment>().HasKey(k => k.Id);
            
            modelBuilder.Entity<Brands>().HasKey(k => k.Id);

            modelBuilder.Entity<Departments>().HasKey(k => k.Id);
        }
    }
}

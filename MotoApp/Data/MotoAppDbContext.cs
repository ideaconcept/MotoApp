namespace MotoApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using MotoApp.Entities;

    internal class MotoAppDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}

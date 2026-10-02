// File: Procurement\Data\BoutiqueDbContext.cs
using Microsoft.EntityFrameworkCore;
using ProcurementDev.Models;

namespace ProcurementDev.Data
{
    public class BoutiqueDbContext : DbContext
    {
        public DbSet<ProcurementDev.Models.User> Users { get; set; }
        public DbSet<ProcurementDev.Models.Supplier> Suppliers { get; set; }
        public DbSet<ProcurementDev.Models.PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<ProcurementDev.Models.PurchaseOrderItem> PurchaseOrderItems { get; set; }

        public BoutiqueDbContext() { }

        public BoutiqueDbContext(DbContextOptions<BoutiqueDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BoutiqueProcurementDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProcurementDev.Models.PurchaseOrder>()
                .Property(p => p.TotalCost)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ProcurementDev.Models.PurchaseOrderItem>()
                .Property(p => p.UnitCost)
                .HasPrecision(18, 2);
        }
    }
}
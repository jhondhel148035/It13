using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProcurementDev.Data
{
    public class BoutiqueDbContextFactory : IDesignTimeDbContextFactory<BoutiqueDbContext>
    {
        public BoutiqueDbContext CreateDbContext(string[] args)
        {
            // Using standard LocalDB for MSSQL development
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BoutiqueProcurementDb;Trusted_Connection=True;MultipleActiveResultSets=true";

            var optionsBuilder = new DbContextOptionsBuilder<BoutiqueDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BoutiqueDbContext(optionsBuilder.Options);
        }
    }
}
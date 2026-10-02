using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProcurementDev.Data;
using System;
using System.Windows.Forms;

namespace ProcurementDev
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            // Classic WinForms initialization (compatible with all .NET versions)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Create the Service Collection
            var services = new ServiceCollection();

            // 2. Configure all dependencies
            ConfigureServices(services);

            // 3. Build the Service Provider
            ServiceProvider = services.BuildServiceProvider();

            // 4. Resolve the main form from the DI container
            var mainForm = ServiceProvider.GetRequiredService<Login>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // MSSQL Connection String for LocalDB
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BoutiqueProcurementDb;Trusted_Connection=True;MultipleActiveResultSets=true";

            services.AddDbContext<BoutiqueDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Form Registration
            services.AddTransient<Login>();
        }
    }
}
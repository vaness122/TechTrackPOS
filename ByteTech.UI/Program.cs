using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ByteTech.UI.Dashboard;
using ByteTech.Infrastructure.Data;
using ByteTech.Infrastructure.Repositories;

namespace ByteTech.UI
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();


            string connString = "Server=localhost;Database=ByteTechPOS;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer(connString, sqlOptions => {
                sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorNumbersToAdd: null);
            });

            try
            {
     
                using (var context = new ApplicationDbContext(optionsBuilder.Options))
                {
                    var customerRepo = new CustomerRepository(context);

              
                    Application.Run(new Admin_Dashboard(customerRepo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Startup Error: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
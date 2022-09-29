using System;
using BurgerTown.Data;
using Microsoft.EntityFrameworkCore;

namespace BurgerTown
{
    internal class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });

        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<DataContext>();
                    context.Database.EnsureCreated();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

        static void Main(string[] args)
        {
            //var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddRazorPages();
            //var app = builder.Build();
            
            
            var host = CreateHostBuilder(args).Build();
            CreateDbIfNotExists(host);
            host.Run();

            
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace StoreApp.Infrastructe.Extensions
{
    public static class ApplicationExtension
    {
        public static void ConfigureAndCheckMigration(this IApplicationBuilder app)
        {
            RepositoryContext context = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<RepositoryContext>();
                
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }

        public static void ConfigureLocalization(this WebApplication app)
        {
            app.UseRequestLocalization(options =>
            {
                options.AddSupportedCultures("en-US", "tr-TR")
                    .AddSupportedUICultures("en-US", "tr-TR")
                    .SetDefaultCulture("tr-TR");
            });
        }
    
    }
}
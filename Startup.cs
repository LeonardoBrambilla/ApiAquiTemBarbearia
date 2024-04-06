using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ApiAquiTemBarbearia.Data;

namespace ApiAquiTemBarbearia
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add logging services
            services.AddLogging(builder =>
            {
                builder.AddConsole(); // Add console logging
                // Other logging configurations, if needed
            });

            // Add DbContext
            services.AddDbContext<AppDbContext>();

            // Add other services as needed
            // Example: services.AddTransient<IMyService, MyService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            // Configure the app's request pipeline
            // Example: app.UseRouting();

            // Ensure any required middleware components are added here
            // Example: app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}

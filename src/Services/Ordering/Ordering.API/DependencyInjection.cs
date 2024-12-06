using BuildingBlocks.Exceptions.Handler;
using Carter;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Ordering.API;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddCarter();

        service.AddExceptionHandler<CustomExceptionHandler>();

        service.AddHealthChecks()
            .AddSqlServer(configuration.GetConnectionString("Database")!);
        
        return service;
    }

    public static WebApplication UseApiServices(this WebApplication app)
    {
        app.MapCarter();

        app.UseExceptionHandler(options => {});
        app.UseHealthChecks("/health",
            new HealthCheckOptions()
            {
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });
        
        return app;
    }
}
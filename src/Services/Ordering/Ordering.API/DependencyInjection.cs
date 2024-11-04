namespace Ordering.API;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(this IServiceCollection service)
    {
        return service;
    }

    public static WebApplication UseApiServices(this WebApplication app)
    {
        return app;
    }
}
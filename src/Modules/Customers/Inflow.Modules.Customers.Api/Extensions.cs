using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Inflow.Modules.Customers.CoreHandsOn;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("Inflow.Bootstrapper")]
namespace Inflow.Modules.Customers.ApiHandsOn;

internal static class Extensions
{
    public static IServiceCollection AddCustomersModule(this IServiceCollection services)
    {
        services.AddCore();
        return services;
    }

    public static IApplicationBuilder UseCustomersModule(this IApplicationBuilder app)
    {
        return app;
    }
}
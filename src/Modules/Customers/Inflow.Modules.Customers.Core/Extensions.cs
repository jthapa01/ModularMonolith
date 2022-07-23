using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("Inflow.Modules.Customers.Api")]
namespace Inflow.Modules.Customers.CoreHandsOn;
internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {

        return services;
    }
}
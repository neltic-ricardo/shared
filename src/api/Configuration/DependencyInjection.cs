using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Neltic.Shared.Api.Configuration;
public static class DependencyInjection
{
    public static IServiceCollection InstallServices(
        this IServiceCollection services,
        IConfiguration configuration,
        params Assembly[] assemblies)
    {
        var type = typeof(IServiceInstaller);

        var serviceInstallers = assemblies
            .SelectMany(a => a.ExportedTypes)
            .Where(a => IsAssignableToType<IServiceInstaller>(a))
            .Select(Activator.CreateInstance)
            .Cast<IServiceInstaller>();


        foreach (IServiceInstaller serviceInstaller in serviceInstallers)
            serviceInstaller.Install(services, configuration);


        return services;

        static bool IsAssignableToType<T>(Type type) =>
            typeof(T).IsAssignableFrom(type) &&
            !type.IsInterface &&
            !type.IsAbstract;
    }
}

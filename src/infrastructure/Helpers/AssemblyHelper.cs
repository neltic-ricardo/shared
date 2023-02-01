using System.Reflection;

namespace Neltic.Shared.Infrastructure.Helpers;
public static class AssemblyHelper
{
    public static IEnumerable<Assembly> LoadInfrastructureAndPersistence()
    {
        List<Assembly> assemblies = new();

        var assemblyNames = Directory
                .EnumerateFiles(AppContext.BaseDirectory, "*Neltic*")
                .Where(a => a.EndsWith("dll") && 
                           (a.Contains("Infrastructure") || a.Contains("Persistence")));

        foreach (var assemblyName in assemblyNames)
            assemblies.Add(Assembly.LoadFrom(assemblyName));

        return assemblies;
    }

    public static Assembly[] GetServicesInstallers()
    {
        List<Assembly> assemblies = new();

        var configurationAssemblyNames = Directory.EnumerateFiles(AppContext.BaseDirectory, "*Neltic*")
                                    .Where(a => a.EndsWith("dll") && a.Contains("Api"))
                                    .ToList();

        foreach (var assemblyName in configurationAssemblyNames)
            assemblies.Add(Assembly.LoadFrom(assemblyName));

        return assemblies.ToArray();
    }
}

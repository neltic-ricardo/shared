using System.Reflection;

namespace Neltic.Shared.Infrastructure.Helpers;
public static class ConfigurationAssamblyHelper
{
    public static Assembly[] GetConfigurations()
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

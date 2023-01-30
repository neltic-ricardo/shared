using MediatR;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace Neltic.Shared.Api.Configuration;
public class MediatRServiceInstaller : IServiceInstaller
{
    public void Install(
        IServiceCollection services, 
        IConfiguration configuration)
    {
        var assemblyName = Directory
                .EnumerateFiles(AppContext.BaseDirectory, "*Application*")
                .First(a => a.EndsWith("dll") && !a.Contains("Shared"));

        var assembly = Assembly.LoadFrom(assemblyName);

        services.AddMediatR(assembly);
    }
}

using System.Reflection;

using MediatR;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Neltic.Shared.Api.Configuration;
public class MediatRServiceInstaller : IServiceInstaller
{
    public void Install(
        IServiceCollection services, 
        IConfiguration configuration)
    {
        var assemblyName = Directory
                .EnumerateFiles(AppContext.BaseDirectory, "*Application*")
                .First(a => a.EndsWith("dll"));

        var assembly = Assembly.LoadFrom(assemblyName);

        services.AddMediatR(assembly);
    }
}

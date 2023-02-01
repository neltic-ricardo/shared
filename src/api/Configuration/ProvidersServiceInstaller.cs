using System.Reflection;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Neltic.Shared.Infrastructure.Helpers;

using Scrutor;

namespace Neltic.Shared.Api.Configuration;
public class ProvidersServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        List<Assembly> assemblies = new();

        assemblies.AddRange(AssemblyHelper.GetAssemblies("Infrastructure"));
        assemblies.AddRange(AssemblyHelper.GetAssemblies("Persistence"));

        services
        .Scan(selector => selector
                         .FromAssemblies(assemblies)
                         .AddClasses(false)
                         .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                         .AsMatchingInterface()
                         .WithScopedLifetime());
    }
}

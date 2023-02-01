using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Neltic.Shared.Infrastructure.Helpers;

using Scrutor;

namespace Neltic.Shared.Api.Configuration;
public class ProvidersServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        var assemblies = AssemblyHelper.LoadInfrastructureAndPersistence();

        services
        .Scan(selector => selector
                         .FromAssemblies(assemblies)
                         .AddClasses(false)
                         .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                         .AsMatchingInterface()
                         .WithScopedLifetime());
    }
}

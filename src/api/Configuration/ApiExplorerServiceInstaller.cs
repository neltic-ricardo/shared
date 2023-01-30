using System.Reflection;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Neltic.Shared.Api.Configuration;
public class ApiExplorerServiceInstaller : IServiceInstaller
{
    public void Install(
        IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddEndpointsApiExplorer();
    }
}

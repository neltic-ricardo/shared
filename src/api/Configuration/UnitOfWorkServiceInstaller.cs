using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Neltic.Shared.Domain;

namespace Neltic.Shared.Api.Configuration;
public class UnitOfWorkServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        //services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}

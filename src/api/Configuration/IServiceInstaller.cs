using System.Reflection;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Neltic.Shared.Api.Configuration;
public interface IServiceInstaller
{
    void Install(IServiceCollection services, IConfiguration configuration);
}

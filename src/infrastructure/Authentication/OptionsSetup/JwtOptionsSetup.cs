using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

using Neltic.Shared.Infrastructure.Authentication.OptionsSetup;

namespace Neltic.Shared.Api.OptionsSetup;


public class JwtOptionsSetup : IConfigureOptions<JwtOptions>
{
    private readonly IConfiguration _configuration;
    public JwtOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public void Configure(JwtOptions options)
    {
        _configuration.GetSection(JwtOptions.SectionName).Bind(options);
    }
}

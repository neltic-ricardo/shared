namespace Neltic.Shared.Infrastructure.Authentication.OptionsSetup;

public class JwtOptions
{
    public static string SectionName { get; } = "Jwt";
    public string SecretKey { get; set; } = string.Empty;
    public string Issuer { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
}

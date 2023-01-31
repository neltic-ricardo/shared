using System.Reflection;

namespace Neltic.Identity.Infrastructure;
public static class InfrastructureAssembly
{
    public static readonly Assembly Instance = typeof(InfrastructureAssembly).Assembly;
}

using System.Reflection;

namespace Neltic.Shared.Infrastructure;
public static class InfrastructureAssembly
{
    public static readonly Assembly Instance = typeof(InfrastructureAssembly).Assembly;
}

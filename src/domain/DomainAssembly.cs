using System.Reflection;

namespace Neltic.Shared.Domain;
public static class DomainAssembly
{
    public static readonly Assembly Instance = typeof(DomainAssembly).Assembly;
}

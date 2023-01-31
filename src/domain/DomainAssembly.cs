using System.Reflection;

namespace Neltic.Identity.Domain;
public static class DomainAssembly
{
    public static readonly Assembly Instance = typeof(DomainAssembly).Assembly;
}

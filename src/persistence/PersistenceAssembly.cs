using System.Reflection;

namespace Neltic.Shared.Persistence;

public static class PersistenceAssembly
{
    public static readonly Assembly Instance = typeof(PersistenceAssembly).Assembly;
}

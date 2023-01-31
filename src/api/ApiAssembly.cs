using System.Reflection;

namespace Neltic.Shared.Api;

public static class ApiAssembly
{
    public static readonly Assembly Instance = typeof(ApiAssembly).Assembly;
}
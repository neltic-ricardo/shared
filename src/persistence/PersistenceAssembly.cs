﻿using System.Reflection;

namespace Neltic.Identity.Persistence;

public static class PersistenceAssembly
{
    public static readonly Assembly Instance = typeof(PersistenceAssembly).Assembly;
}
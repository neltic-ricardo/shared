﻿using Microsoft.AspNetCore.Authorization;

namespace Neltic.Shared.Infrastructure.Authentication.Permissions;

public sealed class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(Permission permission)
        : base(policy: permission.ToString())
    {
    }
}

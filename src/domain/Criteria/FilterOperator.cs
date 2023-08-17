using System;

using Neltic.Shared.Domain;

namespace Neltic.Identity.Domain.Criteria;

public enum FilterOperator
{

    GreaterThan,
    GreaterThanOrEqual,
    LessThan,
    LessThanOrEqual,
    Equal,
    NotEqual,
    IsNull,
    IsNotNull,
    Contains,
    NotContains
}


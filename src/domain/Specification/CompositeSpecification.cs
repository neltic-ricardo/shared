﻿namespace Neltic.Shared.Domain.Specification;
/// <summary>
/// Base class for composite specifications
/// </summary>
/// <typeparam name="TEntity">Type of entity that check this specification</typeparam>
public abstract class CompositeSpecification<TEntity>
     : Specification<TEntity>
     where TEntity : class, new()
{
    #region Properties

    /// <summary>
    /// Left side specification for this composite element
    /// </summary>
    public abstract ISpecification<TEntity> LeftSideSpecification { get; }

    /// <summary>
    /// Right side specification for this composite element
    /// </summary>
    public abstract ISpecification<TEntity> RightSideSpecification { get; }

    #endregion
}

using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using Neltic.Shared.Domain;
using Neltic.Shared.Domain.Entities;
using Neltic.Shared.Domain.Specification;

namespace Neltic.Shared.Persistence;
/// <summary>
/// Repository base class
/// </summary>
/// <typeparam name="TEntity">The type of underlying entity in this repository</typeparam>
public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : Entity
{
    #region Members

    IQueryableUnitOfWork _unitOfWork;

    #endregion

    #region Constructor
    /// <summary>
    /// Create a new instance of repository
    /// </summary>
    /// <param name="unitOfWork">Associated Unit Of Work</param>
    public Repository(IQueryableUnitOfWork unitOfWork)
    {
        if (unitOfWork == null)
            throw new NullReferenceException("unitOfWork");

        _unitOfWork = unitOfWork;
    }
    #endregion

    public IUnitOfWork UnitOfWork => _unitOfWork;

    public virtual void Add(TEntity item)
    {
        GetSet().Add(item); // add new item in this set
    }

    public virtual IEnumerable<TEntity> AllMatching(ISpecification<TEntity> specification)
    {
        return GetSet().Where(specification.SatisfiedBy());
    }

    public TEntity Get(int id)
    {
        return GetSet().Find(id);
    }

    /// <summary>
    /// <see cref="IRepository{TValueObject}"/>
    /// </summary>
    /// <returns><see cref="IRepository{TValueObject}"/></returns>
    public virtual IEnumerable<TEntity> GetAll()
    {
        return GetSet();
    }

    /// <summary>
    /// <see cref="IRepository{TValueObject}"/>
    /// </summary>
    /// <param name="filter"><see cref="IRepository{TValueObject}"/></param>
    /// <returns><see cref="IRepository{TValueObject}"/></returns>
    public virtual IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter)
    {
        return GetSet().Where(filter);
    }

    /// <summary>
    /// <see cref="IRepository{TValueObject}"/>
    /// </summary>
    /// <typeparam name="S"><see cref="IRepository{TValueObject}"/></typeparam>
    /// <param name="pageIndex"><see cref="IRepository{TValueObject}"/></param>
    /// <param name="pageCount"><see cref="IRepository{TValueObject}"/></param>
    /// <param name="orderByExpression"><see cref="IRepository{TValueObject}"/></param>
    /// <param name="ascending"><see cref="IRepository{TValueObject}"/></param>
    /// <returns><see cref="IRepository{TValueObject}"/></returns>
    public virtual IEnumerable<TEntity> GetPaged<KProperty>(int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending)
    {
        var set = GetSet();

        if (ascending)
        {
            return set.OrderBy(orderByExpression)
                      .Skip(pageCount * pageIndex)
                      .Take(pageCount);
        }
        else
        {
            return set.OrderByDescending(orderByExpression)
                      .Skip(pageCount * pageIndex)
                      .Take(pageCount);
        }
    }

    // <summary>
    /// <see cref="IRepository{TValueObject}"/>
    /// </summary>
    /// <param name="persisted"><see cref="IRepository{TValueObject}"/></param>
    /// <param name="current"><see cref="IRepository{TValueObject}"/></param>    
    public virtual void Merge(TEntity persisted, TEntity current)
    {
        _unitOfWork.ApplyCurrentValues(persisted, current);
    }

    public virtual void Modify(TEntity item)
    {
        _unitOfWork.SetModified(item);
    }

    public virtual void Remove(TEntity item)
    {
        //attach item if not exist
        _unitOfWork.Attach(item);

        //set as "removed"
        GetSet().Remove(item);
    }

    public virtual void TrackItem(TEntity item)
    {
        _unitOfWork.Attach<TEntity>(item);
    }

    #region IDisposable Members
    /// <summary>
    /// <see cref="M:System.IDisposable.Dispose"/>
    /// </summary>
    public void Dispose()
    {
        if (_unitOfWork != null)
            _unitOfWork.Dispose();
    }
    #endregion

    #region Private Methods

    DbSet<TEntity> GetSet()
    {        
        return _unitOfWork.CreateSet<TEntity>();
    }
    #endregion
}

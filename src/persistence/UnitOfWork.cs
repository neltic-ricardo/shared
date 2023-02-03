using Neltic.Shared.Domain;

namespace Neltic.Shared.Persistence;
public class UnitOfWork : IUnitOfWork
{

    public Task CommitAndRefreshChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task CommitAsync(CancellationToken cancellationToken = default)
    {
        
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task RollbackChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

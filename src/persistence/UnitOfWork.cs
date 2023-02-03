using Neltic.Shared.Domain;

namespace Neltic.Shared.Persistence;
public class UnitOfWork : IUnitOfWork
{

    public Task CommitAndRefreshChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

<<<<<<< HEAD
    public async Task  CommitAsync(CancellationToken cancellationToken = default)
=======
    public async Task CommitAsync(CancellationToken cancellationToken = default)
>>>>>>> 177c8fbb2c4423e9235e8d533e158a1593432e79
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

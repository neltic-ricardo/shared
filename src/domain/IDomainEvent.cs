using MediatR;

namespace Neltic.Shared.Domain;

public interface IDomainEvent : INotification
{
    public Guid Id { get; init; }
}


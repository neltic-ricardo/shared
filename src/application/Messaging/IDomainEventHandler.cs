using MediatR;

using Neltic.Shared.Domain;

namespace Neltic.Shared.Application.Messaging;
public interface IDomainEventHandler<TEvent> : INotificationHandler<TEvent>
    where TEvent : IDomainEvent
{
}

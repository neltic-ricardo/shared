﻿using MediatR;

using Neltic.Shared.Domain;

namespace Neltic.Shared.Application.Abstractions.Messaging;
public interface IDomainEventHandler<TEvent> : INotificationHandler<TEvent>
    where TEvent : IDomainEvent
{
}

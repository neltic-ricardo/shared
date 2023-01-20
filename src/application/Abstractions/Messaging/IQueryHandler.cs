using MediatR;

using Neltic.Shared.Domain.Validator;

namespace Neltic.Shared.Application.Abstractions.Messaging;
public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}

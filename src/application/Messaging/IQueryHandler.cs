using MediatR;

using Neltic.Shared.Domain.Validator;

namespace Neltic.Shared.Application.Messaging;
public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}

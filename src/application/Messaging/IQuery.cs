using MediatR;

using Neltic.Shared.Domain.Validator;

namespace Neltic.Shared.Application.Messaging;
public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}

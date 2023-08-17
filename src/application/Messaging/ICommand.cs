using MediatR;

using Neltic.Shared.Domain.Validator;

namespace Neltic.Shared.Application.Messaging;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}


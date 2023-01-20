using Neltic.Shared.Domain.Errors;

namespace Neltic.Shared.Domain.Validator;
public interface IValidationResult
{
    public static readonly Error ValidationError = new(
        "ValidationError",
        "A validation problem occurred.");

    Error[] Errors { get; }
}

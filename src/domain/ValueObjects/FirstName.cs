using Neltic.Shared.Domain.Errors;
using Neltic.Shared.Domain.Validator;

namespace Neltic.Shared.Domain.ValueObjects;

public sealed class FirstName : ValueObject
{
    public const int MaxLength = 50;

    private FirstName(string value)
    {
        Value = value;
    }

    private FirstName()
    {
    }

    public string Value { get; private set; }

    public static Result<FirstName> Create(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            return Result.Failure<FirstName>(FirstNameErrors.Empty);
        }

        if (firstName.Length > MaxLength)
        {
            return Result.Failure<FirstName>(FirstNameErrors.TooLong);
        }

        return new FirstName(firstName);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}


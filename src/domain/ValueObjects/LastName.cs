using Neltic.Shared.Domain.Errors;
using Neltic.Shared.Domain.Validator;

namespace Neltic.Shared.Domain.ValueObjects;

public sealed class LastName : ValueObject
{
    public const int MaxLength = 50;

    private LastName(string value)
    {
        Value = value;
    }

    private LastName()
    {
    }

    public string Value { get; private set; }

    public static Result<LastName> Create(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName))
        {
            return Result.Failure<LastName>(LastNameErrors.Empty);
        }

        if (lastName.Length > MaxLength)
        {
            return Result.Failure<LastName>(LastNameErrors.TooLong);
        }

        return new LastName(lastName);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}


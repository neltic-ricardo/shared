using Neltic.Shared.Domain.Errors;
using Neltic.Shared.Domain.Validator;

namespace Neltic.Shared.Domain.ValueObjects;

public class StringValueObject : ValueObject
{
    public string Value { get; private set; } = string.Empty;

    private StringValueObject(string value)
        => Value = value;


    protected StringValueObject()
    {

    }

    public static Result<StringValueObject> Create(string value)
        => string.IsNullOrWhiteSpace(value)
            ? Result.Failure<StringValueObject>(StringErrors.Empty)
            : Result.Success<StringValueObject>(new(value));


    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}


namespace Neltic.Identity.Domain.Criteria;

public class Filter
{
    public FilterField Field { get; private set; }

    public FilterOperator Operator { get; private set; }

    public FilterValue Value { get; private set; }
    

    private Filter(FilterField field, FilterOperator @operator, FilterValue value)
        => (Field, Operator, Value) = (field, @operator, value);

    public Filter Create(FilterField field, FilterOperator @operator, FilterValue value)
        => new(field, @operator, value);

    public override string ToString()
        => $"{Field.Value} {Operator} {Value.Value}";
}


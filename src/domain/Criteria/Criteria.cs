using System;

namespace Neltic.Identity.Domain.Criteria;

public class Criteria
{
    public Filters Filters { get; private set; }

    public Order Order { get; private set; }

    public int? Offset { get; private set; }

    public int? Limit { get; private set; }

    public bool HasFilters { get => Filters.Count > 0; }

    public bool HasOrder { get => Order is not null; }    

    private Criteria(Filters filters, Order order, int? offset, int? limit)
        => (Filters, Order, Offset, Limit) = (filters, order, offset, limit);

    
    public Criteria Create(Filters filters, Order order, int? offset, int? limit)
        => new(filters, order, offset, limit);
    
}

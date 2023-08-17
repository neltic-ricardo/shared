namespace Neltic.Identity.Domain.Criteria;

public class Order
{
    public OrderBy OrderBy { get; private set; }

    public OrderType OrderType { get; private set; }

    private Order(OrderBy orderBy, OrderType orderType)
        => (OrderBy, OrderType) = (orderBy, orderType);

    public Order Create(OrderBy orderBy, OrderType orderType)
        => new(OrderBy, orderType);
}
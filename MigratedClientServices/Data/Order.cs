namespace MigratedClientServices.Data;

public class Order : ICloneable
{
    public required Guid ClientId { get; set; }
    public required OrderSide Side { get; set; }
    public required Stock Stock { get; set; }
    public OrderStatus Status { get; set; }
    public string ErrorMesssage  { get; set; } = "";
    public decimal SpreadPrice { get; set; }
    public bool HedgeOrder { get; set; }
    public object Clone()
    {
        return new Order
        {
            ClientId = ClientId,
            Side = Side,
            Stock = (Stock)Stock.Clone(),
            Status = Status,
            ErrorMesssage = ErrorMesssage,
            SpreadPrice = SpreadPrice,
            HedgeOrder = HedgeOrder
        };
    }
}
namespace MigratedClientServices.Data;

public class Stock : ICloneable
{
    public string InstrumentId { get; set; }
    public bool EnableLivePrices { get; set; }
    public decimal Price { get; set; }
    public int Size { get; set; } = 1;
    public object Clone()
    {
        return new Stock
        {
            InstrumentId = InstrumentId,
            EnableLivePrices = EnableLivePrices,
            Price = Price,
            Size = Size,
        };
    }
}
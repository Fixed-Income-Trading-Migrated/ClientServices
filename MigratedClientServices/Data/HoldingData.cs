namespace MigratedClientServices.Data;

public class HoldingData
{
    public Guid ClientId { get; set; }
    public string InstrumentId { get; set; }
    public int Size { get; set; }
    public DateTime DateMaturity { get; set; }
    public decimal BidPrice { get; set; }
    public int SellSize { get; set; }
}
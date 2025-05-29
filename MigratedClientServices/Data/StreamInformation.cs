namespace MigratedClientServices.Data;

public class StreamInformation
{
    // string clientId, string instrumentId, bool enableLivePrices
    public Guid ClientId { get; set; }
    public string InstrumentId { get; set; }
    public bool EnableLivePrices { get; set; }
}
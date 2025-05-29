namespace MigratedClientServices.Data;

public class TargetPosition
{
    public string InstrumentId { get; set; }
    public int Target { get; set; }
    public TargetType Type = TargetType.FOK;
}
namespace MigratedClientServices.Data;

public enum Tier
{
    External,  // Highest spread
    Internal,  // Lowest spread (internal use)
    Regular,   // Default spread for standard clients
    Premium,    // Special clients get the best rates
    ClientNotFound
}
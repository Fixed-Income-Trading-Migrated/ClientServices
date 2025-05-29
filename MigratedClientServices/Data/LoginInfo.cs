namespace MigratedClientServices.Data;

public class LoginInfo
{
    public Guid ClientId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public bool IsAuthenticated { get; set; }
}
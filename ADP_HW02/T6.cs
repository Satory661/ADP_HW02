namespace ADP_HM02;
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class UserRepository
{
    public void Save(User user)
    {
    }
}

public class EmailService
{
    public void SendEmail(User user, string message)
    {
    }
}

public class PrintService
{
    public void PrintAddressLabel(User user)
    {
    }
}
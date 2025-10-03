namespace ADP_HM02;

public class AppConfig
{
    public string Connection { get; } = "Server=myServer;Database=myDb;User Id=myUser;Password=myPass;";
}

public class DatabaseService
{
    private readonly string _connect;

    public DatabaseService(AppConfig config)
    {
        _connect = config.Connection;
    }

    public void Connect()
    {
        Console.WriteLine($"Connecting to db: {_connect}");
    }
}

public class LoggingService
{
    private readonly string _connect;

    public LoggingService(AppConfig config)
    {
        _connect = config.Connection;
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}
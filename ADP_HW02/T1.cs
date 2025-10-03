namespace ADP_HM02;

public enum LogLevel
{
    Error,
    Warning,
    Info
}

public class Logger
{
    public void Log(LogLevel level, string message)
    {
        Console.WriteLine($"{level.ToString().ToUpper()}: {message}");
    }
}
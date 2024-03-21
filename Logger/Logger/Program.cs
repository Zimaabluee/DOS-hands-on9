using System;

public enum LogLevel
{
    Comment,
    Warning,
    Error
}

public class ConsoleLoggerSingleton
{
    private static ConsoleLoggerSingleton instance;
    private static readonly object lockObject = new object();

    private ConsoleLoggerSingleton() { }

    public static ConsoleLoggerSingleton GetInstance()
    {
        lock (lockObject)
        {
            if (instance == null)
            {
                instance = new ConsoleLoggerSingleton();
            }
        }
        return instance;
    }

    public void Log(LogLevel level, string message)
    {
        switch (level)
        {
            case LogLevel.Comment:
                Console.WriteLine($"Comment: {message}");
                break;
            case LogLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Warning: {message}");
                Console.ResetColor();
                break;
            case LogLevel.Error:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {message}");
                Console.ResetColor();
                //Environment.Exit(1); // Stop the program for errors
                break;
            default:
                Console.WriteLine($"Unknown level: {level}");
                break;
        }
    }
}

public static class ConsoleLoggerStatic
{
    public static void Log(LogLevel level, string message)
    {
        switch (level)
        {
            case LogLevel.Comment:
                Console.WriteLine($"Comment: {message}");
                break;
            case LogLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Warning: {message}");
                Console.ResetColor();
                break;
            case LogLevel.Error:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {message}");
                Console.ResetColor();
                Environment.Exit(1); // Stop the program for errors
                break;
            default:
                Console.WriteLine($"Unknown level: {level}");
                break;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using singleton pattern for logging
        var loggerSingleton = ConsoleLoggerSingleton.GetInstance();
        loggerSingleton.Log(LogLevel.Comment, "It is just a comment.");
        loggerSingleton.Log(LogLevel.Warning, "plz warning.");
        loggerSingleton.Log(LogLevel.Error, "ERROR!");

        // Using static method for logging
        ConsoleLoggerStatic.Log(LogLevel.Comment, "It is just a comment.");
        ConsoleLoggerStatic.Log(LogLevel.Warning, "plz warning.");
        ConsoleLoggerStatic.Log(LogLevel.Error, " ERROR!");
    }
}

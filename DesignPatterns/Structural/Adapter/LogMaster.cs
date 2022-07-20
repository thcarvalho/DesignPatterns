namespace DesignPatterns.Structural.Adapter;

public class LogMaster : ILogMaster
{
  public void LogInfo(string message)
  {
    Console.WriteLine($"Log Master {message}");
  }

  public void LogWarning(Exception exception)
  {
    Console.WriteLine($"Log Master {exception.Message}");
  }
}
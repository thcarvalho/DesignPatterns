namespace DesignPatterns.Structural.Adapter;

public class LoggerAdapter : ILogger
{
  private readonly ILogMaster _logMaster;

  public LoggerAdapter(ILogMaster logMaster)
  {
    _logMaster = logMaster;
  }

  public void Log(string message)
  {
    _logMaster.LogInfo(message);
  }

  public void LogError(Exception exception)
  {
    _logMaster.LogWarning(exception);
  }
}
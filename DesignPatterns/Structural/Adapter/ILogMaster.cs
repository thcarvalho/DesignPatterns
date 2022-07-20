namespace DesignPatterns.Structural.Adapter;

public interface ILogMaster
{
  void LogInfo(string message);
  void LogWarning(Exception exception);
}
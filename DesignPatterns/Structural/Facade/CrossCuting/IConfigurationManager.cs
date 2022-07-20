namespace DesignPatterns.Structural.Facade.CrossCuting;

public interface IConfigurationManager
{
  string GetValue(string node);
}
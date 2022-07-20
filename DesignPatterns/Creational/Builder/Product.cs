namespace DesignPatterns.Creational.Builder;

public class Product
{
  private readonly List<string> _parts = new List<string>();
  public void Add(string part)
  {
    _parts.Add(part);
  }

  public void ShowResult()
  {
    Console.WriteLine("Product parts:");
    foreach (var part in _parts)
    {
      Console.WriteLine(part);
    }
  }
}
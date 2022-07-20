namespace DesignPatterns.Behavior.Observer;

public class Observer : IObserver
{
  public string Name { get; }

  public Observer(string name)
  {
    Name = name;
  }

  public void Notify(Investment investment)
  {
    Console.WriteLine("Notificando {0} que {1} " +
                      "teve preço alterado para {2:C}", Name, investment.Symbol, investment.Value);
  }
}
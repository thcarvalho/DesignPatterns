namespace DesignPatterns.Behavior.Observer;

public abstract class Investment
{
  private decimal _value;
  private readonly List<IObserver> _observers = new List<IObserver>();
  public string Symbol { get; }

  public decimal Value
  {
    get => _value;
    set
    {
      if (_value == value) return;
      _value = value;
      Notify();
    }
  }

  protected Investment(string symbol, decimal value)
  {
    Symbol = symbol;
    _value = value;
  }

  public void Subscribe(IObserver observer)
  {
    _observers.Add(observer);
    Console.WriteLine($"Notificando que {observer.Name} está recebendo atualizações de {Symbol}");
  }
  public void Unsubscribe(IObserver observer)
  {
    _observers.Remove(observer);
    Console.WriteLine($"Notificando que {observer.Name} NÃO está recebendo atualizações de {Symbol}");
  }

  private void Notify()
  {
    foreach (var item in _observers)
    {
      item.Notify(this);
    }
  }

}
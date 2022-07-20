namespace DesignPatterns.Behavior.Observer;

public class Main
{
  public static void Execute()
  {
    var joao = new Observer("João");
    var eduardo = new Observer("Eduardo");
    var bill = new Observer("Bill");

    var amazon = new Paper("Amazon", NextDecimal());
    var microsoft = new Paper("Microsoft", NextDecimal());

    amazon.Subscribe(joao);
    amazon.Subscribe(eduardo);

    microsoft.Subscribe(eduardo);
    microsoft.Subscribe(bill);

    Console.WriteLine("");
    Console.WriteLine("------------------");
    Console.WriteLine("");

    for (int i = 0; i < 5; i++)
    {
      amazon.Value = NextDecimal();
      microsoft.Value = NextDecimal();

      if (i == 1)
      {
        amazon.Unsubscribe(eduardo);
      }
    }
  }

  public static decimal NextDecimal()
  {
    var random = new Random();
    var r = random.Next(141421, 314160);
    return r / (decimal)100000.00;
  }
}
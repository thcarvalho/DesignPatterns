namespace DesignPatterns.Creational.Builder;

public class Main
{
  public static void Execute()
  {
    var director = new Director();

    var b1 = new Builder1();
    var b2 = new Builder2();

    director.Construct(b1);
    var p1 = b1.GetResult();
    p1.ShowResult();

    director.Construct(b2);
    var p2 = b2.GetResult();
    p2.ShowResult();
  }
}
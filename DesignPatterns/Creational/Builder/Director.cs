namespace DesignPatterns.Creational.Builder;

public class Director
{
  public void Construct(IBuilder builder)
  {
    builder.BuildPartA();
    builder.BuildPartB();
  }
}
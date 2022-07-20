namespace DesignPatterns.Creational.Builder;

public interface IBuilder
{
  void BuildPartA();
  void BuildPartB();
  void Reset();
  Product GetResult();
}
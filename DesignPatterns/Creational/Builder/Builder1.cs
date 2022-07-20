namespace DesignPatterns.Creational.Builder;

public class Builder1 : IBuilder
{
  private Product _product = new Product();

  public void BuildPartA()
  {
    _product.Add("Part A");
  }

  public void BuildPartB()
  {
    _product.Add("Part B");
  }

  public void Reset()
  {
    _product = new Product();
  }

  public Product GetResult()
  {
    var product = _product;
    Reset();
    return product;
  }
}
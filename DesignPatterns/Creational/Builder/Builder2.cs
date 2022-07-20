namespace DesignPatterns.Creational.Builder;

public class Builder2 : IBuilder
{
  private Product _product = new Product();

  public void BuildPartA()
  {
    _product.Add("Part X");
  }

  public void BuildPartB()
  {
    _product.Add("Part Y");
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
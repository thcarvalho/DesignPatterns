namespace DesignPatterns.Structural.Facade.Domain;

public class Payment
{
  public string Status { get; set; }
  public decimal Value { get; set; }
  public string CreditCard { get; set; }
}
namespace DesignPatterns.Behavior.Strategy;

public class Payment
{
  public string Status { get; set; }
  public decimal Value { get; set; }

  public string CreditCard { get; set; }
  public string TicketCode { get; set; }
  public string PixConfirmation { get; set; }
}
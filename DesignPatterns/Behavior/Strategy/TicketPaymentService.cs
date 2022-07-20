namespace DesignPatterns.Behavior.Strategy;

public class TicketPaymentService : IPaymentService
{
  public Payment Pay(Payment payment, Order order)
  {
    Console.WriteLine("Pagamento por boleto");
    return new Payment();
  }
}
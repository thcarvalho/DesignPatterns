namespace DesignPatterns.Behavior.Strategy;

public class PixPaymentService : IPaymentService
{
  public Payment Pay(Payment payment, Order order)
  {
    Console.WriteLine("Pagamento por pix");
    return new Payment();
  }
}
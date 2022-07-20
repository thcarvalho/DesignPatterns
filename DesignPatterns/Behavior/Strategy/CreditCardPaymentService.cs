namespace DesignPatterns.Behavior.Strategy;

public class CreditCardPaymentService : IPaymentService
{
  public Payment Pay(Payment payment, Order order)
  {
    Console.WriteLine("Pagamento por cartão de crédito");
    return new Payment();
  }
}
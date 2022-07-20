namespace DesignPatterns.Behavior.Strategy;

public interface IPaymentService
{
  Payment Pay(Payment payment, Order order);
}
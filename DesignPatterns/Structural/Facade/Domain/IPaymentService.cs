namespace DesignPatterns.Structural.Facade.Domain;

public interface IPaymentService
{
  Payment Pay(Order order, Payment payment);
}
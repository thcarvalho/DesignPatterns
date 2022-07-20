namespace DesignPatterns.Structural.Facade.Domain;

public interface IPaymentFacade
{
  bool Pay(Order order, Payment payment);
}
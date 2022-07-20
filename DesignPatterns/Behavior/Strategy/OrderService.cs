namespace DesignPatterns.Behavior.Strategy;

public class OrderService
{
  private readonly IPaymentService _paymentService;

  public OrderService(IPaymentService paymentService)
  {
    _paymentService = paymentService;
  }

  public Payment MakePayment(Order order, Payment payment)
  {
    return _paymentService.Pay(payment, order);
  }
}
namespace DesignPatterns.Structural.Facade.Domain;

public class PaymentService : IPaymentService
{
  private readonly IPaymentFacade _paymentFacade;

  public PaymentService(IPaymentFacade paymentFacade)
  {
    _paymentFacade = paymentFacade;
  }

  public Payment Pay(Order order, Payment payment)
  {
    payment.Value = order.Products.Sum(p => p.Value);
    Console.WriteLine("Iniciando Pagamento via Cartão de Crédito - Valor R$ " + payment.Value);

    if (_paymentFacade.Pay(order, payment))
    {
      payment.Status = "Pago";
      return payment;
    }

    payment.Status = "Recusado";
    return payment;
  }
}
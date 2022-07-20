using DesignPatterns.Structural.Facade.CrossCuting;

namespace DesignPatterns.Structural.Facade.Domain;

public class PaymentFacade : IPaymentFacade
{

  private readonly IPayPalGateway _payPalGateway;
  private readonly IConfigurationManager _configManager;

  public PaymentFacade(IPayPalGateway payPalGateway, IConfigurationManager configManager)
  {
    _payPalGateway = payPalGateway;
    _configManager = configManager;
  }

  public bool Pay(Order order, Payment payment)
  {
    var apiKey = _configManager.GetValue("apiKey");
    var encriptionKey = _configManager.GetValue("encriptionKey");

    var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
    var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, payment.CreditCard);

    var paymentResult = _payPalGateway.CommitTransaction(cardHashKey, order.Id.ToString(), payment.Value);

    return paymentResult;
  }
}
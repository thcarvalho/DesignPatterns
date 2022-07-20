using DesignPatterns.Structural.Facade.CrossCuting;
using DesignPatterns.Structural.Facade.Domain;

namespace DesignPatterns.Structural.Facade;

public class Main
{
  public static void Executar()
  {
    var produtos = new List<Product>
    {
      new Product{Name = "Tenis Adidas", Value = new Random().Next(500)},
      new Product{Name = "Camisa Boliche", Value = new Random().Next(500)},
      new Product{Name = "Raquete Tenis", Value = new Random().Next(500)}
    };

    var pedido = new Order
    {
      Id = Guid.NewGuid(),
      Products = produtos
    };

    var pagamento = new Payment
    {
      CreditCard = "5555 2222 5555 9999"
    };

    // Resolva com DI
    var pagamentoService = new PaymentService(new PaymentFacade(new PayPalGateway(), new ConfigurationManager()));

    var pagamentoResult = pagamentoService.Pay(pedido, pagamento);

    Console.WriteLine(pagamentoResult.Status);
  }

}
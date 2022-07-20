namespace DesignPatterns.Behavior.Strategy;

public class Main
{
  public static void Execute()
  {
    var products = new List<Product>
    {
      new Product { Name = "Tenis Adidas", Value = new Random().Next(500) }
    };

    var order = new Order
    {
      Id = Guid.Empty,
      Products = products
    };

    var orderServiceCreditCard = new OrderService(new CreditCardPaymentService());
    orderServiceCreditCard.MakePayment(order, new Payment());

    var orderServicePix = new OrderService(new PixPaymentService());
    orderServicePix.MakePayment(order, new Payment());

    var orderServiceTicket = new OrderService(new TicketPaymentService());
    orderServiceTicket.MakePayment(order, new Payment());
  }
}
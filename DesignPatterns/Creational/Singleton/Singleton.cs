namespace DesignPatterns.Creational.Singleton;

public class Singleton
{
  public static void Executar()
  {
    var b1 = LoadBalancer.GetBalancer();
    var b2 = LoadBalancer.GetBalancer();
    var b3 = LoadBalancer.GetBalancer();
    var b4 = LoadBalancer.GetBalancer();

    var balancer = LoadBalancer.GetBalancer();
    for (int i = 0; i < 15; i++)
    {
      Console.WriteLine(balancer.NexServer.Name, balancer.NexServer.Id);
    }
  }
}
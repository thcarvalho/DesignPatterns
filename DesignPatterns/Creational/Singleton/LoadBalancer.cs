namespace DesignPatterns.Creational.Singleton;

public class LoadBalancer
{
  private static readonly LoadBalancer Instance = new LoadBalancer();
  private readonly List<Server> _servers;

  public LoadBalancer()
  {
    _servers = new List<Server>
    {
      new Server { Id = Guid.NewGuid(), Name = "S1", IP = "192.168.0.1" },
      new Server { Id = Guid.NewGuid(), Name = "S2", IP = "192.168.0.2" },
      new Server { Id = Guid.NewGuid(), Name = "S3", IP = "192.168.0.3" },
      new Server { Id = Guid.NewGuid(), Name = "S4", IP = "192.168.0.4" },
      new Server { Id = Guid.NewGuid(), Name = "S5", IP = "192.168.0.5" },
      new Server { Id = Guid.NewGuid(), Name = "S6", IP = "192.168.0.6" },
      new Server { Id = Guid.NewGuid(), Name = "S7", IP = "192.168.0.7" },
    }
  }

  public static LoadBalancer GetBalancer()
  {
    return Instance;
  }

  public Server NexServer
  {
    get
    {
      var i = new Random().Next(_servers.Count);
      return _servers[i];
    }
  }
}
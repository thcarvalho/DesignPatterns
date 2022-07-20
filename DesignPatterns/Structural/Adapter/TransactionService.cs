namespace DesignPatterns.Structural.Adapter;

public class TransactionService
{
  private readonly ILogger _logger;

  public TransactionService(ILogger logger)
  {
    _logger = logger;
  }

  public void Transact()
  {
    _logger.Log("Transação realizada");
  }
}
namespace DesignPatterns.Structural.Adapter;

public class Main
{
  public static void Execute()
  {
    var logDefault = new TransactionService(new Logger());
    logDefault.Transact();

    var logCustom = new TransactionService(new LoggerAdapter(new LogMaster()));
    logCustom.Transact();
  }
}
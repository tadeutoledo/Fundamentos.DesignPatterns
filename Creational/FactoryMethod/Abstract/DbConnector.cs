namespace Fundamentos.DesignPatterns.Creational.FactoryMethod.Abstract
{
  public abstract class DbConnector
  {
    private readonly string _stringConnection;
    public DbConnector(string stringConnection)
    {
      _stringConnection = stringConnection;
    }
    public bool Connected { get; set; }
    public abstract bool Connect();
  }
}
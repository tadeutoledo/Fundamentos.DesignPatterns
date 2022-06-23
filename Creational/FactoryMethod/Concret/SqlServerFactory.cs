using Fundamentos.DesignPatterns.Creational.FactoryMethod.Abstract;

namespace Fundamentos.DesignPatterns.Creational.FactoryMethod.Concret
{
  public class SqlServerFactory : DbFactory
  {
    public override DbConnector CreateConnector(string stringConnection)
    {
      return new SqlServerConnector(stringConnection);
    }
  }
}
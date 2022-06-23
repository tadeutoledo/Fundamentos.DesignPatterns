using Fundamentos.DesignPatterns.Creational.FactoryMethod.Abstract;

namespace Fundamentos.DesignPatterns.Creational.FactoryMethod
{
  public class ExecutarFactoryMethod
  {
    public static void Executar()
    {
      var dbSqlServer = DbFactory
      .Database(DataBase.Oracle)
      .CreateConnector("stringConnection=***")
      .Connect();
    }
  }
}
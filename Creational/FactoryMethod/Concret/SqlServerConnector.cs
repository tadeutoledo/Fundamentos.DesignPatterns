using Fundamentos.DesignPatterns.Creational.FactoryMethod.Abstract;

namespace Fundamentos.DesignPatterns.Creational.FactoryMethod.Concret
{
  public class SqlServerConnector : DbConnector
  {
    public SqlServerConnector(string stringConnection) : base(stringConnection)
    {
    }

    public override bool Connect()
    {
      if (Connected)
      {
        Console.WriteLine("Intancia 'SQL Server' já conectada.");
      }
      else
      {
        // Preparar comandos interno SQL
        Connected = true;
        Console.WriteLine("Carregando intancia 'SQL Server'");
        Console.WriteLine("Nova intancia 'SQL Server' conectada.");
      }

      return true;
    }
  }
}
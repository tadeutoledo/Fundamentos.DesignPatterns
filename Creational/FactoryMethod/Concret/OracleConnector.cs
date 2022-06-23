using Fundamentos.DesignPatterns.Creational.FactoryMethod.Abstract;

namespace Fundamentos.DesignPatterns.Creational.FactoryMethod.Concret
{
  public class OracleConnector : DbConnector
  {
    public OracleConnector(string stringConnection) : base(stringConnection)
    {
    }

    public override bool Connect()
    {
      if (Connected)
      {
        Console.WriteLine("Intancia 'Oracle' já conectada.");
      }
      else
      {
        // Preparar comandos interno Oracle
        Connected = true;
        Console.WriteLine("Carregando intancia 'Oracle'");
        Console.WriteLine("Nova intancia 'Oracle' conectada.");
      }

      return true;
    }
  }
}
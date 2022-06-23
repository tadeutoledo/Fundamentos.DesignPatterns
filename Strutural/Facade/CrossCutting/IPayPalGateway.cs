using Fundamentos.DesignPatterns.Strutural.Facade.Domain;

namespace Fundamentos.DesignPatterns.Strutural.Facade.CrossCutting
{
  public interface IPayPalGateway
  {
    public bool CommitTransaction(string cardNumber, decimal amount);
  }
}
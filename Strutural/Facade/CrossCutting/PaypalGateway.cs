using Fundamentos.DesignPatterns.Strutural.Facade.Domain;

namespace Fundamentos.DesignPatterns.Strutural.Facade.CrossCutting
{
  public class PaypalGateway : IPayPalGateway
  {
    public bool CommitTransaction(string cardNumber, decimal amount)
    {
      //Lógica gateway de pagamento
      return true;
    }
  }
}
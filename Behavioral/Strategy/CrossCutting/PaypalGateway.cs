namespace Fundamentos.DesignPatterns.Behavioral.Strategy.CrossCutting
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
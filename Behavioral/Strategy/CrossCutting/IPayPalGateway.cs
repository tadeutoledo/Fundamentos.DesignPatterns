namespace Fundamentos.DesignPatterns.Behavioral.Strategy.CrossCutting
{
  public interface IPayPalGateway
  {
    public bool CommitTransaction(string cardNumber, decimal amount);
  }

}
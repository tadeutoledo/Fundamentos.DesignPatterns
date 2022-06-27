namespace Fundamentos.DesignPatterns.Behavioral.Strategy.Domain
{
  public class Pedido
  {
    public Guid Id { get; private set; }

    public decimal Valor { get; set; }

    public StatusAutorizacao StatusAutorizacao { get; set; }

    public Pedido()
    {
      Id = Guid.NewGuid();
      StatusAutorizacao = StatusAutorizacao.EmProcessamento;
    }
  }
}
using Fundamentos.DesignPatterns.Behavioral.Strategy.Domain;

public interface IPagamento
{
  public Pedido AutorizarPagamento(Pedido pedido, InstrumentoPagamento instrumentoPagamento);
}
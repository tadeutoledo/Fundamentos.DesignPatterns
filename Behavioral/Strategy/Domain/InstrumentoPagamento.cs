namespace Fundamentos.DesignPatterns.Behavioral.Strategy.Domain
{
  public abstract class InstrumentoPagamento
  {
    public Guid Id { get; private set; }

    public InstrumentoPagamento()
    {
      Id = Guid.NewGuid();
    }

    public abstract bool Validar();
  }
}
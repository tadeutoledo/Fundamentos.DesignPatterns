namespace Fundamentos.DesignPatterns.Behavioral.Strategy.Domain
{
  public class Boleto : InstrumentoPagamento
  {
    public string? LinhaDigitavel { get; set; }

    public DateTime? Vencimento { get; set; }

    public Boleto(
      string linhaDigitavel,
      DateTime vencimento)
    {
      LinhaDigitavel = linhaDigitavel;
      Vencimento = vencimento;
    }

    public override bool Validar()
    {
      // Validar linha
      return true;
    }
  }
}
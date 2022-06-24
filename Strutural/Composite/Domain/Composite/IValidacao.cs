namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite
{
  public interface IValidacao
  {
    public string NomeClasse { get; set; }
    public string NomeMetodo { get; set; }
    public string Mensagem { get; set; }
    public bool Valido { get; set; }
  }
}
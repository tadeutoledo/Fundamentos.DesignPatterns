namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite
{
  public interface IValidation
  {
    public string NomeClasse { get; set; }
    public string NomeMetodo { get; set; }
    public string Mensagem { get; set; }
    public bool Valido { get; set; }

    public void ExibirMensagens(int sub);
  }
}
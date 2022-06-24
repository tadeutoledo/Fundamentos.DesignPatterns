namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite
{
  public class SubValidacao : IValidacao
  {
    public string NomeClasse { get; set; }
    public string NomeMetodo { get; set; }
    public string Mensagem { get; set; }
    public bool Valido { get; set; }

    public SubValidacao()
    {

    }
    public SubValidacao(
      string nomeClasse,
      string nomeMetodo,
      string mensagem,
      bool valido)
    {
      NomeClasse = nomeClasse;
      NomeMetodo = nomeMetodo;
      Mensagem = mensagem;
      Valido = valido;
    }
  }
}
using System.Collections;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite
{
  public class Validacao : IValidacao
  {
    public IList<IValidacao> Validacoes;
    public string NomeClasse { get; set; }
    public string NomeMetodo { get; set; }
    public string Mensagem { get; set; }
    public bool Valido { get; set; }

    public Validacao()
    {
      Validacoes = new List<IValidacao>();
    }

    public Validacao(
      string nomeClasse,
      string nomeMetodo,
      string mensagem,
      bool valido)
    {
      Validacoes = new List<IValidacao>();
      NomeClasse = nomeClasse;
      NomeMetodo = nomeMetodo;
      Mensagem = mensagem;
      Valido = valido;
    }

    public void Add(IValidacao validacao)
    {
      Validacoes.Add(validacao);
    }

    public void Remove(IValidacao validacao)
    {
      Validacoes.Remove(validacao);
    }
  }
}
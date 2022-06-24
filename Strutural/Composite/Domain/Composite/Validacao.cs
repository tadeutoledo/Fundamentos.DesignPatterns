using System.Collections;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite
{
  public class Validacao : IValidacao
  {
    private readonly IList<IValidacao> _listaValidacoes;
    public string NomeClasse { get; set; }
    public string NomeMetodo { get; set; }
    public string Mensagem { get; set; }
    public bool Valido { get; set; }

    public Validacao()
    {
      _listaValidacoes = new List<IValidacao>();
    }

    public Validacao(
      string nomeClasse,
      string nomeMetodo,
      string mensagem,
      bool valido)
    {
      _listaValidacoes = new List<IValidacao>();
      NomeClasse = nomeClasse;
      NomeMetodo = nomeMetodo;
      Mensagem = mensagem;
      Valido = valido;
    }

    public void Add(IValidacao validacao)
    {
      _listaValidacoes.Add(validacao);
    }

    public void Remove(IValidacao validacao)
    {
      _listaValidacoes.Remove(validacao);
    }

    public void ExibirMensagens(int sub)
    {
      Console.WriteLine($"{new string('-', sub)} - {NomeClasse} - {Mensagem}");

      foreach (var mensagem in _listaValidacoes)
      {
        mensagem.ExibirMensagens(sub + 2);
      }
    }
  }
}
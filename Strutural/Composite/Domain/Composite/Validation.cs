using System.Collections;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite
{
  public class Validation : IValidation
  {
    private readonly IList<IValidation> _listaValidacoes;
    public string NomeClasse { get; set; }
    public string NomeMetodo { get; set; }
    public string Mensagem { get; set; }
    public bool Valido { get; set; }

    public Validation()
    {
      _listaValidacoes = new List<IValidation>();
    }

    public Validation(
      string nomeClasse,
      string nomeMetodo,
      string mensagem,
      bool valido)
    {
      _listaValidacoes = new List<IValidation>();
      NomeClasse = nomeClasse;
      NomeMetodo = nomeMetodo;
      Mensagem = mensagem;
      Valido = valido;
    }

    public void Add(IValidation validacao)
    {
      _listaValidacoes.Add(validacao);
    }

    public IValidation? GetByNomeClasse(string nomeClasse)
    {
      return _listaValidacoes.LastOrDefault(x => x.NomeClasse == nomeClasse);
    }

    public void ExibirMensagens(int sub)
    {
      if (!string.IsNullOrEmpty(NomeClasse))
      {
        Console.WriteLine($"{new string('-', sub)}{NomeClasse} - {Mensagem}");
      }

      foreach (var mensagem in _listaValidacoes)
      {
        mensagem.ExibirMensagens(sub + 2);
      }
    }
  }
}
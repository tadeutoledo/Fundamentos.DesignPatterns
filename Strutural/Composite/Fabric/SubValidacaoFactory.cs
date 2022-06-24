using Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Fabric
{
  public class SubValidacaoFactory : ValidacaoFactory
  {
    public override SubValidacao CreateValidacao(string nomeClasse, string nomeMetodo, string mensagem, bool valido)
    {
      return new SubValidacao(nomeClasse, nomeMetodo, mensagem, valido);
    }
  }
}
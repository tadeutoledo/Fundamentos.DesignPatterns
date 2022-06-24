using Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Fabric
{
  public abstract class ValidacaoFactory
  {
    public abstract IValidacao CreateValidacao(string nomeClasse, string nomeMetodo, string mensagem, bool valido);
  }
}
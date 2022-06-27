using Fundamentos.DesignPatterns.Behavioral.Strategy.Domain;

namespace Fundamentos.DesignPatterns.Behavioral.Strategy.CrossCutting
{
  public interface ISerasaIntegration
  {
    public NivelScore ConsultarScore(CartaoCredito cartao);
  }
}
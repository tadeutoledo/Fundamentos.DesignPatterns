using Fundamentos.DesignPatterns.Strutural.Facade.Domain;

namespace Fundamentos.DesignPatterns.Strutural.Facade.CrossCutting
{
  public interface ISerasaIntegration
  {
    public NivelScore ConsultarScore(CartaoCredito cartao);
  }
}
using Fundamentos.DesignPatterns.Behavioral.Strategy.Domain;

namespace Fundamentos.DesignPatterns.Behavioral.Strategy.CrossCutting
{
  public class SerasaIntegration : ISerasaIntegration
  {
    public NivelScore ConsultarScore(CartaoCredito cartao)
    {
      // Realizar consulta externa
      return (NivelScore)new Random().Next(Enum.GetNames(typeof(NivelScore)).Count());
    }
  }
}
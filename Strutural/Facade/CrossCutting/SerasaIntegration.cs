using Fundamentos.DesignPatterns.Strutural.Facade.Domain;

namespace Fundamentos.DesignPatterns.Strutural.Facade.CrossCutting
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
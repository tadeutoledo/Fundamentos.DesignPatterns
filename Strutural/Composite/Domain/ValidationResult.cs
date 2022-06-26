using Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain
{
  public class ValidationResult
  {
    private readonly IValidation _validacao;

    public ValidationResult(IValidation validacao)
    {
      _validacao = validacao;
    }

    public void ExibirMensagens()
    {
      _validacao.ExibirMensagens(2);
    }
  }
}
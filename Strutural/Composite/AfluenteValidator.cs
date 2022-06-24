using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Fundamentos.DesignPatterns.Strutural.Composite.Domain;
using Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite;

namespace Fundamentos.DesignPatterns.Strutural.Composite
{
  public class AfluenteValidator
  {
    public IValidacao Validate(Entity entity)
    {
      Validacao validacao = new Validacao();

      foreach (var property in TypeDescriptor.GetProperties(typeof(Entity)).Cast<PropertyDescriptor>())
      {
        if (property.GetType() == typeof(RequiredAttribute))
        {
          IValidacao validacaoProperty = new Validacao(entity.GetType().Name, property.DisplayName, "", true);

          var typeCodeProperty = Type.GetTypeCode(property.GetValue(property)?.GetType());
          var valueProperty = property.GetValue(property);

          switch (typeCodeProperty)
          {
            case TypeCode.String:
              var value = valueProperty as string;

              if (string.IsNullOrEmpty(value))
              {
                validacaoProperty.Valido = false;
                validacaoProperty.Mensagem = $"O campo {property.DisplayName} está inválido.";
              }
              break;

            case TypeCode.Object:

              break;
          }
        }

      }

      return validacao;
    }
  }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Fundamentos.DesignPatterns.Strutural.Composite.Domain;
using Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite;
using Fundamentos.DesignPatterns.Strutural.Composite.Fabric;

namespace Fundamentos.DesignPatterns.Strutural.Composite
{
  public class AfluenteValidator
  {
    private readonly ValidacaoFactory _subValidacaofactory;
    private readonly Validacao _validator;

    public AfluenteValidator(
      SubValidacaoFactory subValidacaoFactory,
      Validacao validator)
    {
      _subValidacaofactory = subValidacaoFactory;
      _validator = validator;
    }

    public IValidacao Validate<T>(T entity) where T : Entity
    {
      foreach (var property in TypeDescriptor.GetProperties(typeof(T)).Cast<PropertyDescriptor>())
      {
        if (property.Attributes.Cast<Attribute>().Any(a => a.GetType() == typeof(RequiredAttribute)))
        {
          ValidatePropertyRequired(entity, property);
        }
      }

      return _validator;
    }

    private void ValidatePropertyRequired<T>(T entity, PropertyDescriptor property)
    {
      var typeProperty = Type.GetTypeCode(property.PropertyType);
      var valueProperty = property.GetValue(entity);

      switch (typeProperty)
      {
        case TypeCode.String:
          string value = valueProperty?.ToString() ?? "";

          if (string.IsNullOrEmpty(value))
          {
            _validator.Add(_subValidacaofactory.CreateValidacao(
              entity.GetType().Name,
              property.DisplayName,
              $"O campo {property.DisplayName} está inválido.",
              true));
          }
          break;

        case TypeCode.Decimal:
          Decimal valueDecimal = 0;

          if (!decimal.TryParse(valueProperty?.ToString(), out valueDecimal))
          {
            _validator.Add(_subValidacaofactory.CreateValidacao(
              entity.GetType().Name,
              property.DisplayName,
              $"O campo {property.DisplayName} está inválido.",
              true));
          }

          break;

        case TypeCode.Int16:
        case TypeCode.Int32:
        case TypeCode.Int64:
          Int64 valueInt = 0;

          if (!Int64.TryParse(valueProperty?.ToString(), out valueInt))
          {
            _validator.Add(_subValidacaofactory.CreateValidacao(
              entity.GetType().Name,
              property.DisplayName,
              $"O campo {property.DisplayName} está inválido.",
              true));
          }

          break;

        case TypeCode.Object:

          if (valueProperty is Entity)
          {
            if (valueProperty is Cliente)
            {
              ValidateObject(valueProperty as Cliente);
            }

            if (valueProperty is Pedido)
            {
              ValidateObject(valueProperty as Pedido);
            }

            if (valueProperty is Endereco)
            {
              ValidateObject(valueProperty as Endereco);
            }

            if (valueProperty is CartaoCredito)
            {
              ValidateObject(valueProperty as CartaoCredito);
            }
          }

          break;
      }
    }

    private void ValidateObject<T>(T obj) where T : Entity
    {
      Validate(obj);
    }
  }
}
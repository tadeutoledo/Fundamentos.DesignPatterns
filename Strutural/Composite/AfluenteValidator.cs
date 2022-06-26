using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Fundamentos.DesignPatterns.Strutural.Composite.Domain;
using Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite;

namespace Fundamentos.DesignPatterns.Strutural.Composite
{
  public class AfluenteValidator<E> where E : Entity
  {
    private Validation? _mainValidator, _propertyValidator;

    public Domain.ValidationResult Validate<T>(T entity) where T : Entity
    {
      foreach (var property in GetPrimitiveTypes(entity))
      {
        AddValidation(entity, new SubValidation(
          entity.GetType().Name,
          property.DisplayName,
          $"O campo {property.DisplayName} está inválido.",
          true));
      }

      foreach (var property in GetObjectTypes(entity))
      {
        ValidatePropertyRequired(entity, property);
      }

      return new Domain.ValidationResult(_mainValidator);
    }

    private void ValidatePropertyRequired<T>(T entity, PropertyDescriptor property) where T : Entity
    {
      var valueProperty = property.GetValue(entity);

      if (valueProperty is Entity)
      {
        if (valueProperty is Cliente)
        {
          Validate(valueProperty as Cliente);
        }

        if (valueProperty is Pedido)
        {
          Validate(valueProperty as Pedido);
        }

        if (valueProperty is Endereco)
        {
          Validate(valueProperty as Endereco);
        }

        if (valueProperty is CartaoCredito)
        {
          Validate(valueProperty as CartaoCredito);
        }
      }
    }

    private void AddValidation<T>(T entity, IValidation validacao) where T : Entity
    {
      if (_mainValidator == null)
      {
        _mainValidator = new Validation(validacao.NomeClasse, validacao.NomeMetodo, validacao.Mensagem, validacao.Valido);
        _propertyValidator = _mainValidator;
        return;
      }

      var classeValidacao = _mainValidator.GetByNomeClasse(typeof(T).Name);

      if (classeValidacao == null || classeValidacao is SubValidation)
      {
        _propertyValidator.Add(new Validation(validacao.NomeClasse, validacao.NomeMetodo, validacao.Mensagem, validacao.Valido));
      }
      else
      {
        ((Validation)classeValidacao).Add(validacao);
      }
    }

    private IList<PropertyDescriptor> GetObjectTypes<T>(T entity) where T : Entity
    {
      return TypeDescriptor.GetProperties(typeof(T))
              .Cast<PropertyDescriptor>()
              .Where(p => p.Attributes.Cast<Attribute>().Any(a => a.GetType() == typeof(RequiredAttribute)))
              .Where(p => p.PropertyType == typeof(Entity) || p.PropertyType.BaseType == typeof(Entity))
              .ToList();
    }

    private IList<PropertyDescriptor> GetPrimitiveTypes<T>(T entity) where T : Entity
    {
      return TypeDescriptor.GetProperties(typeof(T))
              .Cast<PropertyDescriptor>()
              .Where(p => p.Attributes.Cast<Attribute>().Any(a => a.GetType() == typeof(RequiredAttribute)))
              .Where(p => p.PropertyType != typeof(Entity) && p.PropertyType.BaseType != typeof(Entity))
              .ToList();
    }

  }
}
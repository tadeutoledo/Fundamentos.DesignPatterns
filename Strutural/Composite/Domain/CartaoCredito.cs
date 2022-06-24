using System.ComponentModel.DataAnnotations;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain
{
  public class CartaoCredito : Entity
  {
    [Required]
    public string? NumeroCartao { get; set; }
    public string? BandeiraCartao { get; set; }
  }
}
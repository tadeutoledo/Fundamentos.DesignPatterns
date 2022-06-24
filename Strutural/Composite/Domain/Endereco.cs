using System.ComponentModel.DataAnnotations;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain
{
  public class Endereco
  {
    [Required]
    public string? Rua { get; set; }
    public string? Complemento { get; set; }
  }
}
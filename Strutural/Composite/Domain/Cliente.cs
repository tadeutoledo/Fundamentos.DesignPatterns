using System.ComponentModel.DataAnnotations;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain
{
  public class Cliente : Entity
  {
    [Required]
    public string? Nome { get; set; }
    [Required]
    public string? Email { get; set; }
    public DateTime Nascimento { get; set; }
    [Required]
    public Endereco? Endereco { get; set; }
  }
}
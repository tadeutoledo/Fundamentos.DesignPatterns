using System.ComponentModel.DataAnnotations;

namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain
{
  public class Pedido
  {
    [Required]
    public decimal Valor { get; set; }
    [Required]
    public Guid IdProduto { get; set; }
    [Required]
    public Cliente? Cliente { get; set; }
    [Required]
    public CartaoCredito? CartaoPedido { get; set; }
  }
}
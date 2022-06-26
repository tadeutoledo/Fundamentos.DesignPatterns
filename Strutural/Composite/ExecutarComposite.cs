using Fundamentos.DesignPatterns.Strutural.Composite.Domain;
using Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite;

namespace Fundamentos.DesignPatterns.Strutural.Composite
{
  public class ExecutarComposite
  {
    public static void Executar()
    {
      Pedido pedido = new Pedido()
      {
        Valor = null,
        IdProduto = null,
        Cliente = new Cliente()
        {
          Nascimento = DateTime.Now,
          Nome = null,
          Email = null,
          Endereco = new Endereco()
          {
            Rua = "",
            Complemento = ""
          }
        },
        CartaoPedido = new CartaoCredito()
        {
          BandeiraCartao = "001",
          NumeroCartao = null
        }
      };

      var validator = new AfluenteValidator<Pedido>();
      ValidationResult validationResult = validator.Validate(pedido);
      validationResult.ExibirMensagens();
    }
  }
}
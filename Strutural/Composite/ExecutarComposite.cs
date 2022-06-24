using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fundamentos.DesignPatterns.Strutural.Composite.Domain;
using Fundamentos.DesignPatterns.Strutural.Composite.Domain.Composite;
using Fundamentos.DesignPatterns.Strutural.Composite.Fabric;

namespace Fundamentos.DesignPatterns.Strutural.Composite
{
  public class ExecutarComposite
  {
    public static void Executar()
    {
      Pedido pedido = new Pedido()
      {
        Valor = 990.20M,
        IdProduto = Guid.NewGuid(),
        Cliente = new Cliente()
        {
          Nascimento = DateTime.Now,
          Nome = null,
          Endereco = new Endereco()
          {
            Rua = "",
            Complemento = ""
          }
        },
        CartaoPedido = new CartaoCredito()
        {
          BandeiraCartao = "001",
          NumeroCartao = "1111222233334444"
        }
      };

      Validacao validacao = new Validacao();

      AfluenteValidator validator = new AfluenteValidator(new SubValidacaoFactory(), validacao);
      validacao = (Validacao)validator.Validate(pedido);
      validacao.ExibirMensagens(2);
    }
  }
}
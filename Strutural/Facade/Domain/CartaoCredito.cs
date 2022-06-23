using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.DesignPatterns.Strutural.Facade.Domain
{
  public class CartaoCredito
  {
    public CartaoCredito(
      string numeroCartao,
      string codigoCVV)
    {
      NumeroCartao = numeroCartao;
      CodigoCVV = codigoCVV;
    }

    public string NumeroCartao { get; set; }
    public string CodigoCVV { get; set; }
  }
}
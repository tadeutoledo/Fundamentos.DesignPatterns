using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.DesignPatterns.Behavioral.Strategy.Domain
{
  public class CartaoCredito : InstrumentoPagamento
  {
    public CartaoCredito(
      string numeroCartao,
      string codigoCVV) : base()
    {
      NumeroCartao = numeroCartao;
      CodigoCVV = codigoCVV;
    }

    public string NumeroCartao { get; set; }
    public string CodigoCVV { get; set; }

    public override bool Validar()
    {
      // Validar cartao 
      return true;
    }
  }
}
using System.Text.Json;

namespace Fundamentos.DesignPatterns.Strutural.Adapter
{
  // class 'Target'
  public class TrasacaoService
  {
    private readonly IFila _fila;
    public TrasacaoService(IFila fila)
    {
      _fila = fila;
    }

    public void AutorizarPagamento(AutorizarPagamentoDTO dto)
    {
      string message = JsonSerializer.Serialize(dto);
      _fila.Publish(nameof(AutorizarPagamento), message);
    }
  }

  public class AutorizarPagamentoDTO
  {
    public Guid Id { get; set; }
  }
}
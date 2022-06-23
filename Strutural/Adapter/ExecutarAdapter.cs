namespace Fundamentos.DesignPatterns.Strutural.Adapter
{
  public class ExecutarAdapter
  {
    public static void Executar()
    {
      AutorizarPagamentoDTO dto = new AutorizarPagamentoDTO()
      {
        Id = Guid.NewGuid()
      };

      TrasacaoService servicePadrao = new TrasacaoService(new Fila());
      servicePadrao.AutorizarPagamento(dto);

      // Adapter
      TrasacaoService serviceCustom = new TrasacaoService(new FilaAdapter(new FialFramework()));
      serviceCustom.AutorizarPagamento(dto);
    }
  }
}
namespace Fundamentos.DesignPatterns.Strutural.Adapter
{
  public class FilaAdapter : IFila
  {
    private readonly IFilaFramework _filaFramework;

    public FilaAdapter(IFilaFramework filaFramework)
    {
      _filaFramework = filaFramework;
    }

    public void Publish(string queue, string message)
    {
      var obj = new
      {
        message
      };

      _filaFramework.Publish(queue, message);
    }

    public void Subscribe(string queue)
    {
      // ...
    }
  }
}
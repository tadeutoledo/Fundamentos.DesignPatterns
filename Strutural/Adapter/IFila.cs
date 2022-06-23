namespace Fundamentos.DesignPatterns.Strutural.Adapter
{
  public interface IFila
  {
    public void Publish(string queue, string message);
    public void Subscribe(string queue);
  }
}
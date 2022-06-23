namespace Fundamentos.DesignPatterns.Strutural.Adapter
{
  public interface IFilaFramework
  {
    public void Publish<T>(string queue, T message) where T : class;
    public void Subscribe(string queue);
  }
}
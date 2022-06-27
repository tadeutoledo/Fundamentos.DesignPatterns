namespace Fundamentos.DesignPatterns.Behavioral.Observer.Interfaces
{
  public interface ISubscriber
  {
    public Guid Id { get; set; }
    public void Notificar(IPublisher messageBroker);
  }
}
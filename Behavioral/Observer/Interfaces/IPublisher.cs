namespace Fundamentos.DesignPatterns.Behavioral.Observer.Interfaces
{
  public interface IPublisher
  {
    public string Nome { get; set; }
    public List<ISubscriber> Subscribers { get; set; }
    public IMessage Message { get; set; }
    public void Attach(ISubscriber Subscriber);
    public void Dettach(ISubscriber Subscriber);
  }
}
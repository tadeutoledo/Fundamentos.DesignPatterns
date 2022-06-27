using Fundamentos.DesignPatterns.Behavioral.Observer.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Observer
{
  public class Publisher : IPublisher
  {
    public string Nome { get; set; }
    public List<ISubscriber> Subscribers { get; set; }
    public IMessage? Message { get; set; }

    public Publisher(
      string nome,
      List<ISubscriber> subscribers)
    {
      Subscribers = subscribers;
      Nome = nome;
    }

    public void Attach(ISubscriber observer)
    {
      Subscribers.Add(observer);
      Console.WriteLine($"O observador {observer.Id} foi adicionado da lista {Nome}.");
    }

    public void Dettach(ISubscriber observer)
    {
      Subscribers.Remove(observer);
      Console.WriteLine($"O observador {observer.Id} foi removido da lista {Nome}.");
      Console.WriteLine($"");
    }

    public void Notificar()
    {
      foreach (var observer in Subscribers)
      {
        observer.Notificar(this);
      }

      Console.WriteLine("");
    }
  }
}
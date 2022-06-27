using Fundamentos.DesignPatterns.Behavioral.Observer.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Observer
{
  public class Subscriber : ISubscriber
  {
    public Subscriber()
    {
      Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }

    public void Notificar(IPublisher publisher)
    {
      Console.WriteLine($"Uma nova mensagem foi recebida da fila: {publisher.Nome}. Mensagem: {publisher.Message?.Body}");
    }
  }
}
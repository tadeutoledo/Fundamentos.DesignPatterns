using Fundamentos.DesignPatterns.Behavioral.Observer.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Observer
{
  public class ExecutarObserver
  {
    public static void Executar()
    {
      var observers = new List<Subscriber>()
      {
        new Subscriber(),
        new Subscriber(),
        new Subscriber(),
      };

      var publisher = new Publisher("AutorizarPagamento", observers.ToList<ISubscriber>());

      for (int i = 0; i < 5; i++)
      {
        Task.Delay(1000);
        publisher.Message = new Message($"Autorizando pagamento {i}", DateTime.Now);

        publisher.Notificar();

        if (i == 1)
        {
          publisher.Dettach(observers[0]);
        }

        if (i == 3)
        {
          publisher.Dettach(observers[1]);
        }
      }
    }
  }
}
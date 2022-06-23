using System.Text.Json;

namespace Fundamentos.DesignPatterns.Strutural.Adapter
{
  // class 'Adaptee'
  public class FialFramework : IFilaFramework
  {
    public void Publish<T>(string queue, T message) where T : class
    {
      // Inicializar Exchange, channel, queue ...
      string messageJson = JsonSerializer.Serialize(message);
      var type = typeof(T);
      Console.WriteLine($"A seguinte mensagem foi publicada na fila do framework: '{queue}' | Obj: '{type}' => [{message}]");
    }

    public void Subscribe(string queue)
    {
      // ...
    }
  }
}
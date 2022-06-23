using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.DesignPatterns.Strutural.Adapter
{
  public class Fila : IFila
  {
    public void Publish(string queue, string message)
    {
      // Inicializar Exchange, channel, queue ...
      Console.WriteLine($"A seguinte mensagem foi publicada na fila '{queue}' => [{message}]");
    }

    public void Subscribe(string queue)
    {
      // Inicializar Exchange, channel, queue ...
      Console.WriteLine($"Consumer adicionado a fila '{queue}'");
    }
  }
}
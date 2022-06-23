using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.DesignPatterns.Creational.Singleton
{
  public class ExecutarSingleton
  {
    public static void Executar()
    {
      EmailSmtp.Instancia.Enviar("smtp.gmail.com", 587, "servidor@gmail.com", "destino@gmail.com");
    }
  }
}
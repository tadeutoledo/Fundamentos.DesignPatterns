namespace Fundamentos.DesignPatterns.Creational.Singleton
{
  public class EmailSmtp
  {
    private static EmailSmtp _instance;
    private static object locker = new object();

    public EmailSmtp()
    {

    }

    public static EmailSmtp Instancia
    {
      get
      {
        if (_instance == null)
        {
          lock (locker)
          {
            if (_instance == null)
            {
              _instance = new EmailSmtp();
            }
          }
        }
        return _instance;
      }
    }

    public void Enviar(string servidor, int porta, string remetente, string destinatario)
    {
      // Disparar email
      Console.WriteLine($"Email do servidor '{servidor}:{porta}' disparado com sucesso para: {destinatario}.");
    }
  }
}
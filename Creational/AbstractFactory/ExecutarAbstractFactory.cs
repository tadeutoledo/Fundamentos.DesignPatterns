using Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract;

namespace Fundamentos.DesignPatterns.Creational.AbstractFactory
{
  public class ExecutarAbstractFactory
  {
    public static void Executar()
    {
      var factory = AbstractMediaFactory.CreateFactory(IMediaSocial.Facebook);
      var media = factory.CreateMediaSocial();
      Console.WriteLine(media.Post("Primeiro Post", "Texto do meu primeiro post"));
      Console.WriteLine(media.Like("O meu primeiro post"));
    }
  }
}
using Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract.Products;
using Fundamentos.DesignPatterns.Creational.AbstractFactory.Concret;

namespace Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract
{
  public abstract class AbstractMediaFactory
  {
    public abstract MediaSocial CreateMediaSocial();

    public static AbstractMediaFactory CreateFactory(IMediaSocial mediaSocial)
    {
      switch (mediaSocial)
      {
        case IMediaSocial.Facebook:
          return new FacebookMediaFactory();
        case IMediaSocial.Orkut:
          return new OrkutMediaFactory();
        default:
          throw new ApplicationException("Media Social invalid.");
      }
    }
  }
}
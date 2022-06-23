using Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract.Products;
using Fundamentos.DesignPatterns.Creational.AbstractFactory.Concret;

namespace Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract
{
  public abstract class AbstractMediaFactory
  {
    public abstract Products.MediaSocial CreateMediaSocial();

    public static AbstractMediaFactory CreateFactory(MediaSocial mediaSocial)
    {
      switch (mediaSocial)
      {
        case MediaSocial.Facebook:
          return new FacebookMediaFactory();
        case MediaSocial.Orkut:
          return new OrkutMediaFactory();
        default:
          throw new ApplicationException("Media Social invalid.");
      }
    }
  }
}
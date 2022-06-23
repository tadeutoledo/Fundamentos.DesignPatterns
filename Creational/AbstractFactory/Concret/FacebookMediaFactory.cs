using Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract;
using Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract.Products;
using Fundamentos.DesignPatterns.Creational.AbstractFactory.Concret.Products;

namespace Fundamentos.DesignPatterns.Creational.AbstractFactory.Concret
{
  public class FacebookMediaFactory : AbstractMediaFactory
  {
    public override Abstract.Products.MediaSocial CreateMediaSocial()
    {
      return new FacebookMediaSocial();
    }
  }
}
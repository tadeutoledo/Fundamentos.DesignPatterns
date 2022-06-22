using Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract;
using Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract.Products;
using Fundamentos.DesignPatterns.Creational.AbstractFactory.Concret.Products;

namespace Fundamentos.DesignPatterns.Creational.AbstractFactory.Concret
{
  public class OrkutMediaFactory : AbstractMediaFactory
  {
    public override MediaSocial CreateMediaSocial()
    {
      return new OrkutMediaSocial();
    }
  }
}
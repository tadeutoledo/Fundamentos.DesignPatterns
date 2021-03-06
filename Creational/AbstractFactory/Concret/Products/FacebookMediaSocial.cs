using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract.Products;

namespace Fundamentos.DesignPatterns.Creational.AbstractFactory.Concret.Products
{
  public class FacebookMediaSocial : Abstract.Products.MediaSocial
  {
    public override string Like(string tituloPost)
    {
      return $"O post '{tituloPost}' foi curtido no Facebook.";
    }

    public override string Post(string titulo, string mensagem)
    {
      return $"Post publicado no Facebook: '{titulo}' - [{mensagem}]";
    }
  }
}
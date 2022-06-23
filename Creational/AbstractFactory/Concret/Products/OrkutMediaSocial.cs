namespace Fundamentos.DesignPatterns.Creational.AbstractFactory.Concret.Products
{
  public class OrkutMediaSocial : Abstract.Products.MediaSocial
  {
    public override string Like(string tituloPost)
    {
      return $"O post '{tituloPost}' foi curtido no Orkut.";
    }

    public override string Post(string titulo, string mensagem)
    {
      return $"Post publicado no Orkut: '{titulo}' - [{mensagem}]";
    }
  }
}
namespace Fundamentos.DesignPatterns.Creational.AbstractFactory.Abstract.Products
{
  public abstract class MediaSocial
  {
    public abstract string Post(string titulo, string mensagem);
    public abstract string Like(string tituloPost);
  }
}
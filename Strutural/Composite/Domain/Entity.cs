namespace Fundamentos.DesignPatterns.Strutural.Composite.Domain
{
  public class Entity
  {
    public Guid Id { get; private set; }

    public Entity()
    {
      Id = Guid.NewGuid();
    }
  }
}
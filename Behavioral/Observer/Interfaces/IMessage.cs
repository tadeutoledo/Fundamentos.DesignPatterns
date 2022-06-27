namespace Fundamentos.DesignPatterns.Behavioral.Observer.Interfaces
{
  public interface IMessage
  {
    public string Body { get; set; }
    public DateTime PublishHour { get; set; }
  }
}
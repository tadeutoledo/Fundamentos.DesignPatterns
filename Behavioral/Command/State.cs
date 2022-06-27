using Fundamentos.DesignPatterns.Behavioral.Command.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Command
{
  public class State : IState
  {
    public bool Sucess { get; set; }
    public string Result { get; set; }

    public State(bool sucess, string result)
    {
      Sucess = sucess;
      Result = result;
    }
  }
}
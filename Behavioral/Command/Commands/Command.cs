using Fundamentos.DesignPatterns.Behavioral.Command.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Command.Commands
{
  public abstract class Command
  {
    protected readonly Log _log;

    public Command(Log log)
    {
      _log = log;
    }

    public abstract IState Execute();
    public abstract IState Revert();
  }
}
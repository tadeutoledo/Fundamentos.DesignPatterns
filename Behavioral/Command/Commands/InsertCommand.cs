using Fundamentos.DesignPatterns.Behavioral.Command.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Command.Commands
{
  public class InsertCommand : Command
  {


    public InsertCommand(Log log) : base(log)
    {

    }

    public override IState Execute()
    {
      try
      {
        _log.Insert();

        return new State(true, "");
      }
      catch (Exception ex)
      {
        return new State(false, ex.Message);
      }
    }

    public override IState Revert()
    {
      try
      {
        _log.UndoChange();

        return new State(true, "");
      }
      catch (Exception ex)
      {
        return new State(false, ex.Message);
      }
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fundamentos.DesignPatterns.Behavioral.Command.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Command.Commands
{
  public class AlterCommand : Command
  {
    public AlterCommand(Log log) : base(log)
    {
    }

    public override IState Execute()
    {
      try
      {
        _log.Alter();

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
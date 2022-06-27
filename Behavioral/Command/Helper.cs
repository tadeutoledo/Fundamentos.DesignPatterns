using Fundamentos.DesignPatterns.Behavioral.Command.Commands;
using Fundamentos.DesignPatterns.Behavioral.Command.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Command
{
  public class Helper
  {
    private IList<Fundamentos.DesignPatterns.Behavioral.Command.Commands.Command> _commands;

    public Helper()
    {
      _commands = new List<Fundamentos.DesignPatterns.Behavioral.Command.Commands.Command>();
    }

    public void SaveLog(Guid id, string message)
    {
      var command = new InsertCommand(new Log(id, message, DateTime.Now));

      _commands.Add(command);

      var state = (State)command.Execute();
      Console.WriteLine($"'InserCommand' executado com {(state.Sucess ? "êxito" : "falha")}. {state.Result}");
    }

    public void AlterLog(Guid id, string message)
    {
      var command = new AlterCommand(new Log(id, message, DateTime.Now));

      _commands.Add(command);

      var state = (State)command.Execute();
      Console.WriteLine($"'AlterCommand' executado com {(state.Sucess ? "êxito" : "falha")}. {state.Result}");
    }

    public void RevertCommands()
    {
      foreach (var cmd in _commands.Reverse())
      {
        cmd.Revert();
      }
    }
  }
}
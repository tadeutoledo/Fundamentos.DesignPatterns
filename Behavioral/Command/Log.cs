using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.DesignPatterns.Behavioral.Command.Interfaces
{
  public class Log
  {
    public Log(Guid id, string message, DateTime date)
    {
      this.Id = id;
      this.Message = message;
      this.Date = date;

    }
    public Guid Id { get; private set; }
    public string Message { get; private set; }
    public DateTime Date { get; private set; }

    public void Insert()
    {
      Console.WriteLine($"Inserindo o log {Id}: {Message} | {Date.ToShortTimeString()}");
    }

    public void Alter()
    {
      Console.WriteLine($"Alterando o log {Id}: {Message} | {Date.ToShortTimeString()}");
    }

    public void UndoChange()
    {
      // Reverse Commit
      Console.WriteLine($"Revertendo Id: {Id}");
    }
  }
}
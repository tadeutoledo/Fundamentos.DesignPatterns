using Fundamentos.DesignPatterns.Behavioral.Command;

public class ExecutarCommand
{
  public static void Executar()
  {
    var helper = new Helper();

    // Insert
    helper.SaveLog(Guid.NewGuid(), "Texto do log de inserção.");

    Console.WriteLine("");
    Console.WriteLine("");

    // Alter
    helper.AlterLog(Guid.NewGuid(), "Texto do log de alteração.");

    Console.WriteLine("");
    Console.WriteLine("");

    // Revert
    helper.RevertCommands();
  }
}
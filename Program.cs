// See https://aka.ms/new-console-template for more information

using Fundamentos.DesignPatterns.Behavioral.Observer;
using Fundamentos.DesignPatterns.Behavioral.Strategy;
using Fundamentos.DesignPatterns.Creational.AbstractFactory;
using Fundamentos.DesignPatterns.Creational.FactoryMethod;
using Fundamentos.DesignPatterns.Creational.Singleton;
using Fundamentos.DesignPatterns.Strutural.Adapter;
using Fundamentos.DesignPatterns.Strutural.Composite;
using Fundamentos.DesignPatterns.Strutural.Facade;

int opcao = 999;

while (opcao > 0)
{
  Console.WriteLine("Digite a opção:");
  Console.WriteLine("");
  Console.WriteLine("  ##### Creational #####");
  Console.WriteLine("");
  Console.WriteLine("1 - Abstract Factory");
  Console.WriteLine("2 - Factory Method");
  Console.WriteLine("3 - Singleton");
  Console.WriteLine("");
  Console.WriteLine("  ##### Strutural #####");
  Console.WriteLine("");
  Console.WriteLine("4 - Adapter");
  Console.WriteLine("5 - Facade");
  Console.WriteLine("6 - Composite");
  Console.WriteLine("");
  Console.WriteLine("  ##### Behavioral #####");
  Console.WriteLine("");
  Console.WriteLine("7 - Command");
  Console.WriteLine("8 - Strategy");
  Console.WriteLine("9 - Observer");

  if (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcao))
    continue;

  Console.Clear();
  Console.WriteLine("");
  Console.WriteLine("------------------------");
  Console.WriteLine("");

  switch (opcao)
  {
    case 1:
      ExecutarAbstractFactory.Executar();
      break;
    case 2:
      ExecutarFactoryMethod.Executar();
      break;
    case 3:
      ExecutarSingleton.Executar();
      break;
    case 4:
      ExecutarAdapter.Executar();
      break;
    case 5:
      ExecutarFacade.Executar();
      break;
    case 6:
      ExecutarComposite.Executar();
      break;
    case 7:
      ExecutarCommand.Executar();
      break;
    case 8:
      ExecutarStrategy.Executar();
      break;
    case 9:
      ExecutarObserver.Executar();
      break;
  }

  Console.WriteLine("");
  Console.WriteLine("------------------------");
  Console.WriteLine("Tecle para recomeçar.");
  Console.ReadKey();
  Console.Clear();
}


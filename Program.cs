// See https://aka.ms/new-console-template for more information

using Fundamentos.DesignPatterns.Creational.AbstractFactory;
using Fundamentos.DesignPatterns.Creational.FactoryMethod;

int opcao = 999;

while (opcao > 0)
{
  Console.WriteLine("Digite a opção:");
  Console.WriteLine("1 - Abstract Factory");
  Console.WriteLine("2 - Factory Method");

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
  }
  Console.ReadKey();
}


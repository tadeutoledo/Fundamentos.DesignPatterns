// See https://aka.ms/new-console-template for more information

using Fundamentos.DesignPatterns.Creational.AbstractFactory;

int opcao = 999;

while (opcao > 0)
{
  Console.WriteLine("Digite a opção:");
  Console.WriteLine("1 - Abstract Factory");

  if (!int.TryParse(Console.Read().ToString(), out opcao))
    opcao = -1;

  switch (opcao)
  {
    case 1:
      ExecutarAbstractFactory.Executar();
      break;
  }
}


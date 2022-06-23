﻿// See https://aka.ms/new-console-template for more information

using Fundamentos.DesignPatterns.Creational.AbstractFactory;
using Fundamentos.DesignPatterns.Creational.FactoryMethod;
using Fundamentos.DesignPatterns.Creational.Singleton;
using Fundamentos.DesignPatterns.Strutural.Adapter;

int opcao = 999;

while (opcao > 0)
{
  Console.WriteLine("Digite a opção:");
  Console.WriteLine("1 - Abstract Factory");
  Console.WriteLine("2 - Factory Method");
  Console.WriteLine("3 - Singleton");
  Console.WriteLine("4 - Adapter");

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
  }

  Console.WriteLine("");
  Console.WriteLine("------------------------");
  Console.WriteLine("Tecle para recomeçar.");
  Console.ReadKey();
  Console.Clear();
}


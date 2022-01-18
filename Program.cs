using Autofac;
using Design_Patterns_Assignment;
using Design_Patterns_Assignment.DecoratorPattern;
using Design_Patterns_Assignment.ObserverPattern;
using Design_Patterns_Assignment.RepositoryPattern;
using Design_Patterns_Assignment.StrategyPattern;
using System;

namespace Design_Patterns_Assignment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Run Autofac Configure
            var container = AFConfig.Configure();

            using var scope = container.BeginLifetimeScope();
            var decorator = scope.Resolve<IDecorator>();
            var repository = scope.Resolve<IRepository>();
            var strategy = scope.Resolve<IStrategy>();
            var observer = scope.Resolve<IObserver>();

            Console.WriteLine("**************************");
            Console.WriteLine("Please choose a pattern");
            Console.WriteLine("");
            Console.WriteLine("1. Decorator Pattern");
            Console.WriteLine("2. Repository Pattern");
            Console.WriteLine("3. Strategy Pattern");
            Console.WriteLine("4. Observer Pattern");
            Console.WriteLine("5. Exit Program");
            Console.WriteLine("");
            Console.WriteLine("*************************");

            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    decorator.Run();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    repository.Run();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    strategy.Run();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    observer.Run();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Unknown command. Please try again.");
                    break;
            }
        }
    }
}
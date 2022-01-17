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
        public static Decorator Decorator { get; set; }
        public static Repository Repository { get; set; }
        public static Strategy Strategy { get; set; }
        public static Observer Observer { get; set; }

        public Program(Decorator decorator, Repository repository, Strategy strategy, Observer observer)
        {
            Decorator = decorator;
            Repository = repository;
            Strategy = strategy;
            Observer = observer;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("Please choose a pattern");
            Console.WriteLine("");
            Console.WriteLine("1. Decorator Pattern");
            Console.WriteLine("2. Repository Pattern");
            Console.WriteLine("3. Strategy Pattern");
            Console.WriteLine("4. Observer Pattern");
            Console.WriteLine("");
            Console.WriteLine("*************************");
            
            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                 case ConsoleKey.D1:
                 case ConsoleKey.NumPad1:
                    Decorator.Run();
                    break;
                 case ConsoleKey.D2:
                 case ConsoleKey.NumPad2:
                    Repository.Run();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Strategy.Run();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Observer.Run();
                    break;
                default:
                    Console.WriteLine("Unknown command. Please try again.");
                     break;
            }
        }
    }
}
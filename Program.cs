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
            // Run Autofac Configure
            var container = AFConfig.Configure();

            // Create an instance of IApplication since we are not using a constructor here
            //using var scope = container.BeginLifetimeScope();
            //var app = scope.Resolve<IApplication>();

            using var scope = container.BeginLifetimeScope();
            var decorator = scope.Resolve<IDecorator>();
            decorator.Run();

            var repository = scope.Resolve<IRepository>();
            decorator.Run();



            //Decorator.Run();
            //Repository.Run();
            Strategy.Run();
            Observer.Run();
        }     
    }
}

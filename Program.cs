using Design_Patterns_Assignment;

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Run Autofac Configure
            var container = AFConfig.Configure();

            Decorator.Run();
            Repository.Run();
            Strategy.Run();
            Observer.Run();
        }     
    }
}

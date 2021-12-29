﻿using Autofac;
using Design_Patterns_Assignment;
using Design_Patterns_Assignment.DecoratorPattern;
using Design_Patterns_Assignment.ObserverPattern;
using System;

namespace Design_Patterns_Assignment
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
            EmailWatcher.Run();
        }     
    }
}

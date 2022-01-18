using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Design_Patterns_Assignment.DecoratorPattern;
using Design_Patterns_Assignment.DecoratorPattern.Decorators;
using Design_Patterns_Assignment.ObserverPattern;
using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using Design_Patterns_Assignment.ObserverPattern.SubjectFiles;
using Design_Patterns_Assignment.RepositoryPattern;
using Design_Patterns_Assignment.RepositoryPattern.DataRepositories;
using Design_Patterns_Assignment.RepositoryPattern.DB;
using Design_Patterns_Assignment.StrategyPattern;
using Design_Patterns_Assignment.StrategyPattern.MessageHandlers;
using Design_Patterns_Assignment.StrategyPattern.Messages;

namespace Design_Patterns_Assignment
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //Decorator Pattern
            builder.RegisterType<Bold>().As<IBold>();
            builder.RegisterType<Deleted>().As<IDeleted>();
            builder.RegisterType<Emphasized>().As<IEmphasized>();
            builder.RegisterType<Important>().As<IImportant>();
            builder.RegisterType<Inserted>().As<IInserted>();
            builder.RegisterType<Italic>().As<IItalic>();
            builder.RegisterType<Marked>().As<IMarked>();
            builder.RegisterType<Smaller>().As<ISmaller>();
            builder.RegisterType<SubScript>().As<ISubScript>();
            builder.RegisterType<SuperScript>().As<ISuperScript>();

            builder.RegisterType<RegularWord>().As<IRegularWord>();
            builder.RegisterType<Decorator>().As<IDecorator>();

            //Repository Pattern
            builder.RegisterType<Repository>().As<IRepository>();
            builder.RegisterType<SimulatedDatabase>().As<ISimulatedDatabase>();
            builder.RegisterType<DataRepository>().As<IDataRepository>();

            //Strategy Pattern
            builder.RegisterType<Strategy>().As<IStrategy>();
            builder.RegisterType<MessageHandler>().As<IMessageHandler>();
            builder.RegisterType<Email>().As<IEmail>();
            builder.RegisterType<SMS>().As<ISMS>();
            builder.RegisterType<FacebookMessage>().As<IFacebookMessage>();

            //Observer Pattern
            builder.RegisterType<Observer>().As<IObserver>();
            builder.RegisterType<EmailWatcher>().As<IEmailWatcher>();
            builder.RegisterType<EmailSubject>().As<IEmailSubject>();

            return builder.Build();
        }
    }
}
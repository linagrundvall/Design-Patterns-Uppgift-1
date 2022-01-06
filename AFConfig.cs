using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Design_Patterns_Assignment.DecoratorPattern;
using Design_Patterns_Assignment.DecoratorPattern.Decorators;

namespace Design_Patterns_Assignment
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //DecoratorPattern Words
            builder.RegisterType<Bold>().As<IBold>();
            builder.RegisterType<Deleted>().As<IDeleted>();
            //builder.RegisterType<Emphasized>().As<IEmphasized>();
            //builder.RegisterType<Important>().As<IImportant>();
            //builder.RegisterType<Inserted>().As<IInserted>();
            //builder.RegisterType<Italic>().As<IItalic>();
            //builder.RegisterType<Marked>().As<IMarked>();
            //builder.RegisterType<Smaller>().As<ISmaller>();
            //builder.RegisterType<SubScript>().As<ISubScript>();
            //builder.RegisterType<SuperScript>().As<ISuperScript>();

            builder.RegisterType<RegularWord>().As<IRegularWord>();

            builder.RegisterType<Decorator>().As<IDecorator>();

            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(i => i.Namespace.Contains("Decorators"))
            //    .As(i => i.GetInterfaces()
            //    .FirstOrDefault(n => n.Name == "I" + i.Name));


            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(i => i.Namespace.Contains("Word"))
            //    .As(i => i.GetInterfaces()
            //    .FirstOrDefault(n => n.Name == "I" + i.Name));

            return builder.Build();
        }
    }
}

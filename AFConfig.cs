using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Design_Patterns_Assignment
{
    public class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            //builder.RegisterType<Application>().As<IApplication>();

            //Register Coffee
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(i => i.Namespace.Contains("Decorators"))
            //    .As(i => i.GetInterfaces()
            //    .FirstOrDefault(n => n.Name == "I" + i.Name));


            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(i => i.Namespace.Contains("Coffee"))
            //    .As(i => i.GetInterfaces()
            //    .FirstOrDefault(n => n.Name == "I" + i.Name));

            return builder.Build();
        }
    }
}

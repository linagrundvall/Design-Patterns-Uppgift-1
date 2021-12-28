using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    internal class RegularWord : IRegularWord
    {
        public string Description { get; private set; }
        public RegularWord()
        {
            Description = "Regular Word";
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}

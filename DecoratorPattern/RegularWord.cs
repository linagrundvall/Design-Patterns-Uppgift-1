using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    internal class RegularWord : IRegularWord
    {
        public string Description { get; set; }
        public string Tag { get; set; }
        public string Input;

        public RegularWord()
        {
            Description = "Regular Word";
            Tag = "";
        }

        public string GetDescription()
        {
            return Description;
        }

        public string GetTag()
        {
            return Tag;
        }
    }
}

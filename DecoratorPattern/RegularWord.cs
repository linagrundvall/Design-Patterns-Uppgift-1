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
        public string TextInput { get; set; }
        public RegularWord()
        {
            Description = "Regular Word";
            //TextInput = "";
        }

        public string GetDescription()
        {
            return Description;
        }

        public string GetTextInput()
        {
            return TextInput;
        }
    }
}

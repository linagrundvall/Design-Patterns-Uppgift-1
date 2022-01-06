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
        public string Tag { get; set; }
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

        //public void SetTextInput(string textInput)
        //{
        //    TextInput = textInput;
        //}
    }
}

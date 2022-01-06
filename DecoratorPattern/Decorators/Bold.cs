using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    internal class Bold : WordDecorator, IBold
    {
        public string textInput { get; set; }
        public Bold(IWord word) : base(word)
        {       
            Description = "bold";
            Tag = "<b>" + textInput + "</b>";
        }

        //public string GetTag()
        //{
        //    return "<b>" + textInput + "</b>";
        //}
    }
}

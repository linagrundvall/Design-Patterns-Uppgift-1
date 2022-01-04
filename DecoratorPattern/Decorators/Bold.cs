using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    internal class Bold : WordDecorator, IBold
    {
        public IHTMLGenerator HTMLGenerator { get; set; }


        public Bold(IWord word) : base(word)
        {
            Description = "bold";
            //Tag = "<b>" + "hej" + "</b>";
        }

        public string GetTag(string textInput)
        {
            //var tag = HTMLGenerator.TagProcessor(Description, textInput);
            //return tag;
            return "bold";
        }
    }
}

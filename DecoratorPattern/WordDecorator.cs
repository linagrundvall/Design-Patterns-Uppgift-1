using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    public abstract class WordDecorator : IWord
    {
        public IWord Word { get; set; }
        public string Description;

        public WordDecorator(IWord word)
        {
            Word = word;
        }
        public string GetDescription()
        {
            return Word.GetDescription() + ", " + Description;
        }

        public string GetTextInput()
        {
            throw new NotImplementedException();
        }
    }
}

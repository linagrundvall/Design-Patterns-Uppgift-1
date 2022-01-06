namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class Marked : WordDecorator, IMarked
    {
        public Marked(IWord word, string textInput) : base(word, textInput)
        { 
            Description = "The word in marked"; 
            Tag = "<mark>" + textInput + "</mark>";
        }
     }
}

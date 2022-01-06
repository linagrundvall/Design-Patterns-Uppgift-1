namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class Smaller : WordDecorator, ISmaller
    {
        public Smaller(IWord word, string textInput) : base(word, textInput)
        {
            Description = "The word in smaller";
            Tag = "<small>" + textInput + "</small>";
        }
    }
}

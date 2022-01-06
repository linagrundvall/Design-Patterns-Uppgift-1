namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    internal class Emphasized : WordDecorator, IEmphasized
    {
        public Emphasized(IWord word, string textInput) : base(word, textInput)
        {
            Description = "The word in emphasized";
            Tag = "<em>" + textInput + "</em>";
        }
    }
}

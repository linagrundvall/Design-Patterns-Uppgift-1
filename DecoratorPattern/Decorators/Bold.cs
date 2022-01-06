namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    internal class Bold : WordDecorator, IBold
    {
        public Bold(IWord word, string textInput) : base(word, textInput)
        {       
            Description = "bold";
            Tag = "<b>" + textInput + "</b>";
        }
    }
}

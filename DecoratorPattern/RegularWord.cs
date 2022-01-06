namespace Design_Patterns_Assignment.DecoratorPattern
{
    internal class RegularWord : IRegularWord
    {
        public string Description { get; set; }
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
    }
}
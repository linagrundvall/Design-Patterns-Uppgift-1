namespace Design_Patterns_Assignment.RepositoryPattern.DB
{
    interface ISimulatedDatabase
    {
        public string Load(string v);
        public void Save(string data);
    }
}

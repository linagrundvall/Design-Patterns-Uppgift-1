using System;

namespace Design_Patterns_Assignment.RepositoryPattern.DB
{
    class SimulatedDatabase : ISimulatedDatabase
    {
        public string Load(string v)
        {
            return v;
        }

        public void Save(string data)
        {
            Console.WriteLine($"Saving data \"{data}\"");
        }
    }
}

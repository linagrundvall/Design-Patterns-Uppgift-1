using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.RepositoryPattern
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

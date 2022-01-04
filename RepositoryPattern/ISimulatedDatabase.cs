using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    interface ISimulatedDatabase
    {
        public string Load(string v);
        public void Save(string data);
    }
}

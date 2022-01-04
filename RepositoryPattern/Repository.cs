using Design_Patterns_Assignment;
using Design_Patterns_Assignment.RepositoryPattern;
using System;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    internal class Repository
    {
        public static IDataRepository DataRepository { get; set; }

        public Repository(IDataRepository dataRepository)
        {
            DataRepository = dataRepository;
        }

        internal static void Run()
        {
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");

            var data = DataRepository.GetAllData("Dataset A");
            //var data = SimulatedDatabase.Load("Dataset A");

            var customer = DataRepository.GetCustomerByName("Steve");
            //var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve"); // this is a search

            var animal = DataRepository.GetAnimalByOwner("Steve");
            //var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve"); // this is a search

            DataRepository.SaveData(data);
            DataRepository.SaveCustomer(customer);
            DataRepository.SaveAnimal(animal);
            //SimulatedDatabase.Save(data);
            //SimulatedDatabase.Save(customer);
            //SimulatedDatabase.Save(animal);
            Console.WriteLine();
        }
    }
}
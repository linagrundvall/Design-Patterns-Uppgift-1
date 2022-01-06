using Design_Patterns_Assignment.RepositoryPattern.DataRepositories;
using System;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    internal class Repository
    {
        public IDataRepository DataRepository { get; set; }

        public Repository(IDataRepository dataRepository)
        {
            DataRepository = dataRepository;
        }

        internal void Run()
        {
            Console.WriteLine("Repository");

            var data = DataRepository.GetAllData("Dataset A");

            var customer = DataRepository.GetCustomerByName("Steve");

            var animal = DataRepository.GetAnimalByOwner("Steve");

            DataRepository.SaveData(data);
            DataRepository.SaveCustomer(customer);
            DataRepository.SaveAnimal(animal);
            Console.WriteLine();
        }
    }
}
using Design_Patterns_Assignment.RepositoryPattern.DB;

namespace Design_Patterns_Assignment.RepositoryPattern.DataRepositories
{
    class DataRepository : IDataRepository
    {
        public static ISimulatedDatabase Db { get; set; }

        public DataRepository(ISimulatedDatabase db)
        {
            Db = db;
        }

        //Data
        public string GetAllData(string data)
        {
            return Db.Load(data);
        }
        public void SaveData(string data)
        {
            Db.Save(data);
        }

        //Customer
        public string GetAllCustomers(string customers)
        {
            return Db.Load(customers);
        }

        public string GetCustomerByName(string name)
        {
            return Db.Load(name);
        }

        public void SaveCustomer(string customer)
        {
            Db.Save(customer);
        }

        //Animal
        public string GetAllAnimals(string animals)
        {
            return Db.Load(animals);
        }

        public string GetAnimalByOwner(string ownersName)
        {
            return Db.Load(ownersName);
        }

        public void SaveAnimal(string animal)
        {
            Db.Save(animal);
        }
    }
}

namespace Design_Patterns_Assignment.RepositoryPattern.DataRepositories
{
    public interface IDataRepository
    {
        //data
        string GetAllData(string data);
        void SaveData(string data);

        //customer
        string GetAllCustomers(string customers);
        string GetCustomerByName(string name);
        void SaveCustomer(string customer);

        //animal
        string GetAllAnimals(string animals);
        string GetAnimalByOwner(string ownersName);
        void SaveAnimal(string animal);
    }
}

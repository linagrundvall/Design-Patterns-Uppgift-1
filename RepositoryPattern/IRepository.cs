using Design_Patterns_Assignment.RepositoryPattern.DataRepositories;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    internal interface IRepository
    {
        IDataRepository DataRepository { get; set; }

        void Run();
    }
}
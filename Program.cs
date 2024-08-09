
using Accurate_Finance.Repository;
using Accurate_Finance.Services;

namespace Accurate_Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositoryAccountant repositoryAccountant = new RepositoryAccountant();
            ServiceAccountant serviceAccountant = new ServiceAccountant(repositoryAccountant);
            ServiceDBFake serviceDBFake = new ServiceDBFake(repositoryAccountant);
            serviceDBFake.CreateTables();
            serviceAccountant.ShowAccountants();
        }
    }
}



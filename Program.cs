
using Accurate_Finance.Repository;
using Accurate_Finance.Services;

namespace Accurate_Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Accountant
                RepositoryAccountant repositoryAccountant = new RepositoryAccountant();
                ServiceAccountant serviceAccountant = new ServiceAccountant(repositoryAccountant);

                //Transaction
                RepositoryTransaction repositoryTransaction = new RepositoryTransaction();
                ServiceTransaction serviceTransaction = new ServiceTransaction(repositoryTransaction);

                ServiceDBFake serviceDBFake = new ServiceDBFake(repositoryAccountant, repositoryTransaction);
                serviceDBFake.CreateTables();
                serviceAccountant.ShowAccountants();
                serviceTransaction.ShowTransactions();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}



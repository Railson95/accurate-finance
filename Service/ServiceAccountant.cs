using Accurate_Finance.Domain;
using Accurate_Finance.Repository;

namespace Accurate_Finance.Services
{
    internal class ServiceAccountant
    {
        public RepositoryAccountant RepositoryAccountant { get; private set; }
        public ServiceAccountant(RepositoryAccountant repositoryAccountant) 
        {
            RepositoryAccountant = repositoryAccountant;
        }
        public void AddAccountant(Accountant accountant)
        {
            ArgumentNullException.ThrowIfNull(nameof(accountant));
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);
        }

        public void ShowAccountants()
        {
            foreach (KeyValuePair<int, Accountant> par in RepositoryAccountant.RepositoryTableAccountant)
            {
                int id = par.Key;
                Accountant value = par.Value;
                Console.WriteLine("-------------------");
                Console.WriteLine("Row id: " + id);
                Console.WriteLine("Accountant " + value.ToString());
            }
        }
    }
}

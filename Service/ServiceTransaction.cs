using Accurate_Finance.Domain;
using Accurate_Finance.Repository;

namespace Accurate_Finance.Services
{
    internal class ServiceTransaction
    {
        public RepositoryTransaction RepositoryTransaction { get; private set; }
        public ServiceTransaction(RepositoryTransaction repositoryTransaction) 
        {
            RepositoryTransaction = repositoryTransaction;
        }

        public void AddTransaction(Transaction transaction)
        {
            ArgumentNullException.ThrowIfNull(nameof(transaction));
            RepositoryTransaction.RepositoryTableTransaction.Add(Transaction.Id, transaction);
        }

        public void ShowTransactions()
        {
            foreach (KeyValuePair<int, Transaction> par in RepositoryTransaction.RepositoryTableTransaction)
            {
                int id = par.Key;
                Transaction value = par.Value;
                Console.WriteLine("-------------------");
                Console.WriteLine("Row id: " + id);
                Console.WriteLine("Transaction " + value.ToString());
            }

            Console.WriteLine("###################");
            Console.WriteLine("Total balance: " + GetTotalBalance());
            Console.WriteLine("###################");
        }

        public double GetTotalBalance()
        {
            double totalBalance = 0;
            foreach (KeyValuePair<int, Transaction> par in RepositoryTransaction.RepositoryTableTransaction)
            {
                int id = par.Key;
                Transaction value = par.Value;
                totalBalance += value.CashFlow.Balance;
            }
            return totalBalance;
        }
    }
}

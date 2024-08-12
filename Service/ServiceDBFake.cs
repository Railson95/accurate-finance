using Accurate_Finance.Domain;
using Accurate_Finance.Repository;
using System.Diagnostics;

namespace Accurate_Finance.Services
{
    internal class ServiceDBFake
    {

        public RepositoryAccountant RepositoryAccountant { get; private set; }
        public RepositoryTransaction RepositoryTransaction { get; private set; }
        public ServiceDBFake(RepositoryAccountant repositoryAccountant, RepositoryTransaction repositoryTransaction)
        {
            RepositoryAccountant = repositoryAccountant;
            RepositoryTransaction = repositoryTransaction;
        }

        public void CreateTables() 
        {
            CreateAccountants();
            CreateTransactions();
        }

        public void CreateAccountants()
        {
            Accountant accountant = new Accountant("Railson Martins", "Rua Josefina", "035999839730", "railson@mail.com", "128.519.216-81");

            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Tiago Martins", "Rua Josefina", "035999839732", "tiago@mail.com", "128.519.217-82");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Ana Silva", "Rua das Flores", "035999839733", "ana@mail.com", "128.519.217-83");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);
        }

        public void CreateTransactions()
        {
            CashFlow cashFlow = new CashFlow(0, 100);
            Transaction transaction = new Transaction(cashFlow);
            RepositoryTransaction.RepositoryTableTransaction.Add(Transaction.Id, transaction);


            cashFlow = new CashFlow(1000, 50);
            Transaction transaction2 = new Transaction(cashFlow);
            RepositoryTransaction.RepositoryTableTransaction.Add(Transaction.Id, transaction2);

            cashFlow = new CashFlow(200, 25);
            Transaction transaction3 = new Transaction(cashFlow);
            RepositoryTransaction.RepositoryTableTransaction.Add(Transaction.Id, transaction3);
        }
    }
}

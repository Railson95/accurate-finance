
using Accurate_Finance.Domain;

namespace Accurate_Finance.Repository
{
    internal class RepositoryTransaction
    {
        public Dictionary<int, Transaction> RepositoryTableTransaction { get; set; }

        public RepositoryTransaction()
        {
            RepositoryTableTransaction = new Dictionary<int, Transaction>();
        }
    }
}

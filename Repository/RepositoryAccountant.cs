
using Accurate_Finance.Domain;

namespace Accurate_Finance.Repository
{
    internal class RepositoryAccountant
    {
        public Dictionary<int, Accountant> RepositoryTableAccountant { get; set; }

        public RepositoryAccountant()
        {
            RepositoryTableAccountant = new Dictionary<int, Accountant>();
        }
    }
}

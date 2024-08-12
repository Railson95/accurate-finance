namespace Accurate_Finance.Domain
{
    internal class Transaction
    {
        public static int Id = 0;
        public CashFlow CashFlow;

        public Transaction(CashFlow cashFlow)
        {
            Id++;
            CashFlow = cashFlow;
        }

        public override string ToString()
        {
            return $" \n Credit: {CashFlow.Credit} " +
                    $"\n Debit: {CashFlow.Debit} " +
                    $"\n Current Balance: {CashFlow.Balance} ";
        }
    }
}

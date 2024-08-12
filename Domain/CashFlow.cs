namespace Accurate_Finance.Domain
{
    internal class CashFlow
    {
        public double Credit { get; private set; }
        public double Debit { get; private set; }
        public double Balance { get; private set; }

        public CashFlow(double initialCredit, double initialDebit)
        {
            // Credit
            Dictionary<string, double>  CreditAndBalance = AddCredit(initialCredit);
            Credit = CreditAndBalance["Credit"];
            Balance = CreditAndBalance["Balance"];

            //Debit
            Dictionary<string, double> DebitAndBalance = AddDebit(initialDebit);
            Debit = DebitAndBalance["Debit"];
            Balance = DebitAndBalance["Balance"];
        }

        public Dictionary<string, double> AddCredit(double credit)
        {
            if (credit < 0)
            {
                throw new ArgumentException("The value must be positive.");
            }
            Credit = credit;
            Balance += credit;
            return new Dictionary<string, double> { 
                { "Credit", Credit },
                {"Balance", Balance },
            };
        }

        public Dictionary<string, double> AddDebit(double debit)
        {
            if (debit < 0)
            {
                throw new ArgumentException("The value must be positive.");
            }
            Debit = debit;
            Balance -= debit;
            return new Dictionary<string, double> {
                {"Debit", Debit },
                {"Balance", Balance },
            };
        }
    }
}

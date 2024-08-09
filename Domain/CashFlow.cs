using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Xml.Linq;

namespace Accurate_Finance.Domain
{
    internal class CashFlow
    {
        public static int Id = 0;
        public double Credit { get; set; }
        public double Debit { get; set; }

        public CashFlow(double credit, double debit)
        {
            Id++;
            Credit = credit;
            Debit = debit;
        }
    }
}

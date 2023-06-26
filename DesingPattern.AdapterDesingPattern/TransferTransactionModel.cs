using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.AdapterDesingPattern
{
    public class TransferTransactionModel
    {
        public Guid Id { get; set; }
        public int FromIBAN { get; set; }
        public int ToIBAN { get; set; }
        public decimal Amount { get; set; }
    }
}

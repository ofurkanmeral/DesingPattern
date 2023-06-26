using DesingPattern.AdapterDesingPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.AdapterDesingPattern.Business
{
    public class JsonBankApi:IBankApi
    {
        public bool ExecuteTransaction(TransferTransactionModel transaction)
        {
            var json = @$"
                
                   \""FromIBAN\"":\""{transaction.FromIBAN}\""
                   \""ToIBAN\"":\""{transaction.ToIBAN}\""
                   \""Amount\"":\""{transaction.Amount}\""
                ";
            Console.WriteLine($"{GetType().Name} is worked");
            Console.WriteLine(json);
            return true;
        }
    }
}

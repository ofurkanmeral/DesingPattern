using DesingPattern.AdapterDesingPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.AdapterDesingPattern.Business
{
    public class XmlBankApi:IBankApi
    {
        public bool ExecuteTransaction(TransferTransactionModel transaction)
        {
            var xml = $@"
                <TranserTransactionModel>
                    <FromIBAN>{transaction.FromIBAN}</FromIBAN>
                    <ToIBAN>{transaction.ToIBAN}</ToIBAN>
                    <Amount>{transaction.Amount}</Amount>
                </TranserTransactionModel>
                ";
            Console.WriteLine($"{GetType().Name} worked");
            Console.WriteLine(xml);
            return true;
        }
    }
}

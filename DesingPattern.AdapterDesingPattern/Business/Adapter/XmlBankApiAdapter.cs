using DesingPattern.AdapterDesingPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.AdapterDesingPattern.Business.Adapter
{
    public class XmlBankApiAdapter : IBankApi
    {
        private readonly XmlBankApi xmlBankApi;
        public XmlBankApiAdapter()
        {
            xmlBankApi = new();
        }
        public bool ExecuteTransaction(TransferTransactionModel transaction)
        {
            return xmlBankApi.ExecuteTransaction(transaction);
        }
    }
}

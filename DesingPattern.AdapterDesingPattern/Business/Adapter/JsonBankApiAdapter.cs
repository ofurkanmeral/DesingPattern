using DesingPattern.AdapterDesingPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.AdapterDesingPattern.Business.Adapter
{
    public class JsonBankApiAdapter : IBankApi
    {
        private readonly JsonBankApi jsonBankApi;
        public JsonBankApiAdapter()
        {
            jsonBankApi = new();
        }
        public bool ExecuteTransaction(TransferTransactionModel transaction)
        {
            return jsonBankApi.ExecuteTransaction(transaction);
        }
    }
}

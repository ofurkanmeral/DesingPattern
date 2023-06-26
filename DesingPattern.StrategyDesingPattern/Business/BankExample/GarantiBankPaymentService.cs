using DesingPattern.StrategyDesingPattern.Interface;
using DesingPattern.StrategyDesingPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.StrategyDesingPattern.Business.BankExample
{
    public class GarantiBankPaymentService : IPaymentService
    {
        public bool Pay(PaymentOptions paymentOptions)
        {
            Console.WriteLine("Garanti Bankasından Ödeme Başarı ile Alındı");
            return true;
        }
    }
}

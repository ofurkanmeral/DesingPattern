using DesingPattern.StrategyDesingPattern.Interface;
using DesingPattern.StrategyDesingPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.StrategyDesingPattern.Business.BankExample
{
    public class PaymentService
    {
        private IPaymentService paymentService;
        public PaymentService() { }
        public PaymentService(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }
        public void SetPaymentService(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }
        public bool PaymentStratgy(PaymentOptions paymentOptions)
        {
            return paymentService.Pay(paymentOptions);
        } 
    }
}

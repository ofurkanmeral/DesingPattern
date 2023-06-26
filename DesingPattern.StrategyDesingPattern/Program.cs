

using DesingPattern.StrategyDesingPattern.Business.BankExample;
using DesingPattern.StrategyDesingPattern.Business.CombatExample;
using DesingPattern.StrategyDesingPattern.Interface;
using DesingPattern.StrategyDesingPattern.Model;

//Bu Desing Pattern'ın en büyük avantajı run timeda değişiklik yapılacağı zamanlarda kullanılmasıdır

//Karakter Örneği
//#region
//var ch = new Character(new AgressiveCombatStrategy());
//ch.ApplyAttachStrategy();

//ch.ApplyAttachStrategy();

//ch.SetCombatStrategy(new DefensiveCombatStrategy());

//ch.ApplyAttachStrategy();

//#endregion

PaymentOptions options = new PaymentOptions { Amount = 24000, CardHolderName = "Holder", CardNumber = "1234", CVV = "254", ExpirationDate = "2022-01-01" };
//var payment = new PaymentService(new IsBankasiBankPaymentService());
//payment.PaymentStratgy(options);

PaymentService paymentService = new PaymentService();
do
{

    Console.WriteLine("Ödeme Yapılacak Bankayı Seçiniz");
    Console.WriteLine("1- Garanti Bankası");
    Console.WriteLine("2- YapıKredi Bankası");
    Console.WriteLine("3- İş Bankası");

    var bank = Console.ReadLine();
    IPaymentService payment = null;
    switch (bank)
    {
        case "1":
            payment = new GarantiBankPaymentService();
            break; ;
        case "2":
            payment = new YapiKrediBankPaymentService();
            break;
        case "3":
            payment=new IsBankasiBankPaymentService();
            break;
        default: Console.WriteLine("Geçersiz Banka");
            break;
    }
    paymentService.SetPaymentService(payment);
    paymentService.PaymentStratgy(options);


} while (Console.ReadKey().Key!=ConsoleKey.Escape);


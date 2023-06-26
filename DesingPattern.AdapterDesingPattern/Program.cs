// See https://aka.ms/new-console-template for more information
using DesingPattern.AdapterDesingPattern;
using DesingPattern.AdapterDesingPattern.Business;
using DesingPattern.AdapterDesingPattern.Business.Adapter;

Console.WriteLine("Hello, World!");

var transfer = new TransferTransactionModel { Amount = 100, FromIBAN = 77, ToIBAN = 29 };
var adapter = new JsonBankApiAdapter();
adapter.ExecuteTransaction(transfer);


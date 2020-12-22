using System;
using AbstractFactoryPattern.Cards;
using AbstractFactoryPattern.Enums;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern
{

    /*
     *  Abstract Factory design pattern 
     *  
     *
     */

    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            CreditCard creditCard = null;
            IBankFactory nationalBank = creator.CreateBankFactory(BanksEnum.National);
            creditCard = nationalBank.BuyCard(CardsEnum.MoneyBack, 500, 10000);
            Console.WriteLine(creditCard.BankName);
            Console.WriteLine(creditCard.CardType);
            Console.WriteLine(creditCard.CreditLimit);
            Console.WriteLine(creditCard.AnnualCharge);
            Console.WriteLine("--------------------------------\n");
            creditCard = nationalBank.BuyCard(CardsEnum.Platinum, 500, 10000);
            Console.WriteLine(creditCard.BankName);
            Console.WriteLine(creditCard.CardType);
            Console.WriteLine(creditCard.CreditLimit);
            Console.WriteLine(creditCard.AnnualCharge);
            Console.WriteLine("--------------------------------\n");
            creditCard = nationalBank.BuyCard(CardsEnum.Titanium, 500, 10000);
            Console.WriteLine(creditCard.BankName);
            Console.WriteLine(creditCard.CardType);
            Console.WriteLine(creditCard.CreditLimit);
            Console.WriteLine(creditCard.AnnualCharge);
            Console.WriteLine("--------------------------------\n");

            IBankFactory kapitalBank = creator.CreateBankFactory(BanksEnum.Kapital);
            creditCard = kapitalBank.BuyCard(CardsEnum.MoneyBack, 500, 10000);
            Console.WriteLine(creditCard.BankName);
            Console.WriteLine(creditCard.CardType);
            Console.WriteLine(creditCard.CreditLimit);
            Console.WriteLine(creditCard.AnnualCharge);
            Console.WriteLine("--------------------------------\n");
            creditCard = kapitalBank.BuyCard(CardsEnum.Platinum, 500, 10000);
            Console.WriteLine(creditCard.BankName);
            Console.WriteLine(creditCard.CardType);
            Console.WriteLine(creditCard.CreditLimit);
            Console.WriteLine(creditCard.AnnualCharge);
            Console.WriteLine("--------------------------------\n");
            creditCard = kapitalBank.BuyCard(CardsEnum.Titanium, 500, 10000);
            Console.WriteLine(creditCard.BankName);
            Console.WriteLine(creditCard.CardType);
            Console.WriteLine(creditCard.CreditLimit);
            Console.WriteLine(creditCard.AnnualCharge);
            Console.WriteLine("--------------------------------\n");

            IBankFactory pashaBank = creator.CreateBankFactory(BanksEnum.Pasha);
            creditCard = pashaBank.BuyCard(CardsEnum.MoneyBack, 500, 10000);
            Console.WriteLine(creditCard.BankName);
            Console.WriteLine(creditCard.CardType);
            Console.WriteLine(creditCard.CreditLimit);
            Console.WriteLine(creditCard.AnnualCharge);
            Console.WriteLine("--------------------------------\n");
            creditCard = pashaBank.BuyCard(CardsEnum.Platinum, 500, 10000);
            Console.WriteLine(creditCard.BankName);
            Console.WriteLine(creditCard.CardType);
            Console.WriteLine(creditCard.CreditLimit);
            Console.WriteLine(creditCard.AnnualCharge);
            Console.WriteLine("--------------------------------\n");
            creditCard = pashaBank.BuyCard(CardsEnum.Titanium, 500, 10000);
            Console.WriteLine(creditCard.BankName);
            Console.WriteLine(creditCard.CardType);
            Console.WriteLine(creditCard.CreditLimit);
            Console.WriteLine(creditCard.AnnualCharge);

            Console.ReadKey();
        }
    }
}

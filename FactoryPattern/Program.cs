using System;
using FactoryPattern.Cards;

namespace FactoryPattern
{

    /*
     *  Factory method design pattern 
     *  
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            CreditCard platinumCard = creator.FactoryMethod(CardsEnum.Platinum, 500, 10000);
            Console.WriteLine(platinumCard.CardType);
            Console.WriteLine(platinumCard.CreditLimit);
            Console.WriteLine(platinumCard.AnnualCharge);
            Console.WriteLine("-----------------------------");

            CreditCard moneyBackCard = creator.FactoryMethod(CardsEnum.MoneyBack, 500, 10000);
            Console.WriteLine(moneyBackCard.CardType);
            Console.WriteLine(moneyBackCard.CreditLimit);
            Console.WriteLine(moneyBackCard.AnnualCharge);
            Console.WriteLine("-----------------------------");

            CreditCard titaniumCard = creator.FactoryMethod(CardsEnum.Titanium, 500, 10000);
            Console.WriteLine(titaniumCard.CardType);
            Console.WriteLine(titaniumCard.CreditLimit);
            Console.WriteLine(titaniumCard.AnnualCharge);
            Console.ReadKey();
        }
    }
}

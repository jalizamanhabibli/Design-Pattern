using System;
using System.Linq;
using System.Reflection;
using AbstractFactoryPattern.Cards;
using AbstractFactoryPattern.Enums;

namespace AbstractFactoryPattern.Factories.Impl
{
    public class KapitalBankFactory : IBankFactory
    {
        private readonly string _bankName;

        public KapitalBankFactory()
        {
            _bankName = "Kapital Bank";
        }

        public CreditCard BuyCard(CardsEnum cardsEnum, int creditLimit, int annualCharge)
        {
            var cardName = cardsEnum + "CreditCard";
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == cardName);
            CreditCard creditCard = (CreditCard)Activator.CreateInstance(type, _bankName, creditLimit, annualCharge);
            return creditCard;
        }
    }
}
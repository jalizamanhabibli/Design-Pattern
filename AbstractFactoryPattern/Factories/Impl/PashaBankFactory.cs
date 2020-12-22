using System;
using System.Linq;
using System.Reflection;
using AbstractFactoryPattern.Cards;
using AbstractFactoryPattern.Enums;

namespace AbstractFactoryPattern.Factories.Impl
{
    public class PashaBankFactory:IBankFactory
    {
        private readonly string _bankName;

        public PashaBankFactory()
        {
            _bankName = "Pasha Bank";
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
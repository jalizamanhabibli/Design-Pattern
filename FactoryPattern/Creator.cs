using System;
using System.Linq;
using System.Reflection;
using FactoryPattern.Cards;

namespace FactoryPattern
{
    public class Creator
    {
        public CreditCard FactoryMethod(CardsEnum cardsEnum,int creditLimit,int annualCharge)
        {
            var cardName = cardsEnum + "CreditCard";
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t =>t.Name == cardName);
            CreditCard creditCart = (CreditCard) Activator.CreateInstance(type,creditLimit,annualCharge);
            return creditCart;
        }
    }
}
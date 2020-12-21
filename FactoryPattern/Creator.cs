using System;
using System.Linq;
using System.Reflection;
using FactoryPattern.Carts;

namespace FactoryPattern
{
    public class Creator
    {
        public CreditCard FactoryMethod(Cards cards,int creditLimit,int annualCharge)
        {
            var cardName = cards + "CreditCard";
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t =>t.Name == cardName);
            CreditCard creditCart = (CreditCard) Activator.CreateInstance(type,creditLimit,annualCharge);
            return creditCart;
        }
    }
}
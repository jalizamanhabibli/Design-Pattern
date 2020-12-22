using AbstractFactoryPattern.Cards;
using AbstractFactoryPattern.Enums;

namespace AbstractFactoryPattern.Factories
{
    public interface IBankFactory
    {
        CreditCard BuyCard(CardsEnum cardsEnum, int creditLimit, int annualCharge);
    }
}
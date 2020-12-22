﻿namespace FactoryPattern.Cards.Impl
{
    public class MoneyBackCreditCard:CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Money back";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType => _cardType;
        public override int CreditLimit
        {
            get => _creditLimit;
            set => _creditLimit = value;
        }
        public override int AnnualCharge
        {
            get => _annualCharge;
            set => _annualCharge = value;
        }
    }
}
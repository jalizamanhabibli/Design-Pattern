﻿namespace AbstractFactoryPattern.Cards.Impl
{
    public class TitaniumCreditCard : CreditCard
    {
        private readonly string _bankName;
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumCreditCard(string bankName, int creditLimit, int annualCharge)
        {
            _bankName = bankName;
            _cardType = "Titanium";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string BankName => _bankName;
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
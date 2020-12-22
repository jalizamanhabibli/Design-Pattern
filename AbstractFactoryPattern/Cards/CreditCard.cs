namespace AbstractFactoryPattern.Cards
{
     public abstract  class CreditCard
    {
        public abstract string BankName { get; }
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}
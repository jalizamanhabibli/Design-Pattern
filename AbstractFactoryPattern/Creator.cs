using System;
using System.Linq;
using System.Reflection;
using AbstractFactoryPattern.Enums;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern
{
    public class Creator
    {
        public IBankFactory CreateBankFactory(BanksEnum banksEnum)
        {
            var factoryName = banksEnum + "BankFactory";
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == factoryName);
            IBankFactory bankFactory = (IBankFactory) Activator.CreateInstance(type);
            return bankFactory;
        }
    }
}
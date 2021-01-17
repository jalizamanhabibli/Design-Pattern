using System;

namespace DecoratorPattern.Decorator
{
    public class CryptoMailDecorator:MailDecorator
    {
        public CryptoMailDecorator(IMail mail) : base(mail)
        {
        }

        public override void Sent()
        {
            base.Sent();
            Console.WriteLine("Şifrelendi");
        }
    }
}
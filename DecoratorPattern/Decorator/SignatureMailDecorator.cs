using System;

namespace DecoratorPattern.Decorator
{
    public class SignatureMailDecorator:MailDecorator
    {
        private string _signature;
        public SignatureMailDecorator(IMail mail, string signature) : base(mail)
        {
            this._signature = signature;
        }

        public override void Sent()
        {
            base.Sent();
            Console.WriteLine($"Signature: {_signature}");
        }
    }
}
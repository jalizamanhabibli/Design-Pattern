using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecoratorPattern.Decorator;
namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMail mail = new Mail("Alizaman","Samir");
            MailDecorator signatureMail = new SignatureMailDecorator(mail,"Alizaman Habibli");
            MailDecorator cryptoMail = new CryptoMailDecorator(signatureMail);

            cryptoMail.Sent();

            Console.ReadKey();
        }
    }
}

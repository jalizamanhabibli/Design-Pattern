using System;

namespace DecoratorPattern
{
    public class Mail:IMail
    {

        private readonly string _form;
        private readonly string _to;

        public Mail(string form, string to)
        {
            _form = form;
            _to = to;
        }

        public void Sent()
        {
            Console.WriteLine($"Mail sent from {_form} to {_to}");
        }
    }
}
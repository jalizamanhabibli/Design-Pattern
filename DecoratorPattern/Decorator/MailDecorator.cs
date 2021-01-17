namespace DecoratorPattern.Decorator
{
    public abstract class MailDecorator: IMail
    {
        private IMail _mail;

        protected MailDecorator(IMail mail)
        {
            _mail = mail;
        }

        public virtual void Sent()
        {
            _mail.Sent();
        }
    }
}
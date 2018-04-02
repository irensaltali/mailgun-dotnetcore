using NUnit.Framework;

namespace MailgunDotNetCore.Samples
{
    public class Sample
    {
        protected Mailgun mailgun;

        [SetUp]
        public void Initialize()
        {
            mailgun = new Mailgun(null, null, null, true);
        }
    }
}

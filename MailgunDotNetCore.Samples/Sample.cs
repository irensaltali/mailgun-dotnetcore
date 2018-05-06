using NUnit.Framework;

namespace MailgunDotNetCore.Samples
{
    public class Sample
    {
        protected Mailgun mailgun;

        [SetUp]
        public void Initialize()
        {
            mailgun = new Mailgun("postmaster@sandbox601b68cf6f324743aa1d3cef2006f29a.mailgun.org", 
                "sandbox601b68cf6f324743aa1d3cef2006f29a.mailgun.org", 
                "key-f05c01a9c8bebb906b07386f91b647fd",
                false);
        }
    }
}

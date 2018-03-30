using NUnit.Framework;

namespace Mailgun.Samples
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

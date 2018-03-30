using NUnit.Framework;

namespace Mailgun.Samples
{
    class SendingEmailTets : Sample
    {

        [Test]
        public void SendTextBasedEmail()
        {
            var response = mailgun.SendTextEmail(new DTO.TextEmailRequest
            {
                From = "iren@mottojoy.com",
                To = "info@mottojoy.com",
                Subject = "Konu",
                TextBody = "Mesaj"
            });

            Assert.IsTrue(response.IsSuccessfull);
        }

        [Test]
        public void SendHTMLBasedEmail()
        {
            var response = mailgun.SendHMTLEmail(new DTO.HTMLEmailRequest
            {
                From = "iren@mottojoy.com",
                To = "info@mottojoy.com",
                Subject = "Konu",
                TextBody = "Mesaj",
                HTMLBody = "<html>HTML Mesaj</html>"
            });

            Assert.IsTrue(response.IsSuccessfull);
        }

    }
}

using NUnit.Framework;

namespace MailgunDotNetCore.Samples
{
    class SendingEmailTets : Sample
    {

        [Test]
        public void SendTextBasedEmail()
        {
            var response = mailgun.SendTextEmail(new DTO.TextEmailRequest
            {
                To = "iren@saltali.com",
                Subject = "Subject",
                TextBody = "Message"
            });

            Assert.IsTrue(response.IsSuccessfull);
        }

        [Test]
        public void SendHTMLBasedEmail()
        {
            var response = mailgun.SendHMTLEmail(new DTO.HTMLEmailRequest
            {
                To = "iren@saltali.com",
                Subject = "Subject",
                TextBody = "Message",
                HTMLBody = "<html>HTML Message</html>"
            });

            Assert.IsTrue(response.IsSuccessfull);
        }

    }
}

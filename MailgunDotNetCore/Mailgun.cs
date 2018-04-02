using MailgunDotNetCore.DTO;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Threading.Tasks;

namespace MailgunDotNetCore
{
    public class Mailgun
    {
        private readonly string Domain = "sandboxad3e5404de614718b2d470bb676b2ed5.mailgun.org";
        private readonly string BaseUrl = "https://api.mailgun.net/v3";
        private readonly string APIKey = "key-6265bd875bde4983e5d91dc0db6ad7ba";
        private string From;
        public bool TestMode { get; set; }

        public Mailgun(string From = null, string Domain = null, string APIKey = null, bool TestMode = false)
        {
            if (!string.IsNullOrEmpty(Domain))
            {
                this.Domain = Domain;
                this.BaseUrl += "/" + Domain;
            }

            if (!string.IsNullOrEmpty(From))
                this.From = From;

            if (!string.IsNullOrEmpty(APIKey))
                this.From = APIKey;

            this.TestMode = TestMode;
        }

        public async Task<TextEmailResponse> SendTextEmailAsync(TextEmailRequest request)
        {
            return await Task.Run(() => SendTextEmail(request));
        }
        public TextEmailResponse SendTextEmail(TextEmailRequest request)
        {
            var response = new TextEmailResponse();

            RestClient client = new RestClient
            {
                BaseUrl = new Uri(BaseUrl),
                Authenticator = new HttpBasicAuthenticator("api", APIKey)
            };

            RestRequest restTequest = new RestRequest();
            restTequest.AddParameter("domain", Domain, ParameterType.UrlSegment);
            restTequest.Resource = "{domain}/messages";
            if (string.IsNullOrEmpty(request.From))
                restTequest.AddParameter("from", From);
            else
                restTequest.AddParameter("from", request.From);
            restTequest.AddParameter("to", request.To);

            if (!string.IsNullOrEmpty(request.CC))
                restTequest.AddParameter("cc", request.CC);

            if (!string.IsNullOrEmpty(request.BCC))
                restTequest.AddParameter("bcc", request.BCC);

            restTequest.AddParameter("subject", request.Subject);
            restTequest.AddParameter("text", request.TextBody);

            if (this.TestMode)
                restTequest.AddParameter("o:testmode", this.TestMode);

            restTequest.Method = Method.POST;
            var result = client.Execute(restTequest);

            response.IsSuccessfull = result.IsSuccessful;
            if (!result.IsSuccessful)
            {
                response.InfoMessage = result.ErrorMessage;
            }

            return response;
        }

        public async Task<HTMLEmailResponse> SendHMTLEmailAsync(HTMLEmailRequest request)
        {
            return await Task.Run(() => SendHMTLEmail(request));
        }
        public HTMLEmailResponse SendHMTLEmail(HTMLEmailRequest request)
        {
            var response = new HTMLEmailResponse();

            RestClient client = new RestClient
            {
                BaseUrl = new Uri(BaseUrl),
                Authenticator = new HttpBasicAuthenticator("api", APIKey)
            };

            RestRequest restTequest = new RestRequest();
            restTequest.AddParameter("domain", Domain, ParameterType.UrlSegment);
            restTequest.Resource = "{domain}/messages";
            if (string.IsNullOrEmpty(request.From))
                restTequest.AddParameter("from", From);
            else
                restTequest.AddParameter("from", request.From);
            restTequest.AddParameter("to", request.To);

            if (!string.IsNullOrEmpty(request.CC))
                restTequest.AddParameter("cc", request.CC);

            if (!string.IsNullOrEmpty(request.BCC))
                restTequest.AddParameter("bcc", request.BCC);

            restTequest.AddParameter("subject", request.Subject);
            restTequest.AddParameter("text", request.TextBody);
            restTequest.AddParameter("html", request.HTMLBody);

            if (this.TestMode)
                restTequest.AddParameter("o:testmode", this.TestMode);

            restTequest.Method = Method.POST;
            var result = client.Execute(restTequest);

            response.IsSuccessfull = result.IsSuccessful;
            if (!result.IsSuccessful)
            {
                response.InfoMessage = result.ErrorMessage;
            }

            return response;
        }
    }
}

using Mailgun.Constants;

namespace Mailgun.Framework
{
    public abstract class BaseResponse
    {
        public Error Error { get; set; }
        public bool IsSuccessfull { get; set; }
        public string InfoMessage { get; set; }
    }
    public abstract class BaseRequest
    {
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string TextBody { get; set; }

    }
}

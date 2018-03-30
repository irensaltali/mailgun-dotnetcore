using Mailgun.Framework;

namespace Mailgun.DTO
{
    public class HTMLEmailResponse : BaseResponse
    {
    }

    public class HTMLEmailRequest : BaseRequest
    {
        public string HTMLBody { get; set; }
    }
}

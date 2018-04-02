using MailgunDotNetCore.Framework;

namespace MailgunDotNetCore.DTO
{
    public class HTMLEmailResponse : BaseResponse
    {
    }

    public class HTMLEmailRequest : BaseRequest
    {
        public string HTMLBody { get; set; }
    }
}

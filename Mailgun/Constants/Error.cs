using System.Collections.Generic;

namespace Mailgun.Constants
{
    public class Error
    {
        private readonly int _errorCode;
        private readonly string _errorDescription;

        public string ErrorDescription { get { return _errorDescription; } }
        public int ErrorCode { get { return _errorCode; } }

        private readonly Dictionary<int, string> ErrorDescriptions = new Dictionary<int, string>
            {
                {200,"Everything worked as expected"},
                {400,"Bad Request - Often missing a required parameter"},
                {401,"Unauthorized - No valid API key provided"},
                {402,"Request Failed - Parameters were valid but request failed"},
                {404,"Not Found - The requested item doesn’t exist"},
                {500,"Server Errors - something is wrong on Mailgun’s end"},
                {502,"Server Errors - something is wrong on Mailgun’s end"},
                {503,"Server Errors - something is wrong on Mailgun’s end"},
                {504,"Server Errors - something is wrong on Mailgun’s end"}
            };

        public static readonly Error _200 = new Error(200);
        public static readonly Error _400 = new Error(400);
        public static readonly Error _401 = new Error(401);
        public static readonly Error _402 = new Error(402);
        public static readonly Error _404 = new Error(404);
        public static readonly Error _500 = new Error(500);
        public static readonly Error _502 = new Error(502);
        public static readonly Error _503 = new Error(503);
        public static readonly Error _504 = new Error(504);

        public Error(int ErrorCode)
        {
            _errorCode = ErrorCode;
            ErrorDescriptions.TryGetValue(ErrorCode, out _errorDescription);
        }
    }
}

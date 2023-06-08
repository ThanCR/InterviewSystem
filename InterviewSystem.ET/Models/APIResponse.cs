namespace InterviewSystem.ET.Models
{
    public class APIResponse<ResponseObject>
    {
        //Setting up custom model for API Responses to standarize it.
        #region [API Response Attributes]
        public int Code { get; set; }
        public string Message { get; set; }
        public ResponseObject Response { get; set; }
        #endregion

        #region [Constructors]

        //Accepts no parameters
        public APIResponse() { }

        //Accepts code and response object
        public APIResponse(int code, ResponseObject response)
        {
            Code = code;
            Response = response;
            Message = "No Message";
        }

        //Accepts code and message
        public APIResponse(int code, string message)
        {
            Code=code;
            Message = message;
        }

        //Accepts code, message and response object
        public APIResponse(int code, string message, ResponseObject response)
        {
            Code = code;
            Message = message;
            Response = response;
        }
        #endregion
    }
}

/**
 * Author:    dummyAuthor
 * Description:   dummyDescription
 * Created:   dummyCreated
 **/

namespace Main
{
    public class Request
    {
        public string httpMethod { get; set; }
        public string body { get; set; }
    }

    public class Response
    {
        public int StatusCode { get; set; }
        public string Body { get; set; }

        public Response(int statusCode, string body)
        {
            StatusCode = statusCode;
            Body = body;
        }
    }

}

/**
 * Author:    dummyAuthor
 * Description:   dummyDescription
 * Created:   dummyCreated
 **/

namespace Main
{
    //The Entry point of your function is Main.Handler
    //(because, Main namespace has Handler class with FunctionHandler method)
    //The Request is a JSON payload that must be sent from your client to this function
    public class Handler
    {
        public Response FunctionHandler(Request request)
        {
            return new Response(200, "Hello from your dummyFunctionName");
        }
    }
}

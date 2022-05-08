/**
 * Author:    dummyAuthor
 * Description:   dummyDescription
 * Created:   dummyCreated
 **/
using System;
namespace Main
{
    public static class Helper
    {
        //Writing a message to the Cloud Function log
        public static void LogMessage(string message)
        {
              Console.WriteLine(message);
        }

        //Reading a system variable from the Cloud Function environment
        public static string GetEnvVarValue(string envVariableName)
        {

            if (!string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable(envVariableName)))
            {
                return Environment.GetEnvironmentVariable(envVariableName);
            }
            else
            {
                return "Environment variable is missing";
            }
        }

    }
}

using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace dwheartapp.Services;

public static class UserInformationService
{
    public static void SetupUserInformationService()
    {

    }

    public static string GetUserEmailAddress(HttpContext context)
    {
        string identifier = "X-MS-CLIENT-PRINCIPAL-NAME";
        IEnumerable<string> headerValues = context.Request.Headers[identifier];
        if (headerValues == null)
        {
            return "";
        }
        else { 
            return headerValues.FirstOrDefault();
        }        
    }
}

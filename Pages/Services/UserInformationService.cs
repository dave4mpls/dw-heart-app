using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace dwheartapp.Services;

public static class UserInformationService
{
    public void SetupUserInformationService()
    {

    }

    public string GetUserEmailAddress(HttpContext context)
    {
        String identifier = "X-MS-CLIENT-PRINCIPAL-NAME";
        IEnumerable<string> headerValues = context.Request.Headers.GetValues(identifier);
        if (headerValues == null)
        {
            return "";
        }
        else { 
            return headerValues.FirstOrDefault();
        }        
    }
}

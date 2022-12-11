using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;
using dwheartapp.Services;

namespace dwheartapp.Pages;

public class IndexModel : PageModel
{

    public string OSVersion { get { return RuntimeInformation.OSDescription; }  }
    
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string UserLoggedInName
    {
        get {
            return UserInformationService.GetUserEmailAddress(HttpContext);
        }
    }

    public void OnGet()
    {        
    }
}

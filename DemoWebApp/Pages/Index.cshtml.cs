using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Bună ziua! Această aplicație demonstrează un pipeline Azure DevOps.";
        }
    }
}
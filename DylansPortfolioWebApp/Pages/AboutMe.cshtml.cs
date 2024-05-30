using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DylansPortfolioWebApp.Pages
{
    public class AboutMeModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public AboutMeModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

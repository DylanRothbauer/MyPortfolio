using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DylansPortfolioWebApp.Pages
{
    public class ExperienceModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ExperienceModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

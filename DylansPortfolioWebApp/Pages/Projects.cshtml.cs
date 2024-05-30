using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DylansPortfolioWebApp.Pages
{
    public class ProjectsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ProjectsModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

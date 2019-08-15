using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GitDC.Controllers
{
    [Authorize]
    public class HomeController : DCControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

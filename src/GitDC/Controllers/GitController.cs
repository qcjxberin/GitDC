using GitDC.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GitDC.Controllers
{
    [Authorize(AuthenticationSchemes = BasicAuthenticationDefaults.AuthenticationScheme)]
    public class GitController : DCControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

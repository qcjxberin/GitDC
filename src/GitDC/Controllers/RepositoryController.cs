using Microsoft.AspNetCore.Mvc;
using System.Composition;
using Ding.Webs.Controllers;

namespace GitDC.Controllers
{
    [Export(typeof(RepositoryController))]
    public class RepositoryController : DCControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

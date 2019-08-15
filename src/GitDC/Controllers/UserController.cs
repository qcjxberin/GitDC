using Ding.Helpers;
using GitDC.Common;
using GitDC.Models;
using GitDC.Service.Abstractions.dbo;
using GitDC.Service.Dtos.dbo;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GitDC.Controllers
{
    public class UserController: DCControllerBase
    {
        public IActionResult Index()
        {
            return Content("ok");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var DCUsersService = Ioc.Create<IDCUsersService>();
                var modelUser = await DCUsersService.GetUserByName(model.Username);
                if (modelUser != null && modelUser.Password == await DCUsersService.CreateUserPassword(model.Password, modelUser.Salt))
                {
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, modelUser.Name));
                    identity.AddClaim(new Claim(ClaimTypes.Name, modelUser.Name));
                    identity.AddClaim(new Claim(ClaimTypes.Email, modelUser.Email));
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return Redirect("/");
                }
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var DCUsersService = Ioc.Create<IDCUsersService>();
                var modelUser = new DCUsersDto();
                modelUser.Name = model.Username;
                modelUser.NickName = model.Username;
                modelUser.Email = model.Email;
                modelUser.PasswordVersion = 1;
                modelUser.Salt = Randoms.MakeRandomString(SiteSetting.Current.WebConfig.RandomLibrary, 6);
                modelUser.Password = await DCUsersService.CreateUserPassword(model.Password, modelUser.Salt);
                modelUser.Description = "";
                modelUser.IsSystemAdministrator = false;
                modelUser.CreationTime = DateTime.Now;
                await DCUsersService.CreateAsync(modelUser);
            }
            return View();
        }

        public async Task<IActionResult> Signout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }
    }
}

using Ding.Helpers;
using Ding.Webs.Controllers;
using Ding.Webs.Models;
using GitDC.Common;
using GitDC.Models;
using GitDC.Service.Abstractions.dbo;
using LibGit2Sharp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Threading.Tasks;

namespace GitDC.Controllers
{
    public class DCControllerBase : WebControllerBase
    {
        protected GitCommandResult GitCommand(string repoName, string service, bool advertiseRefs, bool endStreamWithNull = true)
        {
            var DCRepositoriesService = Ioc.Create<IDCRepositoriesService>();

            return new GitCommandResult(SiteSetting.Current.GitConfig.GitCorePath, new GitCommandOptions(
                DCRepositoriesService.GetRepository(repoName),
                service,
                advertiseRefs,
                endStreamWithNull
            ));
        }

        protected GitCommandResult GitUploadPack(string repoName) => GitCommand(repoName, "git-upload-pack", false, false);

        protected GitCommandResult GitReceivePack(string repoName) => GitCommand(repoName, "git-receive-pack", false);

        protected IActionResult TryGetResult(string repoName, Func<IActionResult> resFunc)
        {
            try
            {
                return resFunc();
            }
            catch (RepositoryNotFoundException)
            {
                return MakeError("Repository not found", repoName, 404);
            }
            catch (NotFoundException)
            {
                return MakeError("The requested file could not be found", repoName, 404);
            }
            catch (Exception e)
            {
                return MakeError(e, repoName);
            }
        }

        private IActionResult MakeError(string message, string repoName, int statusCode = 500)
        {
            ErrorModel model = new ErrorModel
            {
                StatusCode = statusCode,
                Message = message,
                Description = $"An error occured while accessing repository \"{repoName}\": {message}"
            };

            ViewResult viewResult = View("_Error", model);
            viewResult.StatusCode = statusCode;
            return viewResult;
        }

        private IActionResult MakeError(Exception error, string repoName, int statusCode = 500)
        {
            return MakeError(error.Message, repoName, statusCode);
        }

        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            return base.OnActionExecutionAsync(context, next);
        }

        private ViewResult view(HttpContext HttpContext, PromptModel model)
        {
            var ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
            {
                Model = model
            };
            var TempData = Ioc.Create<ITempDataDictionaryFactory>()?.GetTempData(HttpContext);
            var view = new ViewResult
            {
                ViewName = "Prompt",
                ViewData = ViewData,
                TempData = TempData
            };
            return view;
        }
    }
}

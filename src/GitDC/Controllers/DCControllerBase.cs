using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ding.Helpers;
using Ding.Log;
using Ding.Webs.Controllers;
using Ding.Webs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace GitDC.Controllers
{
    public class DCControllerBase : WebControllerBase
    {
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

using Ding.Helpers;
using Ding.Webs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Threading.Tasks;

namespace GitDC.Handlers
{
    /// <summary>
    /// 当前系统自定义Web过滤器
    /// </summary>
    public class WebAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await base.OnActionExecutionAsync(context, next);
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

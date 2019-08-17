using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Mvc.Rendering
{
    public static class HtmlHelperExtension
    {
        public static RouteValueDictionary OverRoute(this IHtmlHelper helper, object routeValues = null, bool withQuery = false)
        {
            var old = helper.ViewContext.RouteData.Values;

            if (routeValues == null)
                return old;

            var over = new Dictionary<string, object>(old, StringComparer.OrdinalIgnoreCase);
            if (withQuery)
            {
                var qs = helper.ViewContext.HttpContext.Request.Query;
                foreach (var key in qs)
                    over[key.Key] = qs[key.Key];
            }
            var values = new RouteValueDictionary(routeValues);
            foreach (var pair in values)
                over[pair.Key] = pair.Value;

            return new RouteValueDictionary(over);
        }
    }
}

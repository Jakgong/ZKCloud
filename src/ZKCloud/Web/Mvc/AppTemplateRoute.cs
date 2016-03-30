using Microsoft.AspNet.Routing;
using Microsoft.AspNet.Routing.Template;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ZKCloud.Web.Mvc
{
    public class AppTemplateRoute: TemplateRoute
    {
        public AppTemplateRoute(IRouter target, string routeTemplate, IInlineConstraintResolver inlineConstraintResolver)
        : base(target, routeTemplate, inlineConstraintResolver: inlineConstraintResolver)
    {
        }

        public AppTemplateRoute(IRouter target,
                                string routeTemplate,
                                IDictionary<string, object> defaults,
                                IDictionary<string, object> constraints,
                                IDictionary<string, object> dataTokens,
                                IInlineConstraintResolver inlineConstraintResolver)
        : base(target, routeTemplate, defaults, constraints, dataTokens, inlineConstraintResolver)
    {
        }

        public AppTemplateRoute(IRouter target,
                                string routeName,
                                string routeTemplate,
                                IDictionary<string, object> defaults,
                                IDictionary<string, object> constraints,
                                IDictionary<string, object> dataTokens,
                                IInlineConstraintResolver inlineConstraintResolver)
        : base(target, routeName, routeTemplate, defaults, constraints, dataTokens, inlineConstraintResolver)
    { }

        public async override Task RouteAsync(RouteContext context)
        {
            var requestPath = context.HttpContext.Request.Path.Value ?? string.Empty;
            Debug.WriteLine("访问地址:" + requestPath);
            //if (!requestPath.StartsWith("/promo", StringComparison.OrdinalIgnoreCase))
            //{
            //    return;
            //}
            await base.RouteAsync(context);
        }
    }
}

using Microsoft.AspNet.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZKCloud.Web.Mvc
{
    public static class  AppRouteBuilderExtensions
    {
        public static IRouteBuilder MapAppRoute(this IRouteBuilder routeCollectionBuilder, string name, string template)
        {
            MapAppRoute(routeCollectionBuilder, name, template, defaults: null);
            return routeCollectionBuilder;
        }

        public static IRouteBuilder MapAppRoute(this IRouteBuilder routeCollectionBuilder, string name, string template, object defaults)
        {
            return MapAppRoute(routeCollectionBuilder, name, template, defaults, constraints: null, dataTokens: null);
        }

        public static IRouteBuilder MapAppRoute(this IRouteBuilder routeCollectionBuilder, string name, string template, object defaults, object constraints, object dataTokens)
        {
            var inlineConstraintResolver = (IInlineConstraintResolver)routeCollectionBuilder.ServiceProvider.GetService(typeof(IInlineConstraintResolver));
            routeCollectionBuilder.Routes.Add(
                new AppTemplateRoute(
                    routeCollectionBuilder.DefaultHandler,
                    name,
                    template,
                    ObjectToDictionary(defaults),
                    ObjectToDictionary(constraints),
                    ObjectToDictionary(dataTokens),
                    inlineConstraintResolver));

            return routeCollectionBuilder;
        }

        private static IDictionary<string, object> ObjectToDictionary(object value)
        {
            var dictionary = value as IDictionary<string, object>;
            if (dictionary != null)
            {
                return dictionary;
            }

            return new RouteValueDictionary(value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvcdemo.common.Filters
{
    /*
    public class ApiKeyAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(!context.HttpContext.Request.Headers.TryGetValue("ApiKey", out var extractApiKey))
            {
                context.Result = new ContentResult(){
                    StatusCode = 401,
                    Content = "ApiKey is missing"
                };
            }
            var appSettings= context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var ApiKeys = appSettings.GetValue<String>("ApiKeys").Split(',');

            if(!ApiKeys.Contains(extractApiKey.ToString()))
            {
                context.Result = new ContentResult(){
                    StatusCode = 401,
                    Content = "ApiKey is not permit"
                };
            }
        }
    }
*/
    
    public class ApiKeyAttribute : Attribute, IActionFilter
    {
        public void LaGiCungDuoc(){
            
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if(!context.HttpContext.Request.Headers.TryGetValue("ApiKey", out var extractApiKey))
            {
                context.Result = new ContentResult(){
                    StatusCode = 401,
                    Content = "ApiKey is missing"
                };
            }
            var appSettings= context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var ApiKeys = appSettings.GetValue<String>("ApiKeys").Split(',');

            if(!ApiKeys.Contains(extractApiKey.ToString()))
            {
                context.Result = new ContentResult(){
                    StatusCode = 401,
                    Content = "ApiKey is not permit"
                };
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace mvcdemo.Models.ModelBinding
{
    public class LoginModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var body = bindingContext.HttpContext.Request.Body;
            var stream = new StreamReader(body, Encoding.UTF8);
            var bodyContent = HttpUtility.HtmlDecode(stream.ReadToEnd());

            var obj = JsonConvert.DeserializeObject<LoginModel>(bodyContent);
            if(String.IsNullOrEmpty(obj.Username) || String.IsNullOrEmpty(obj.Password))
            {
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "Username or Password is empty");
            }
            
            bindingContext.Result = ModelBindingResult.Success(obj);
            
            return Task.CompletedTask;
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace mvcdemo.Models.ModelBinding
{
    public class LoginModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var userInfo = (LoginModel)bindingContext.Result.Model;
            if(userInfo==null) 
            {
                    bindingContext.Result = ModelBindingResult.Failed();
                    return Task.CompletedTask;
            }
            else
            {
                if(String.IsNullOrEmpty(userInfo.Username) || String.IsNullOrEmpty(userInfo.Password))
                {
                    bindingContext.Result = ModelBindingResult.Failed();
                    return Task.CompletedTask;
                }
                bindingContext.Result = ModelBindingResult.Success(userInfo);
                return Task.CompletedTask;
            }
            
        }
    }
}
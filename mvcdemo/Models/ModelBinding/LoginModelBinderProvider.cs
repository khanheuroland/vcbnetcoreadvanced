using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace mvcdemo.Models.ModelBinding
{
    public class LoginModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if(context.Metadata.ModelType == typeof(LoginModel))
            {
                return new LoginModelBinder();
            }
            return null;
        }
    }
}
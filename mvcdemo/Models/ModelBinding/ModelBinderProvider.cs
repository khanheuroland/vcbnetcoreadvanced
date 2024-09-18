using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace mvcdemo.Models.ModelBinding
{
   public class ModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            //ModelType: Gets the model type represented by the current instance
            if (context.Metadata.ModelType == typeof(List<int>))
            {
               return new CommaSeparatedModelBinder();
            }
            else if(context.Metadata.ModelType == typeof(LoginModel))
            {
                return new LoginModelBinder();
            }
            return null;
        }
    }

}
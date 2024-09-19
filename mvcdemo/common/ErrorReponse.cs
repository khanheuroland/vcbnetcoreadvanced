using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcdemo.common
{
    public class ErrorReponse : IActionResult
    {
        public string Error { get; set; }
        public ErrorReponse(String Error)
        {
            this.Error = Error;
        }
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(new {status=400, message=Error});

            await objectResult.ExecuteResultAsync(context);
        }
    }
}
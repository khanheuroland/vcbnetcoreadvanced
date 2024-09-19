using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcdemo.common
{
    public class OkResponse : IActionResult
    {
        private readonly Object _result;
        private readonly string _message;

        public OkResponse(Object result, String message="")
        {
            _result = result;
            _message = message;
        }
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(new {status=200, message=_message, data=_result})
            {
                StatusCode = StatusCodes.Status200OK
            };

            await objectResult.ExecuteResultAsync(context);
        }
    }
}
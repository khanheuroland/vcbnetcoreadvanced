using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcdemo.common
{
    
    public class OkResponse<T>
    {
        public int status = 200;
        public string message;
        public T data;
        public OkResponse(T _data, String message="")
        {
            this.data = _data;
            this.message = message;
        }
    }
}
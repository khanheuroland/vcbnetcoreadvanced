using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcdemo.common;
using mvcdemo.common.Filters;
using mvcdemo.Models;

namespace mvcdemo.Controllers.Api
{
    public class DataController : ControllerBase
    {
        public IActionResult GetData()
        {
            List<VCBUser> lstUser = new List<VCBUser>();
            for(int i=0; i<1000000; i++)
            {
                lstUser.Add(new VCBUser(){Id=1, Name="Nguyen Xuan Hung", Department="Data"});
            }

            return new OkResponse(lstUser);
        }

        public IActionResult GetPerson()
        {
            VCBUser user = new VCBUser();
            user.Id = 1;
            user.Name = "Xuan Huy";
            user.Department = "Customer Support";

            return new ErrorReponse("This person is not available");
        }
    }
}
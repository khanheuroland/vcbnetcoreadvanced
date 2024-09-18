using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcdemo.common;
using mvcdemo.Models;

namespace mvcdemo.Controllers.Api
{
    public class DataController : ControllerBase
    {
        public IActionResult GetData()
        {
            List<VCBUser> lstUser = new List<VCBUser>();
            lstUser.Add(new VCBUser(){Id=1, Name="Nguyen Xuan Hung", Department="Data"});
            lstUser.Add(new VCBUser(){Id=2, Name="Nguyen Dat", Department="IT"});
            return new OkResponse<List<VCBUser>>(lstUser);
        }
    }
}
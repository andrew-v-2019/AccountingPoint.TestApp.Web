using System;
using System.Collections.Generic;
using System.Threading;
using AccountingPoint.TestApp.Web.Models;
using Microsoft.AspNetCore.Mvc;


namespace AccountingPoint.TestApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public Guid Get([FromQuery] RequestModel model)
        {
            Thread.Sleep(model.SecondsDelay * 1000);
            return Guid.NewGuid();
        }

    }
}

using System;
using AccountingPoint.TestApp.Web.core_2.Models;
using Microsoft.AspNetCore.Mvc;


namespace AccountingPoint.TestApp.Web.core_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public DataController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public Guid Get([FromQuery] RequestModel model)
        {
            var g = _applicationService.Execute(model);
            return g;
        }

    }
}

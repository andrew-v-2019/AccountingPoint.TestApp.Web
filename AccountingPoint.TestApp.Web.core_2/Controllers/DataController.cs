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


        /// <summary>
        /// Запрос к Backend
        /// </summary>
        /// <param name="model"> Идентификатор нажатой кнопки и количестов секунд для Thread.Sleep</param>
        /// <returns>Guid</returns>
        [HttpGet]
        public Guid Get([FromQuery] RequestModel model)
        {
            var g = _applicationService.Execute(model);
            return g;
        }

    }
}

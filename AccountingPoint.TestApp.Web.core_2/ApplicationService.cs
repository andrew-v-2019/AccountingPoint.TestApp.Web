using AccountingPoint.TestApp.Web.core_2.Models;
using System;
using System.Threading;

namespace AccountingPoint.TestApp.Web.core_2
{
    public interface IApplicationService
    {
        Guid Execute(RequestModel model);
    }

    public class ApplicationService : IApplicationService
    {
        /// <summary>
        /// Запрос к Backend
        /// </summary>
        /// <param name="model"> Выполняет ожидание в зависимости от параметра SecondsDelay</param>
        /// <returns>Guid</returns>
        public Guid Execute(RequestModel model)
        {
            Thread.Sleep(model.SecondsDelay * 1000);
            return Guid.NewGuid();
        }
    }
}

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
        public Guid Execute(RequestModel model)
        {
            Thread.Sleep(model.SecondsDelay * 1000);
            return Guid.NewGuid();
        }
    }
}

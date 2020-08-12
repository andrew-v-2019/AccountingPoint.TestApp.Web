using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AccountingPoint.TestApp.Web.core_2
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerFactory _loggerFactory;

        public LoggerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _loggerFactory = loggerFactory;

        }

        public async Task InvokeAsync(HttpContext context)
        {
            var logger = _loggerFactory.CreateLogger<LoggerMiddleware>();
            using (logger.BeginScope(this))
            {
                logger.LogInformation("BEGIN REQUEST");

                if (context.Request.Query.ContainsKey("ButtonId"))
                {
                    var buttonId = context.Request.Query["ButtonId"];
                    var secondsDelay = context.Request.Query["SecondsDelay"];
                    logger.LogInformation($"buttonId = {buttonId}; secondsDelay = {secondsDelay}");

                }
                await _next.Invoke(context);
                logger.LogInformation("END REQUEST");
            }
        }
    }
}

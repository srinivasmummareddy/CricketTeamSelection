using Core.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Api.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly IHostEnvironment _hostEnvironment;
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(IHostEnvironment hostEnvironment, 
            ILogger<ErrorController> logger)
        {
            _hostEnvironment = hostEnvironment;
            _logger = logger;
        }

        [Route("/Error")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult HandleError()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            Exception exception = context.Error;
            _logger.LogError("Exception", exception);

            return HandleExceptions(exception);
        }

        [NonAction]
        private IActionResult HandleExceptions(Exception exception)
        {
            if (exception is InvalidTeamSelectionException)
            {
                return UnprocessableEntity(new
                {
                    type = "Team selection criteria not on par",
                    detail = exception.Message,
                    status = StatusCodes.Status422UnprocessableEntity
                });
            }

            if (_hostEnvironment.IsDevelopment())
            {
                return Problem(
                    detail: exception.Message,
                    type: "Server Error",
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "Internal Server Error"
                );
            }

            return Problem(
                type: "Server Error",
                statusCode: StatusCodes.Status500InternalServerError,
                title: "Internal Server Error"
            );
        }
    }
}

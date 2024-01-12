using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BandBeacon.Core.ApiSupport
{
    public class ApiResponseFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult objectResult)
            {
                context.Result = new OkObjectResult(new ApiResponse<object>
                {
                    Data = objectResult.Value,
                    Success = true
                });
            }
        }
    }

}

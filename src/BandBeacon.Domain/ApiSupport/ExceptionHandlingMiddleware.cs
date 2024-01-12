using Microsoft.AspNetCore.Http;

namespace BandBeacon.Core.ApiSupport
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError; // set appropriate status code;

            return context.Response.WriteAsync(new ApiResponse<object>
            {
                Success = false,
                ErrorMessage = exception.Message
                // Populate additional fields as necessary
            }.ToString());
        }
    }

}

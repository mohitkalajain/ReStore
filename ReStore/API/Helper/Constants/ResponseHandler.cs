using Microsoft.AspNetCore.Mvc;

namespace API.Helper.Constants
{
    public static class ResponseHandler
    {
        public static IActionResult CreateResponse(ResponseVM response)
        {
            return new ObjectResult(response) { StatusCode = response.StatusCode };
        }
        public static IActionResult HandleException(Exception ex, ILogger logger)
        {
            logger.LogError(ex, "An unhandled exception occurred.");
            return CreateResponse(ResponseVM.InternalServerError(MessageConstants.Error));
        }
    }
}
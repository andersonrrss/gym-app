using GymApp.Domain.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class BaseController : ControllerBase
    {
        protected IActionResult Respond<T>(Result<T> result) =>
            result.IsSucess ? Ok(result.Value) : MapError(result.ErrorType, result.Error, result.ValidationErrors);

        protected IActionResult Respond(Result result) => 
            result.IsSucess ? Ok() : MapError(result.ErrorType, result.Error);

        private IActionResult MapError(
            ErrorType errorType,
            string? error,
            Dictionary<string, string[]>? validationErrors = null
        ) => errorType switch
        {
            ErrorType.Unauthorized => Unauthorized(new { message = error }),

            ErrorType.NotFound => NotFound(new { message = error }),

            ErrorType.InternalError => StatusCode(500, new { message = error }),

            ErrorType.Forbidden => StatusCode(403, new { message = error } ),

            ErrorType.Validation => validationErrors is not null
                ? ValidationProblem(new ValidationProblemDetails(validationErrors))
                : StatusCode(500, new { message = "Erro interno de validação" }),

            _ => BadRequest(new { message = error })
        };
    }
}

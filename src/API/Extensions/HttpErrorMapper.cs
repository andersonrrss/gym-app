using GymApp.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.API.Extensions;

public static class HttpErrorMapper
{
    public static IActionResult ToHttpError (
        this ControllerBase controller,
        ErrorType errorType,
        string? error,
        Dictionary<string, string[]>? validationErrors
    ) => errorType switch
    {
        ErrorType.Unauthorized => controller.Unauthorized(new { message = error }),

        ErrorType.NotFound => controller.NotFound(new { message = error }),

        ErrorType.InternalError => controller.StatusCode(500, new { message = error }),

        ErrorType.Validation => validationErrors is not null
            ? controller.ValidationProblem(new ValidationProblemDetails(validationErrors))
            : controller.StatusCode(500, new { message = "Erro interno de validação" }),

        _ => controller.BadRequest(new { message = error })
    };
}

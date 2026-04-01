using GymApp.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.API.Extensions;

public static class ResultExtensions
{
    public static IActionResult ToActionResult<T>(this Result<T> result, ControllerBase controller)
    {
        if(!result.IsSucess)
            return controller.ToHttpError(result.ErrorType, result.Error);
        return controller.Ok(result.Value);
    }

    public static IActionResult ToActionResult(this Result result, ControllerBase controller)
    {
        if(!result.IsSucess)
            return controller.ToHttpError(result.ErrorType, result.Error);
        return controller.Ok();
    }
}

using GymApp.Domain.Enums;

namespace GymApp.Domain.Common;

public class Result
{
    public bool IsSucess { get; init; } 
    public string? Error { get; init; }
    public ErrorType ErrorType { get; init; }

    public Result(bool isSucess,string? error, ErrorType errorType)
    {
        IsSucess = isSucess;
        Error = error;
        ErrorType = errorType;
    }

    public static Result Sucess() => new(true, null, ErrorType.None);

    public static Result Failure(string error, ErrorType errorType) => new(false, error, errorType);

    public static Result Unauthorized(string message = "Não autorizado") =>
        new(false, message, ErrorType.Unauthorized);

    public static Result Forbidden(string message = "Acesso negado") =>
        new(false, message, ErrorType.Forbidden);

    public static Result NotFound(string message = "Não encontrado") =>
        new(false, message, ErrorType.NotFound);

    public static Result InternalError(string message = "Erro interno") =>
        new(false, message, ErrorType.InternalError);

    public static Result Conflict(string message = "Dados conflitantes") =>
        new(false, message, ErrorType.Conflict);
}



namespace GymApp.Domain.Common;

public class Result<T>
{
    public bool IsSucess { get; } 
    public T? Value { get; }
    public string? Error { get; }
    public ValidationErrors? ValidationErrors { get; }
    public ErrorType ErrorType { get; }

    public Result(bool isSucess, T? value, string? error, ValidationErrors? validationErrors, ErrorType errorType)
    {
        IsSucess = isSucess;
        Value = value;
        Error = error;
        ValidationErrors = validationErrors;
        ErrorType = errorType;
    }

    public static Result<T> Success(T value) => 
        new(true, value, null, null, ErrorType.None);
        
    public static Result<T> Failure(string error, ErrorType errorType) => 
        new(false, default, error, null, errorType);

    public static Result<T> ValidationFailure(ValidationErrors errors) => 
        new (false, default, null, errors, ErrorType.Validation);

    public static Result<T> Unauthorized(string message = "Não autorizado") =>
        new(false, default, message, null, ErrorType.Unauthorized);

    public static Result<T> Forbidden(string message = "Acesso negado") =>
        new(false, default, message, null, ErrorType.Forbidden);

    public static Result<T> NotFound(string message = "Não encontrado") =>
        new(false, default, message, null, ErrorType.NotFound);

    public static Result<T> InternalError(string message = "Erro interno") =>
        new(false, default, message, null, ErrorType.InternalError);

    public static Result<T> Conflict(string message = "Dados conflitantes") =>
        new(false, default, message, null, ErrorType.Conflict);
}

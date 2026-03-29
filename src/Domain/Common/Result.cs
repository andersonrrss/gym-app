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
}

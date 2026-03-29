namespace GymApp.Domain.Common;

public class VoidResult
{
    public bool IsSucess { get; init; } 
    public string? Error { get; init; }
    public ErrorType ErrorType { get; init; }

    public VoidResult(bool isSucess,string? error, ErrorType errorType)
    {
        IsSucess = isSucess;
        Error = error;
        ErrorType = errorType;
    }

    public static VoidResult Sucess() => new(true, null, ErrorType.None);
    public static VoidResult Failure(string error, ErrorType errorType) => new(false, error, errorType);
}

namespace Chronofoil.Common;

public class ApiResult
{
    public ApiResult(ApiStatusCode statusCode = ApiStatusCode.Success)
    {
        StatusCode = statusCode;
    }
    
    public ApiStatusCode StatusCode { get; init; }
    public bool IsSuccess => StatusCode == ApiStatusCode.Success;

    public static ApiResult Success() => new();
    public static ApiResult Failure(ApiStatusCode statusCode = ApiStatusCode.UnknownError) => new(statusCode);
}

public class ApiResult<T> : ApiResult where T : class
{
    public ApiResult(T? data, ApiStatusCode statusCode = ApiStatusCode.Success)
    {
        Data = data;
        StatusCode = statusCode;
    }

    public T? Data { get; init; }

    public static ApiResult<T> Success(T data) => new(data);
    public new static ApiResult<T> Failure(ApiStatusCode statusCode = ApiStatusCode.UnknownError) => new(null, statusCode);
}
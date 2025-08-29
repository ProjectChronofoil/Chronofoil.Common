namespace Chronofoil.Common;

public enum ApiStatusCode
{
    Success = 0,
    UnknownError,
    AuthProviderAuthFailure,
    AuthProviderRefreshFailure,
    AuthInvalidTosVersion,
    UserExists,
    UserNotFound,
    UserRemoteTokenNotFound,
    UserTokenNotFound,
    CaptureNotFound,
    CaptureNotFoundForUser,
    CaptureNotValid,
    CaptureExists,
    CaptureUploadFailed,
    CaptureDeleteFailed,
    FormFileIsEmptyFile,
    FormFileNotValid,
    FormFileMetadataNotValid,
    OpcodeUnknownGameVersion,
    OpcodeCountInvalid,
    OpcodeInvalidKey,
    OpcodeMismatchWithKnown,
}

public static class ApiStatusCodeExtensions
{
    public static bool IsSuccess(this ApiStatusCode statusCode) => statusCode == ApiStatusCode.Success;

    public static int ToHttpStatusCode(this ApiStatusCode statusCode)
    {
        return statusCode switch
        {
            ApiStatusCode.Success => 200,
            ApiStatusCode.UnknownError => 500,
            ApiStatusCode.AuthProviderAuthFailure => 400,
            ApiStatusCode.AuthProviderRefreshFailure => 400,
            ApiStatusCode.AuthInvalidTosVersion => 400,
            ApiStatusCode.UserExists => 409,
            ApiStatusCode.UserNotFound => 404,
            ApiStatusCode.UserRemoteTokenNotFound => 404,
            ApiStatusCode.UserTokenNotFound => 404,
            ApiStatusCode.CaptureNotFound => 404,
            ApiStatusCode.CaptureNotFoundForUser => 404,
            ApiStatusCode.CaptureNotValid => 400,
            ApiStatusCode.CaptureExists => 409,
            ApiStatusCode.CaptureUploadFailed => 500,
            ApiStatusCode.CaptureDeleteFailed => 500,
            ApiStatusCode.FormFileIsEmptyFile => 400,
            ApiStatusCode.FormFileNotValid => 400,
            ApiStatusCode.FormFileMetadataNotValid => 400,
            ApiStatusCode.OpcodeUnknownGameVersion => 400,
            ApiStatusCode.OpcodeCountInvalid => 400,
            ApiStatusCode.OpcodeInvalidKey => 400,
            ApiStatusCode.OpcodeMismatchWithKnown => 400,
            _ => throw new ArgumentOutOfRangeException(nameof(statusCode), statusCode, null)
        };
    }
}
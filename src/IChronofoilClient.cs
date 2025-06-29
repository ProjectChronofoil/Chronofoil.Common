using Chronofoil.Common.Auth;
using Chronofoil.Common.Capture;
using Chronofoil.Common.Censor;
using Chronofoil.Common.Info;
using Refit;

namespace Chronofoil.Common;

/// <summary>
/// A combined Refit interface for all Chronofoil Web APIs.
/// </summary>
public interface IChronofoilClient
{
    // AuthController endpoints
    [Post($"{Routes.AuthV1}/register/{{provider}}")]
    Task<ApiResult<AccessTokenResponse>> Register(string provider, [Body] AuthRequest request);

    [Post($"{Routes.AuthV1}/login/{{provider}}")]
    Task<ApiResult<AccessTokenResponse>> Login(string provider, [Body] AuthRequest request);

    [Post($"{Routes.AuthV1}/token/refresh")]
    Task<ApiResult<AccessTokenResponse>> RefreshToken([Body] RefreshRequest request);

    [Post($"{Routes.AuthV1}/tos/accept")]
    Task<ApiResult> AcceptTos([Authorize] string token, [Query] int tosVersion);

    // CaptureController endpoints
    [Multipart]
    [Post($"{Routes.CaptureV1}/upload")]
    Task<ApiResult<CaptureUploadResponse>> UploadCapture(
        [Authorize] string token,
        [AliasAs("files")] StreamPart meta,
        [AliasAs("files")] StreamPart capture);

    [Post($"{Routes.CaptureV1}/delete")]
    Task<ApiResult> DeleteCapture([Authorize] string token, [Query] Guid captureId);

    [Get($"{Routes.CaptureV1}/list")]
    Task<ApiResult<CaptureListResponse>> GetCaptureList([Authorize] string token);

    // CensorController endpoints
    [Post($"{Routes.CensorV1}/found")]
    Task<ApiResult> FoundOpcodes(
        [Authorize] string token, 
        [Body] FoundOpcodesRequest request);

    [Get($"{Routes.CensorV1}/opcodes")]
    Task<ApiResult<CensoredOpcodesResponse>> GetOpcodes(
        [Authorize] string token, 
        [Query] string gameVersion);

    // InfoController endpoints
    [Get($"{Routes.InfoV1}/tos")]
    Task<ApiResult<TosResponse>> GetTos();

    [Get($"{Routes.InfoV1}/faq")]
    Task<ApiResult<FaqResponse>> GetFaq();
}
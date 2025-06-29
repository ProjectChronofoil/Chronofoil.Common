namespace Chronofoil.Common;

public class Routes
{
    public const string ApiRoot = "api";
    
    public const string ApiBaseV1 = $"/{ApiRoot}/v1";
    
    public const string AuthV1 = $"{ApiBaseV1}/auth";
    public const string CensorV1 = $"{ApiBaseV1}/censor";
    public const string InfoV1 = $"{ApiBaseV1}/info";
    public const string CaptureV1 = $"{ApiBaseV1}/capture";
}
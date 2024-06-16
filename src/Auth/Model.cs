// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global
// ReSharper disable CollectionNeverUpdated.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace Chronofoil.Common.Auth;

public class AuthRequest
{
    public string AuthorizationCode { get; set; }
}

public class RefreshRequest
{
    public string RefreshToken { get; set; }
}

public class AccessTokenResponse
{
    public string TokenType { get; } = "Bearer";
    public required string AccessToken { get; init; }
    public required string RefreshToken { get; init; }
    public required long ExpiresIn { get; init; } // seconds
}

public class AcceptTosRequest
{
    public int TosVersion { get; init; }
}
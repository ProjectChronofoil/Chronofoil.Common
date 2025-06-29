// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global
// ReSharper disable CollectionNeverUpdated.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace Chronofoil.Common.Censor;

public class FoundOpcodesRequest
{
    public string GameVersion { get; set; }
    public Dictionary<string, int> Opcodes { get; set; }
}

public class CensoredOpcodesResponse
{
    public string GameVersion { get; set; }
    public Dictionary<string, int> Opcodes { get; set; }
}
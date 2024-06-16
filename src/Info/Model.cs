// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global
// ReSharper disable CollectionNeverUpdated.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace Chronofoil.Common.Info;

public class TosResponse
{
    public int Version { get; set; }
    public DateTime EnactedDate { get; set; }
    public string Text { get; set; }
}

public class FaqEntry
{
    public string Question { get; init; }
    public string Answer { get; init; }
}

public class FaqResponse
{
    public List<FaqEntry> Entries { get; init; } = [];
}
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global
// ReSharper disable CollectionNeverUpdated.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace Chronofoil.Common.Capture;

public class CaptureUploadRequest
{
    public Guid CaptureId { get; init; }
    public DateTime MetricTime { get; init; }
    public bool MetricWhenEos { get; init; }
    public DateTime PublicTime { get; init; }
    public bool PublicWhenEos { get; init; }
}

public class CaptureUploadResponse
{
    public Guid CaptureId { get; init; }
    public DateTime MetricTime { get; init; }
    public bool MetricWhenEos { get; init; }
    public DateTime PublicTime { get; init; }
    public bool PublicWhenEos { get; init; }
}

public class CaptureDeletionRequest
{
    public Guid CaptureId { get; init; }
}

public class CaptureListElement
{
    public Guid CaptureId { get; init; }
    public DateTime StartTime { get; init; }
    public DateTime EndTime { get; init; }
    public DateTime MetricsTime { get; init; }
    public DateTime PublicTime { get; init; }
    public bool MetricsWhenEos { get; init; }
    public bool PublicWhenEos { get; init; }
}

public class CaptureListResponse
{
    public List<CaptureListElement> Captures { get; init; } = [];
}
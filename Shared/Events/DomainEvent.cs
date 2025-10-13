namespace MFO.Contracts.Shared.Events;

public abstract record DomainEvent
{
    public Guid EventId { get; init; } = Guid.NewGuid();
    public DateTime OccurredAtUtc { get; init; } = DateTime.UtcNow;
    public Guid CorrelationId { get; init; }
    public string EventType => GetType().Name;
}
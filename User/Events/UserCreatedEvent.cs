namespace MFO.Contracts.User.Events;

public sealed record UserCreatedEvent(
    Guid UserId,
    string Email,
    string FullName,
    DateTime CreatedAtUtc,
    Guid CorrelationId
);
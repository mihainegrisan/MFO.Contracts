using MFO.Contracts.Shared.Events;

namespace MFO.Contracts.User.Events;

public sealed record UserUpdatedEvent(
    Guid UserId,
    string Email,
    string FullName,
    DateTime UpdatedAtUtc
) : DomainEvent;
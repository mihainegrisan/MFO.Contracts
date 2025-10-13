using MFO.Contracts.Shared.Events;

namespace MFO.Contracts.User.Events;

public sealed record UserDeactivatedEvent(
    Guid UserId,
    string Email,
    DateTime DeactivatedAtUtc
) : DomainEvent;
using MFO.Contracts.Shared.Events;

namespace MFO.Contracts.User.Events;

public sealed record UserActivatedEvent(
    Guid UserId,
    string Email,
    DateTime ActivatedAtUtc
) : DomainEvent;
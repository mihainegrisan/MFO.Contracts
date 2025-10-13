using MFO.Contracts.Shared.Events;

namespace MFO.Contracts.User.Events;

public sealed record UserDeletedEvent(
    Guid UserId,
    string Email,
    DateTime DeletedAtUtc
) : DomainEvent;
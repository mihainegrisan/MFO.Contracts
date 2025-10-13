using MFO.Contracts.Shared.Events;

namespace MFO.Contracts.User.Events;

public sealed record UserPasswordChangedEvent(
    Guid UserId,
    DateTime ChangedAtUtc
) : DomainEvent;
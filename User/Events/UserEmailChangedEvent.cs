using MFO.Contracts.Shared.Events;

namespace MFO.Contracts.User.Events;

public sealed record UserEmailChangedEvent(
    Guid UserId,
    string OldEmail,
    string NewEmail,
    string FullName,
    DateTime UpdatedAtUtc
) : DomainEvent;
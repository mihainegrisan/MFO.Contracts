using MFO.Contracts.Shared.Events;

namespace MFO.Contracts.User.Events;

public sealed record UserRegisteredEvent(
    Guid UserId,
    string Email,
    string FullName,
    DateTime RegisteredAtUtc
) : DomainEvent;
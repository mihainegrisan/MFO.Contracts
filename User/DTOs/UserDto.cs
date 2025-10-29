namespace MFO.Contracts.User.DTOs;

public sealed record UserDto
{
    public required Guid UserId { get; init; }

    public required string FirstName { get; init; }

    public required string LastName { get; init; }

    public required string Email { get; init; }

    public required DateTime CreatedAt { get; init; }

    public required bool IsActive { get; init; }

    public string FullName => $"{FirstName} {LastName}".Trim();
}
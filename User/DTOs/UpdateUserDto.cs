namespace MFO.Contracts.User.DTOs;

public sealed record UpdateUserDto
{
    public required Guid UserId { get; init; }

    public string? FirstName { get; init; }

    public string? LastName { get; init; }

    public string? Email { get; init; }

    public string? Password { get; init; }

    public bool? IsActive { get; init; }
}
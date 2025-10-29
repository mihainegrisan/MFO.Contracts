namespace MFO.Contracts.User.DTOs;

public sealed record GetUserByEmailDto
{
    public required string Email { get; init; }
}
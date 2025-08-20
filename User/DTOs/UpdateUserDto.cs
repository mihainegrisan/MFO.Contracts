namespace MFO.Contracts.User.DTOs;

public sealed record UpdateUserDto(Guid Id, string FirstName, string LastName, string Email, string Password, bool IsActive);
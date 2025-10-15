namespace MFO.Contracts.User.DTOs;

public sealed record UpdateUserDto(string FirstName, string LastName, string Email, string Password, bool IsActive);
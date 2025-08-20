namespace MFO.Contracts.User.DTOs;

public sealed record CreateUserDto(string FirstName, string LastName, string Email, string Password);


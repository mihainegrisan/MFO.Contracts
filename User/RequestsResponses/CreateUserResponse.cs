using MFO.Contracts.User.DTOs;

namespace MFO.Contracts.User.RequestsResponses;

public sealed record CreateUserResponse(GetUserDto User);
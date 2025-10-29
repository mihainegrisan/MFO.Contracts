namespace MFO.Contracts.Catalog.DTOs.Company;

public sealed record CompanyDto
{
    public required Guid CompanyId { get; init; }

    public required string Name { get; init; }

    public required string Code { get; init; }

    public string? Description { get; init; }

    public required bool IsActive { get; init; }
}
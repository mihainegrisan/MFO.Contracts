namespace MFO.Contracts.Catalog.DTOs.Company;

public sealed record UpdateCompanyDto
{
    public required Guid CompanyId { get; init; }

    public string? Name { get; init; }

    public string? Code { get; init; }

    public string? Description { get; init; }
}
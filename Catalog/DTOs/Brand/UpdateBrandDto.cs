namespace MFO.Contracts.Catalog.DTOs.Brand;

public sealed record UpdateBrandDto
{
    public required Guid BrandId { get; init; }

    public string? Name { get; init; }

    public string? Code { get; init; }

    public string? Description { get; init; }
}
namespace MFO.Contracts.Catalog.DTOs.Brand;

public sealed record CreateBrandDto
{
    public required string Name { get; init; }

    public required string Code { get; init; }

    public string? Description { get; init; }
}
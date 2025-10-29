namespace MFO.Contracts.Catalog.DTOs.Category;

public sealed record CreateCategoryDto
{
    public required string Name { get; init; }

    public required string Code { get; init; }
}
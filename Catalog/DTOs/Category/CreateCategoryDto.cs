namespace MFO.Contracts.Catalog.DTOs.Category;

public sealed record CreateCategoryDto
{
    public required string Name { get; set; }

    public required string Code { get; set; }
}
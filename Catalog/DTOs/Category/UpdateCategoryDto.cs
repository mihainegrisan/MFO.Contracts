namespace MFO.Contracts.Catalog.DTOs.Category;

public sealed record UpdateCategoryDto
{
    public required Guid CategoryId { get; set; }

    public required string Name { get; set; }

    public required string Code { get; set; }
}

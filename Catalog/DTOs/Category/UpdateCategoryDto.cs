namespace MFO.Contracts.Catalog.DTOs.Category;

public sealed record UpdateCategoryDto
{
    public required Guid CategoryId { get; init; }

    public string? Name { get; init; }

    public string? Code { get; init; }
}

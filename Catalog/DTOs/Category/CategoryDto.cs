namespace MFO.Contracts.Catalog.DTOs.Category;

public sealed record CategoryDto
{
    public required Guid CategoryId { get; init; }

    public required string Name { get; init; }

    public required string Code { get; init; }
}

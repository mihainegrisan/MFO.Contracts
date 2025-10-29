namespace MFO.Contracts.Catalog.DTOs.Product;

public sealed record UpdateProductDto
{
    public required Guid ProductId { get; init; }

    public string? Name { get; init; }

    public string? Description { get; init; }

    public decimal? Price { get; init; }

    public Guid? CompanyId { get; init; }

    public Guid? CategoryId { get; init; }

    public Guid? BrandId { get; init; }
}


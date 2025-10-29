using MFO.Contracts.Catalog.DTOs.Brand;
using MFO.Contracts.Catalog.DTOs.Category;
using MFO.Contracts.Catalog.DTOs.Company;

namespace MFO.Contracts.Catalog.DTOs.Product;

public sealed record ProductDto
{
    public required Guid ProductId { get; init; }

    public required string Sku { get; set; }

    public required string Name { get; init; }

    public string? Description { get; init; }

    public required decimal Price { get; init; }

    public required bool IsActive { get; init; }


    public CompanyDto? Company { get; init; }

    public CategoryDto? Category { get; init; }

    public BrandDto? Brand { get; init; }
}
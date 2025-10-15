﻿using MFO.Contracts.Catalog.DTOs.Brand;
using MFO.Contracts.Catalog.DTOs.Category;
using MFO.Contracts.Catalog.DTOs.Company;

namespace MFO.Contracts.Catalog.DTOs.Product;

public sealed record GetProductDto
{
    public required Guid ProductId { get; init; }

    public string SKU { get; set; } = null!;

    public required string Name { get; init; }

    public string? Description { get; init; }

    public required decimal Price { get; init; }

    public bool IsActive { get; init; }

    // public Guid CompanyId { get; init; }

    public GetCompanyDto Company { get; init; } = null!;

    // public Guid CategoryId { get; init; }

    public GetCategoryDto Category { get; init; } = null!;

    // public Guid BrandId { get; init; }

    public GetBrandDto Brand { get; init; } = null!;
}
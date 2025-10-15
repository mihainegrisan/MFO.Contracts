﻿namespace MFO.CatalogService.Application.DTOs.Product;

public sealed record UpdateProductDto
{
    public required Guid ProductId { get; set; }

    public required string Name { get; init; }

    public string? Description { get; init; }

    public required decimal Price { get; init; }

    public required Guid CategoryId { get; init; }

    public required Guid BrandId { get; init; }
}


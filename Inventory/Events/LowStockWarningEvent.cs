using MFO.Contracts.Shared.Events;

namespace MFO.Contracts.Inventory.Events;

public record LowStockWarningEvent(
    Guid ProductId,
    string Sku,
    int CurrentStockLevel,
    int LowStockThreshold
) : DomainEvent;

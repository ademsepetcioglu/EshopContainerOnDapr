namespace Order.Application.IntegrationEvents;

public record OrderStockConfirmedIntegrationEvent(
Guid OrderId)
: IntegrationEvent;

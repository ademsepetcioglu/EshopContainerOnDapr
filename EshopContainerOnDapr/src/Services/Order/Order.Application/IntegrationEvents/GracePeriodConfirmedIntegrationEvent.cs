namespace Order.Application.IntegrationEvents;

public record GracePeriodConfirmedIntegrationEvent(int OrderId) : IntegrationEvent;

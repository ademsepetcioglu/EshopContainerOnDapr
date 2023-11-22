namespace Order.Application.IntegrationEvents;

public record OrderPaymentFailedIntegrationEvent(Guid OrderId) : IntegrationEvent;

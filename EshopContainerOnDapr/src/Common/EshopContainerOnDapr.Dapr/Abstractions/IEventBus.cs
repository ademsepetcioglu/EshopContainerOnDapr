namespace EshopContainerOnDapr.Dapr.Abstractions;

public interface IEventBus
{
    Task PublishAsync(IntegrationEvent integrationEvent);
}

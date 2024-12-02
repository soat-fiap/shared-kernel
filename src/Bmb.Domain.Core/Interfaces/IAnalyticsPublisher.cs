using Bmb.Domain.Core.Events;

namespace Bmb.Domain.Core.Interfaces;

public interface IAnalyticsPublisher
{
    Task PublishAsync<T>(DomainEvent<T> @event);
}

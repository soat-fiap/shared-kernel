using Bmb.Domain.Core.Events.Integration;
using Bmb.Domain.Core.Events.Notifications;

namespace Bmb.Domain.Core.Events;

public interface IDispatcher
{
    Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : IBmbNotification;
    
    Task PublishIntegrationAsync<T>(T @event, CancellationToken cancellationToken = default) where T : IBmbIntegrationEvent;
}
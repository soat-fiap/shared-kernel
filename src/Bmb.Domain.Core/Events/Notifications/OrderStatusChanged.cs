using Bmb.Domain.Core.ValueObjects;

namespace Bmb.Domain.Core.Events.Notifications;

/// <summary>
/// Order status changed event
/// </summary>
public class OrderStatusChanged(Guid orderId, OrderStatus status) : IBmbNotification
{
    /// <summary>
    /// Order ID
    /// </summary>
    public Guid OrderId { get; init; } = orderId;

    /// <summary>
    /// New order Status
    /// </summary>
    public OrderStatus Status { get; init; } = status;
}
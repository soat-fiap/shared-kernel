using Bmb.Domain.Core.ValueObjects;

namespace Bmb.Domain.Core.Events.Notifications;

/// <summary>
/// Order payment ID confirmed event
/// </summary>
public class OrderPaymentConfirmed(PaymentId paymentId, Guid orderId) : IBmbNotification
{

    /// <summary>
    /// Payment Id.
    /// </summary>
    public PaymentId PaymentId { get; init; } = paymentId;

    /// <summary>
    /// Order Id.
    /// </summary>
    public Guid OrderId { get; init; } = orderId;
}
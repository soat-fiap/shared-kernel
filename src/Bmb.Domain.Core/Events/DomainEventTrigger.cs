using Bmb.Domain.Core.Entities;
using Bmb.Domain.Core.Events.Notifications;
using Bmb.Domain.Core.ValueObjects;

namespace Bmb.Domain.Core.Events;

public static class DomainEventTrigger
{
    public static event EventHandler<ProductCreated>? ProductCreated;
    public static event EventHandler<ProductDeleted>? ProductDeleted;
    public static event EventHandler<ProductUpdated>? ProductUpdated;
    public static event EventHandler<OrderStatusChanged>? OrderStatusChanged;
    public static event EventHandler<CustomerRegistered>? CustomerRegistered;
    public static event EventHandler<PaymentCreated>? PaymentCreated;

    internal static void RaiseProductCreated(ProductCreated e)
    {
        ProductCreated?.Invoke(null, e);
    }

    internal static void RaiseProductDeleted(Guid productId)
    {
        ProductDeleted?.Invoke(null, new ProductDeleted(productId));
    }

    internal static void RaiseProductUpdated(ProductUpdated e)
    {
        ProductUpdated?.Invoke(null, e);
    }

    internal static void RaiseOrderStatusChanged(Guid orderId, OrderStatus oldStatus, OrderStatus newStatus)
    {
        OrderStatusChanged?.Invoke(null, new OrderStatusChanged((orderId, oldStatus, newStatus)));
    }

    internal static void RaiseCustomerRegistered(CustomerRegistered e)
    {
        CustomerRegistered?.Invoke(null, e);
    }

    internal static void RaisePaymentCreated(PaymentCreated e)
    {
        PaymentCreated?.Invoke(null, e);
    }
}

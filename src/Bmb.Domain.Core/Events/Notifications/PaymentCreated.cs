namespace Bmb.Domain.Core.Events.Notifications;

/// <summary>
/// Payment created event
/// </summary>
public record PaymentCreated(Guid PaymentId, Guid OrderId) : IBmbNotification;
namespace Bmb.Domain.Core.ValueObjects;

/// <summary>
/// Orders statuses
/// </summary>
public enum OrderStatus
{
    PaymentPending = 0,
    Received = 1,
    InPreparation = 2,
    Ready = 3,
    Completed = 4
}

using Bmb.Domain.Core.ValueObjects;

namespace Bmb.Domain.Core.Events.Integration;

/// <summary>
/// Order created (checkout) event
/// </summary>
public class OrderCreated : IBmbIntegrationEvent
{
    public Guid Id { get; set; }
    public CustomerReplicaDto? Customer { get; set; }
    public List<OrderItemReplicaDto> Items { get; set; }
    public OrderStatus Status { get; set; }
    public string OrderTrackingCode { get; set; } = null!;
    public PaymentId PaymentId { get; set; } = null!;
    public decimal Total { get; set; }
    
    public OrderCreated(Guid id, CustomerReplicaDto? customer, List<OrderItemReplicaDto> items, OrderStatus status,
        string orderTrackingCode, PaymentId paymentId, decimal total)
    {
        Id = id;
        Customer = customer;
        Items = items;
        Status = status;
        OrderTrackingCode = orderTrackingCode;
        PaymentId = paymentId;
        Total = total;
    }

    public record CustomerReplicaDto(Guid Id, string Cpf, string Name, string Email);

    public record OrderItemReplicaDto(Guid Id, Guid OrderId, string ProductName, decimal UnitPrice, int Quantity);
}
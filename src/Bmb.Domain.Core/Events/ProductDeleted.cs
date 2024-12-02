namespace Bmb.Domain.Core.Events;

/// <summary>
/// Product deleted event
/// </summary>
/// <param name="payload"></param>
public class ProductDeleted(Guid payload) : DomainEvent<Guid>(payload);

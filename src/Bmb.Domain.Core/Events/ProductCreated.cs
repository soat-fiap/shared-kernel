using Bmb.Domain.Core.Entities;

namespace Bmb.Domain.Core.Events;

/// <summary>
/// Product created event
/// </summary>
/// <param name="payload"></param>
public class ProductCreated(Product payload) : DomainEvent<Product>(payload);

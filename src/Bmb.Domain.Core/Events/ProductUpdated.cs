using Bmb.Domain.Core.Entities;

namespace Bmb.Domain.Core.Events;

/// <summary>
/// Product updated event
/// </summary>
/// <param name="payload"></param>
public class ProductUpdated((Product oldProduct, Product newProduct) payload)
    : DomainEvent<(Product oldProduct, Product newProduct)>(payload);

using Customer = Bmb.Domain.Core.Entities.Customer;

namespace Bmb.Domain.Core.Events;

/// <summary>
/// Customer registered event
/// </summary>
/// <param name="payload"></param>
public class CustomerRegistered(Customer payload) : DomainEvent<Customer>(payload);

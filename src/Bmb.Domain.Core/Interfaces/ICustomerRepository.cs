using Customer = Bmb.Domain.Core.Entities.Customer;

namespace Bmb.Domain.Core.Interfaces;

public interface ICustomerRepository
{
    Task<Customer?> FindByCpfAsync(string cpf);

    Task<Customer> CreateAsync(Customer customer);

    Task<Customer?> FindByIdAsync(Guid id);
}

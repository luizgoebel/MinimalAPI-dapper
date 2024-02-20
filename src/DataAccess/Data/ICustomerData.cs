using DataAccess.Models;

namespace DataAccess.Data;

public interface ICustomerData
{
    Task DeleteCustomer(int id);
    Task<Customer?> GetCustomer(int id);
    Task<IEnumerable<Customer>> GetCustomers();
    Task InsertCustomer(Customer user);
    Task UpdateCustomer(Customer user);
}
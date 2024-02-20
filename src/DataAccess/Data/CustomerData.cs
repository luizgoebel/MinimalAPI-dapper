using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class CustomerData : ICustomerData
{
    private readonly ISqlDataAccess _dataAccess;

    public CustomerData(ISqlDataAccess sqlDataAccess)
    {
        _dataAccess = sqlDataAccess;
    }

    public async Task<IEnumerable<Customer>> GetCustomers()
        => await _dataAccess.LoadData<Customer, dynamic>("dbo.spCustomer_GetAll", new { });

    public async Task<Customer?> GetCustomer(int id)
    {
        IEnumerable<Customer> customers = await _dataAccess.LoadData<Customer, dynamic>("dbo.spCustomer_Get", new { Id = id });
        return customers.FirstOrDefault();
    }
    public async Task InsertCustomer(Customer user) =>
            await _dataAccess.SaveData("dbo.spCustomer_Insert", new { user.FirstName, user.LastName });

    public async Task UpdateCustomer(Customer user) =>
         await _dataAccess.SaveData("dbo.spCustomer_Update", user);

    public async Task DeleteCustomer(int id) =>
        await _dataAccess.SaveData("dbo.spCustomer_Delete", new { Id = id });
}

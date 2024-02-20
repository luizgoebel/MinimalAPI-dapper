using DataAccess.Data;
using DataAccess.Models;

namespace MinimalAPI_dapper;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        app.MapGet("/Custumers", GetCustomers);
        app.MapGet("/Custumers/{id}", GetCustomer);
        app.MapPost("/Custumers", InsertCustomer);
        app.MapPut("/Custumers", UpdateCustomer);
        app.MapDelete("/Custumers", DeleteCustomer);
    }

    private static async Task<IResult> GetCustomers(ICustomerData data)
    {
        try
        {
            return Results.Ok(await data.GetCustomers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> GetCustomer(int id, ICustomerData data)
    {
        try
        {
            Customer Costumer = await data.GetCustomer(id);
            return Results.Ok(Costumer is not null ? Costumer : Results.NotFound());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> InsertCustomer(Customer customer, ICustomerData data)
    {
        try
        {
            await data.InsertCustomer(customer);
            return Results.Ok("Cliente foi inserido com sucesso!");
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> DeleteCustomer(int id, ICustomerData data)
    {
        try
        {
            await data.DeleteCustomer(id);
            return Results.Ok("Cliente foi deletado com sucesso!");
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> UpdateCustomer(Customer customer, ICustomerData data)
    {
        try
        {
            await data.UpdateCustomer(customer);
            return Results.Ok("Cliente foi atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
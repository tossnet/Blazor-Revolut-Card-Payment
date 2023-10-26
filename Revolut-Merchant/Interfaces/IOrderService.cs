namespace Revolut_Merchant.Interfaces;

using Revolut_Merchant.Models;

public interface IOrderService
{
    public Task<OrderCreated> CreateOrder(HttpClient client, Order order, string SecretAPIKey);
}

namespace Revolut_Merchant.Services;

using Revolut_Merchant.Interfaces;
using Revolut_Merchant.Models;
using System.Text.Json;

public sealed class OrderService : ServiceBase,
                                   IOrderService
{
    public async Task<OrderCreated> CreateOrder(HttpClient client, Order order, string SecretAPIKey)
    {
        if (string.IsNullOrWhiteSpace(SecretAPIKey))
            return null;


        var request = new HttpRequestMessage(HttpMethod.Post, "https://sandbox-merchant.revolut.com/api/orders");
        request.Headers.Add("Revolut-Api-Version", "2023-10-23");
        request.Headers.Add("Authorization", $"Bearer {SecretAPIKey}");

        request.Content = Serialize(order);

        HttpResponseMessage response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();

        if (response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync();

           return JsonSerializer.Deserialize<OrderCreated>( responseBody);
        }

        return null; // TODO $"The request failed with status code: {response.StatusCode}";
        
    }
}

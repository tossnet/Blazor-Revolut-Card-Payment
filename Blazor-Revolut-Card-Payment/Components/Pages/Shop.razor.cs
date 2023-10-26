using Microsoft.AspNetCore.Components;
using Revolut_Merchant.Interfaces;
using Revolut_Merchant.Models;

namespace Blazor_Revolut_Card_Payment.Components.Pages;


public partial class Shop
{
    private string SecretAPIKey = "";

    [Inject]
    public  HttpClient client { get; set; }

	[Inject]
	private IOrderService orderService { get; set; }

    private string responseRev = "";


	private async Task CreateOrderClick()
	{
		if (string.IsNullOrWhiteSpace(SecretAPIKey))
			return;

        Order order = new()
        {
            Amount = 2,
            Currency = "EUR"
        };

        OrderCreated orderCreated = await orderService.CreateOrder(client, order, SecretAPIKey);

		responseRev = orderCreated.State.ToString();
	}
}
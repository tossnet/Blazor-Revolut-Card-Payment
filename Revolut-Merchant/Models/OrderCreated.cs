namespace Revolut_Merchant.Models;

using System.Text.Json.Serialization;

public  class OrderCreated
{
	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("token")]
	public string Token { get; set; }

	[JsonPropertyName("type")]
	public string Type { get; set; }

	[JsonPropertyName("state")]
	public string State { get; set; }

	[JsonPropertyName("created_at")]
	public DateTime Created_at { get; set; }

	[JsonPropertyName("updated_at")]
	public DateTime Updated_at { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("amount")]
	public int Amount { get; set; }

	[JsonPropertyName("currency")]
	public string Currency { get; set; }

	[JsonPropertyName("outstanding_amount")]
	public int Outstanding_amount { get; set; }

	[JsonPropertyName("customer")]
	public Customer Customer { get; set; }

	[JsonPropertyName("capture_mode")]
	public string Capture_mode { get; set; }

	[JsonPropertyName("checkout_url")]
	public string Checkout_url { get; set; }

	[JsonPropertyName("shipping_address")]
	public ShippingAddress Shipping_address { get; set; }

    /*
     

string cancel_authorised_after

integer refunded_amount

string settlement_currency

array payments

uuid location_id

object metadata

object industry_data

object merchant_order_data

object upcoming_payment_data

     */
}

namespace Revolut_Merchant.Models;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Order
{
	[Required]
	[JsonPropertyName("amount")]
	public int Amount { get; set; }

	[Required, JsonPropertyName("currency")]
	public string Currency { get; set; }

	[JsonPropertyName("capture_mode")]
	public string Capture_mode { get; set; }

	[JsonPropertyName("cancel_authorised_after")]
	public string Cancel_authorised_after { get; set; }

	[JsonPropertyName("customer")]
	public Customer Customer { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("shipping_address")]
	public ShippingAddress Shipping_address { get; set; }

	[JsonPropertyName("enforce_challenge")]
	public string Enforce_challenge { get; set; }

	//public Metadata Metadata { get; set; }

	[JsonPropertyName("merchant_order_data")]
	public MerchantOrderData Merchant_order_data { get; set; }

}

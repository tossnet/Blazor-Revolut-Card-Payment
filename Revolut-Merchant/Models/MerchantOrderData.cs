namespace Revolut_Merchant.Models;

using System.Text.Json.Serialization;

public class MerchantOrderData
{
	[JsonPropertyName("reference")]
	public string Reference { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }
}

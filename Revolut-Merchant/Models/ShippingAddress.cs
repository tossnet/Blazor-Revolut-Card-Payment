namespace Revolut_Merchant.Models;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class ShippingAddress
{
	[JsonPropertyName("street_line_1")]
	public string Street_line_1 { get; set; }

	[JsonPropertyName("street_line_2")]
	public string Street_line_2 { get; set; }

	[JsonPropertyName("region")]
	public string Region { get; set; }

	[JsonPropertyName("city")]
	public string City { get; set; }

	[Required]
	[JsonPropertyName("country_code")]
	public string Country_code { get; set; }

	[Required]
	[JsonPropertyName("postcode")]
	public string Postcode { get; set; }
}

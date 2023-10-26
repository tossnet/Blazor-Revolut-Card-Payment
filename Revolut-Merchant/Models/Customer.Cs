namespace Revolut_Merchant.Models;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Customer
{
	[Required]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("full_name")]
	public string Full_name { get; set; }

	[JsonPropertyName("phone")]
	public string Phone { get; set; }

	[Required]
	[JsonPropertyName("email")]
	public string Email { get; set; }
}

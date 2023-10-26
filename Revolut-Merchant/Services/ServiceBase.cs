namespace Revolut_Merchant.Services;

using System.Text.Json.Serialization;
using System.Text.Json;


public abstract class ServiceBase
{
    internal StringContent Serialize(object requestContent)
    {
        JsonSerializerOptions options = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        string json = JsonSerializer.Serialize(requestContent, options);
        return new StringContent(json, System.Text.Encoding.UTF8, "application/json");
    }

    internal object Deserialize<TValue>(string json)
    {
        JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        return JsonSerializer.Deserialize<TValue>(json, options);
    }
}

using System.Text.Json.Serialization;

namespace RefreshApiClient;

// The class which represents every api/v3 resposne
public abstract class RefreshResponse<TApiData>
{
    [JsonPropertyName("success")] public bool Success { get; set; }

    [JsonPropertyName("data")] public TApiData? Data { get; set; }
}
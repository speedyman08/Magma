using System.Text.Json.Serialization;

namespace RefreshApiClient;

// The class which represents every api/v3 resposne
public abstract class RefreshResponse<T>
{
    [JsonPropertyName("success")] public bool Success { get; set; }

    [JsonPropertyName("data")] public T Data { get; set; }
}
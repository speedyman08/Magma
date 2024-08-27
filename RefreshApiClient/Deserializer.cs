using System.Text.Json;

namespace RefreshApiClient;

public class Deserializer<T>
{
    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };

    public T? Deserialize(string json) => JsonSerializer.Deserialize<T>(json, _options);
}
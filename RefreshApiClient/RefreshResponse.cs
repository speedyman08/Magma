using System.Text.Json.Serialization;

namespace RefreshApiClient;

// The class which represents every api/v3 resposne
public abstract class RefreshResponse<TData>
{
    // ReSharper disable once InconsistentNaming
    private static readonly Lazy<Deserializer<TData>> _deserializer = new(() => new Deserializer<TData>());

    [JsonIgnore]
    public static Deserializer<TData> Json => _deserializer.Value;
    
    [JsonPropertyName("success")] 
    public bool Success { get; set; }

    [JsonPropertyName("data")] 
    public TData? Data { get; set; }
}
namespace RefreshApiClient;

public class RefreshClientService
{
    private readonly HttpClient _httpClient = new();
    private const string ApiPath = "/api/v3/";
    
    public RefreshClientService(Uri refreshUri)
    {
        _httpClient.BaseAddress = refreshUri;
    }

    public async Task<StatisticsResponse?> GetStatistics()
    {
        var response = await _httpClient.GetAsync(ApiPath + "statistics");
        response.EnsureSuccessStatusCode();
        
        return RefreshResponse<StatisticsResponse>.Json.Deserialize(
            await response.Content.ReadAsStringAsync()
        );
    }
}
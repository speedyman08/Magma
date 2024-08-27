using System.Text.Json.Serialization;

namespace RefreshApiClient;

public class StatisticsData
{
    
    public int TotalLevels { get; init; }
    public int TotalUsers { get; init; }
    public int ActiveUsers { get; init; }
    public int TotalPhotos { get; init; }
    public int TotalEvents { get; init; }
    public int CurrentRoomCount { get; init; }
    public int CurrentIngamePlayersCount { get; init; }
    public RequestStatistics RequestStatistics { get; init; } = new RequestStatistics(); 
}

public class RequestStatistics
{
    public int TotalRequests { get; init; }
    public int ApiRequests { get; init; }
    public int GameRequests { get; init; }
}
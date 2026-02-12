using Apple_Music_Dashboard.Data;
using Apple_Music_Dashboard.Models;

namespace Apple_Music_Dashboard.Services;

public class AnalyticsService
{
    public ListeningSummary GetOverallSummary()
    {
        var plays = InMemoryDataStore.PlayEvents;

        var totalSeconds = plays.Sum(p => p.DurationSeconds);

        return new ListeningSummary
        {
            TotalPlays = plays.Count,
            TotalMinutes = totalSeconds / 60
        };
    }
}

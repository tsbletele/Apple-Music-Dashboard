using Apple_Music_Dashboard.Data;
using Apple_Music_Dashboard.Models;

namespace Apple_Music_Dashboard.Services;

public class WrappedService
{
    public WrappedSummary GetWeeklyWrapped()
    {
        var end = DateTime.UtcNow;
        var start = end.AddDays(-7);

        var plays = InMemoryDataStore.PlayEvents
            .Where(p => p.PlayedAt >= start && p.PlayedAt <= end)
            .ToList();

        return new WrappedSummary
        {
            PeriodStart = start,
            PeriodEnd = end,
            TotalPlays = plays.Count,
            TotalMinutesListened = plays.Sum(p => p.DurationSeconds) / 60,
            TopTracks = plays
                .GroupBy(p => p.TrackName)
                .Select(g => new TopItem
                {
                    Name = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(t => t.Count)
                .Take(5)
                .ToList(),
            TopArtists = plays
                .GroupBy(p => p.ArtistName)
                .Select(g => new TopItem
                {
                    Name = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(a => a.Count)
                .Take(5)
                .ToList()
        };
    }
}

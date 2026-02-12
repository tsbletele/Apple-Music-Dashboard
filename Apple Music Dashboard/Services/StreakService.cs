using Apple_Music_Dashboard.Data;
using Apple_Music_Dashboard.Models;

namespace Apple_Music_Dashboard.Services;

public class StreakService
{
    public StreakStats GetStreakStats()
    {
        var playDates = InMemoryDataStore.PlayEvents
            .Select(p => p.PlayedAt.Date)
            .Distinct()
            .OrderByDescending(d => d)
            .ToList();

        if (!playDates.Any()) // No play events, return empty stats 
        {
            return new StreakStats();
        }

        int currentStreak = 1;
        int longestStreak = 1;

        for (int i = 1; i < playDates.Count; i++) // Check if current date is exactly one day before the previous date
        {
            if ((playDates[i - 1] - playDates[i]).Days == 1) // If the current date is exactly one day before the previous date, we are in a streak
            {
                currentStreak++;
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
            else
            {
                currentStreak = 1;
            }
        }

        return new StreakStats
        {
            CurrentStreak = currentStreak,
            LongestStreak = longestStreak,
            LastListenedDate = playDates.First()
        };
    }
}

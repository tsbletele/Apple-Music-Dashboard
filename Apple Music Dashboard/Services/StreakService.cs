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

        if (!playDates.Any())
        {
            return new StreakStats();
        }

        int currentStreak = 1;
        int longestStreak = 1;

        for (int i = 1; i < playDates.Count; i++)
        {
            if ((playDates[i - 1] - playDates[i]).Days == 1)
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

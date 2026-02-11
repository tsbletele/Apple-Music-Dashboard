namespace Apple_Music_Dashboard.Models;

public class StreakStats
{
    public int CurrentStreak { get; set; }
    public int LongestStreak { get; set; }
    public DateTime? LastListenedDate { get; set; }
}

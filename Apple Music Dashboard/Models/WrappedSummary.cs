namespace Apple_Music_Dashboard.Models;

public class WrappedSummary
{
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }

    public int TotalPlays { get; set; }
    public int TotalMinutesListened { get; set; }

    public List<TopItem> TopTracks { get; set; } = [];
    public List<TopItem> TopArtists { get; set; } = [];
}

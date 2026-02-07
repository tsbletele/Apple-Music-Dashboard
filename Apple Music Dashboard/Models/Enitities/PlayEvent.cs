namespace Apple_Music_Dashboard.Models.Enitities
{
    public class PlayEvent
    {
        public int Id { get; set; }
        public string TrackName { get; set; } = "";
        public string ArtistName { get; set; } = "";
        public string AlbumName { get; set; } = "";
        public DateTime PlayedAt { get; set; }
        public int DurationSeconds { get; set; }
    }

}

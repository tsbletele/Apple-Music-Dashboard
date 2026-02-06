namespace Apple_Music_Dashboard.Models.Enitities
{
    public class Song
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public Guid ArtistId { get; set; }
        public string Genre { get; set; }
        public int DurationSeconds { get; set; }
    }

}

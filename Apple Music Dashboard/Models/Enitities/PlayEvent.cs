namespace Apple_Music_Dashboard.Models.Enitities
{
    public class PlayEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public Guid SongId { get; set; }
        public DateTime PlayedAt { get; set; }
        public int DurationSeconds { get; set; }
    }

}

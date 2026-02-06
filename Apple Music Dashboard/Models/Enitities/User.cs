namespace Apple_Music_Dashboard.Models.Enitities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string DisplayName { get; set; } = "You";
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
    }

}

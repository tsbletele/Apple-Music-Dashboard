namespace Apple_Music_Dashboard.Models.Enitities
{
    public class Artist
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Genre { get; set; }
    }

}

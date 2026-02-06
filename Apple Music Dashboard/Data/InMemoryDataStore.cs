using Apple_Music_Dashboard.Models.Enitities;

namespace Apple_Music_Dashboard.Data
{
    public static class InMemoryDataStore
    {
        public static User User = new();

        public static List<Artist> Artists = new();
        public static List<Song> Songs = new();
        public static List<PlayEvent> PlayEvents = new();
    }

}

using Apple_Music_Dashboard.Models.Enitities;

namespace Apple_Music_Dashboard.Data
{
    public static class DataSeeder
    {
        public static void Seed()
        {
            var artist = new Artist
            {
                Name = "Drake",
                Genre = "Hip-Hop"
            };

            var song = new Song
            {
                Title = "Passionfruit",
                ArtistId = artist.Id,
                Genre = "Hip-Hop",
                DurationSeconds = 298
            };

            InMemoryDataStore.Artists.Add(artist);
            InMemoryDataStore.Songs.Add(song);
        }
    }

}

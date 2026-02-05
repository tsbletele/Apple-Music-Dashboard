namespace Apple_Music_Dashboard.Services
{
    public class StatsService
    {
        public int CountSongs(LibrarySongsResponse response)
            => response.Data.Count;

        public Dictionary<string, int> GenreDistribution(
            IEnumerable<LibrarySong> songs)
        {
            return songs
                .Where(s => s.Attributes?.GenreNames != null)
                .SelectMany(s => s.Attributes.GenreNames)
                .GroupBy(g => g)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }

}

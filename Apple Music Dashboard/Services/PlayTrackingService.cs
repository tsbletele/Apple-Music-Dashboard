using Apple_Music_Dashboard.Data;
using Apple_Music_Dashboard.Models.Enitities;

namespace Apple_Music_Dashboard.Services
{
    public class PlayTrackingService
    {
        public void LogPlay(Guid songId)
        {
            var song = InMemoryDataStore.Songs
                .FirstOrDefault(s => s.Id == songId);

            if (song == null) return;

            InMemoryDataStore.PlayEvents.Add(new PlayEvent
            {
                UserId = InMemoryDataStore.User.Id,
                SongId = songId,
                PlayedAt = DateTime.UtcNow,
                DurationSeconds = song.DurationSeconds
            });
        }
    }
}

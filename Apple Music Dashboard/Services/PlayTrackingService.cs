using Apple_Music_Dashboard.Data;
using Apple_Music_Dashboard.Models.Enitities;

namespace Apple_Music_Dashboard.Services
{
    public class PlayTrackingService
    {
        public void TrackPlay(PlayEvent play)
        {
            play.Id = InMemoryDataStore.PlayEvents.Count + 1;
            play.PlayedAt = DateTime.UtcNow;

            InMemoryDataStore.PlayEvents.Add(play);
        }

        public List<PlayEvent> GetAllPlays()
        {
            return InMemoryDataStore.PlayEvents;
        }
    }
}

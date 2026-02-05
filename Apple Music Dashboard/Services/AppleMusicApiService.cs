namespace Apple_Music_Dashboard.Services
{
    public class AppleMusicApiService
    {
        private readonly HttpClient _http;

        public AppleMusicApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<string> GetLibrarySongsAsync(string developerToken, string userToken)
        {
            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "https://api.music.apple.com/v1/me/library/songs"
            );

            request.Headers.Add("Authorization", $"Bearer {developerToken}");
            request.Headers.Add("Music-User-Token", userToken);

            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }

}

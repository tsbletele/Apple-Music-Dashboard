#  Apple Music Dashboard

A full-stack **C# Apple Music analytics dashboard** that visualizes a user’s Apple Music library, playlists, and listening behavior using the official Apple Music API.

This project focuses on **secure API integration**, **data aggregation**, and a **clean dashboard UI**, with plans to extend into Spotify-style “Wrapped” analytics over time.

---

##  Features

###  Listening Insights
- Recently played tracks
- Recently added songs and albums
- Track metadata (artist, duration, release date)

###  Library Statistics
- Total number of songs, albums, and artists
- Genre distribution visualization
- Oldest vs newest music in the library

###  Playlist Analytics
- Total playlists
- Largest playlist
- Average playlist size
- Most common artists across playlists

### 📊 Dashboard UI
- Card-based layout for quick insights
- Charts and tables for analytics
- Fully responsive interface

---

##  Tech Stack

### Backend
- **ASP.NET Core Web API**
- Apple Music REST API
- JWT generation for Apple Music Developer Token
- DTO-based response mapping
- Secure handling of Apple credentials

### Frontend
- **Blazor WebAssembly**
- End-to-end C#
- Charting library for data visualization
- REST communication with backend API

### Authentication
- Apple Music **Developer Token** (generated server-side)
- Apple Music **User Token** (generated client-side via MusicKit)

---

##  Architecture Overview

- The frontend never communicates directly with Apple Music
- All API secrets and logic are handled securely in the backend
- The backend computes derived statistics before returning data to the UI

---

##  Apple Music API Notes

Apple Music does **not** provide full listening history or lifetime play counts.

This dashboard:
- Uses only officially supported Apple Music endpoints
- Focuses on library-based and recent activity insights
- Clearly distinguishes between API-provided data and derived analytics

---

##  Planned Enhancements

- Spotify-style “Wrapped” analytics
- Listening streaks and milestones
- Monthly and yearly summaries
- Historical trend charts
- Optional persistence layer (database integration)

---

##  Project Status

**Current Phase**
-   Apple Music API integration
-   Read-only analytics dashboard
-   Secure authentication flow

**Planned**
-   Advanced analytics and Wrapped-style insights

---

##  Author

**Tsebo Letele**  
Computer Science Graduate & Software Developer  
Focused on C#, .NET, and full-stack development

---

##  Disclaimer

This project is **not affiliated with Apple**.  
All data is accessed via the official Apple Music API and used strictly for educational and portfolio purposes.



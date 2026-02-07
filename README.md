#  Apple Music Dashboard (Wrapped-Style Analytics)

A **C#/.NET-based music analytics dashboard** inspired by Apple Music Replay and Spotify Wrapped.  
This project focuses on **tracking listening activity, generating fun summaries, and gamifying music habits** using a **custom-built API**, rather than Apple’s official API.

---

##  Important Note: No Apple Music API Integration

This project **does NOT use Apple’s official Music API**.

### Why?
Apple does **not** provide access to:
- User listening history
- Play counts
- Time listened
- Real-time track plays

Even with a paid Apple Developer account.

Instead, this project:
- Builds a **custom analytics backend**
- Tracks listening activity **inside the application**
- Generates Wrapped-style insights from tracked data

---

##  Project Goals

- Build a **Wrapped-style music analytics system**
- Practice **real-world API design**
- Implement **time-based aggregation** (weekly, monthly, yearly)
- Add **gamification** to make music stats fun and engaging
- Keep the system **API-first** and frontend-agnostic

---

##  Core Features

###  Listening Tracking
- Track individual song plays
- Store metadata:
  - Track name
  - Artist
  - Album
  - Duration
  - Timestamp

###  Wrapped-Style Summaries
- Weekly summaries
- Monthly summaries
- Yearly summaries
- Top tracks, artists, and albums
- Total listening time

###  Gamification
- Daily listening streaks
- Longest streak tracking
- Achievement-style milestones  
  (e.g. 7-day streaks, 100 songs played)

---

##  Tech Stack

### Backend
- **C#**
- **ASP.NET Core Web API**
- **Swagger (Swashbuckle)** for API testing
- In-memory data storage

### Frontend (Planned)
- Blazor / Razor Pages
- Dashboard-style UI with charts and stats


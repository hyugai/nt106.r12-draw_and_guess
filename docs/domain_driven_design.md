# Domain-Driven Design (DDD)

# 1. Business Domain: Multiplayer Drawing & Guessing Game

## Overview

A real-time multiplayer game where Players join Rooms, draw pictures, and interact with others through two game modes: **Classic Mode (MVP)** and **Imposter Mode (Future)**.

The game uses a Client–Server architecture, where the Server manages Rooms, Players, game rules, and synchronizes gameplay in real time.

# 2. Core Subdomains

- **Classic Mode (MVP)**, assigns a Painter to draw a Secret Word while Guessers submit Guesses, validates answers, and awards Scores.
- **Imposter Mode (Future)**, assigns Players as Normal Players who know the Secret Word or an Imposter who does not, manages turn-based drawing on a shared canvas, voting, and determines the winning side.

# 3. Supporting Subdomains

- **Round Management**, manages Round lifecycle, timers, status, and progression.
- **Room Management**, manages Rooms, Hosts, Player membership, readiness, and Room settings.
- **Secret Word Management**, maintains the Word Bank and provides Secret Words for each Round.
- **Match History (Optional)**, stores completed matches, final Scores, and game results.

# 4. Generic Subdomains

- **Player Identity**, assigns each Player a unique identifier and display name, supporting Guest Players.
- **Authentication (Optional)**, manages Player registration, login, and authentication.
- **Player Profile (Optional)**, stores persistent Player information and preferences.

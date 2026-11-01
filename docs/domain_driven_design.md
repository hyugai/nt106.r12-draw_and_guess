# Domain-Driven Design (DDD)

# 1. Business Domain: Multiplayer Drawing & Guessing Game

## Overview

A real-time multiplayer game where Players join Rooms, draw pictures, and interact with others through two game modes: **Classic Mode (MVP)** and **Imposter Mode (Future)**.

The game uses a Client–Server architecture, where the Server manages Rooms, Players, game rules, and synchronizes gameplay in real time.

# 2. Core Subdomains

## 2.1. Classic Mode (MVP)

A drawing-and-guessing game where a **Painter** draws a **Secret Word** while other Players act as **Guessers** and submit **Guesses** to earn **Scores**.

**Core Gameplay:**

```mermaid
flowchart TD
    A[Players Join Room] --> B[Start Round]
    B --> C[Assign Painter & Secret Word]
    C --> D[Painter Draws Strokes]
    D --> E[Guessers Submit Guesses]
    E --> F[Award Scores]
    F --> G[Next Round / Final Results]
```

## 2.2. Imposter Mode (Future)

A social deduction game where Players collaboratively draw a Secret Word, but one Player is secretly assigned as the **Imposter** and does not know the word.

**Core Gameplay:**

```mermaid
flowchart TD
    A[Players Join Room] --> B[Assign Secret Roles]
    B --> C[Start Round]
    C --> D[Players Take Turns Drawing Strokes]
    D --> E[Players Vote for Imposter]
    E --> F[Reveal Imposter]
    F --> G[Determine Winner]
```


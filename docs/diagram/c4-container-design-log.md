# C4 Container design log

Date: 2026-11-07

Status: Applied on 2026-11-07 after the user instructed “now apply changes to drawio file”.
Microsoft SQL Server is the selected database.

Target file: `system-context-diagram.drawio.xml`

## Scope and requirements

The user's assigned work is system architecture: the overall architecture and
multithreading/multiple-connection diagrams. The existing C4 Context provides
the actors, system scope, and Google Identity integration.

Requirements source: `final-project-requirements/Đồ án môn học.pptx`, slides 2–3,
and the user's supplied assignment screenshot.

- C# GUI clients, with at least two clients supported concurrently.
- Server-side database.
- Team-developed network stack, documented ports and message structures, and
  multiple simultaneous connections. Internet connectivity earns bonus points.
- WinForms client and ASP.NET Core Minimal API server, as specified by the user.
- Microsoft SQL Server, explicitly selected by the user.
- Registration and sign-in required, with Google sign-in supported.
- Normal and Imposter game modes, using a system-provided default keyword pool.
- In Imposter mode, all players except the imposter know the keyword. The system
  manages turns, voting, imposter reveal, and determination of the winning side.

Packet structures, port assignments, and detailed message definitions belong to
the network-stack teammate's diagrams; they are not designed in this change.

Related plan: [Server Concurrency](server-concurrency-design-log.md).

## C4 Container diagram

Page: update the existing `C4 Container` page.

Title: **Draw & Guess Game — Container Diagram**

System boundary: **Draw & Guess Game**.

### Containers inside the system boundary

| Container | Technology | Responsibilities |
| --- | --- | --- |
| Game Client | C# / Windows Forms | Account screens, lobby, drawing canvas, guessing, voting, and results. One box represents the client application installed on multiple computers. |
| Game Server | C# / ASP.NET Core Minimal API + TCP sockets | Authentication, concurrent connections, rooms, keyword selection, Normal and Imposter rules, drawing synchronization, scoring, voting, and results. |
| Game Database | Microsoft SQL Server | Stores accounts, Google identity links, the default keyword pool, and retained match results. |

Minimal API endpoints and the custom TCP listener run in one server process;
they are not separate containers. Replace the earlier SignalR proposal with a
team-developed application protocol over TCP for gameplay.

### External elements

- **Player**: registered user participating in games.
- **Host**: a Player with room creation, mode selection, and game-start controls.
  Host also has the regular Player interactions.
- **Google Identity**: external software system providing Google sign-in.

### Relationships

| From | To | Label | Technology |
| --- | --- | --- | --- |
| Player | Game Client | Plays games using | Windows Forms UI |
| Host | Game Client | Creates rooms, selects modes, and starts games using | Windows Forms UI |
| Game Client | Game Server | Registers, signs in, and obtains a game session | HTTPS / JSON |
| Game Client | Game Server | Sends gameplay actions | Custom application protocol / TCP |
| Game Server | Game Client | Sends game updates and results | Custom application protocol / TCP |
| Game Client | Google Identity | Initiates Google sign-in through the system browser | OpenID Connect / HTTPS |
| Game Server | Google Identity | Completes or verifies Google authentication | OpenID Connect / HTTPS |
| Game Server | Game Database | Reads and writes accounts, keywords, and match results | TDS over TLS |

Server data access uses **EF Core with the SQL Server provider**. EF Core is a
library within the server, not a separate container or network protocol. The
TDS-over-TLS label specifies the intended encrypted SQL Server connection.

The server validates a game session when the TCP connection is established.
It owns authoritative room state, keyword selection, hidden roles, turn order,
votes, and results. Secret keywords are delivered only to eligible players.
Active rooms initially live in server memory; server restart ends active matches.
The exact Google authentication flow and TCP message formats are implementation
details to coordinate with their respective owners.

### Layout and notation

- Use C4 Person, Container, Database, external Software System, Relationship,
  and system-boundary notation consistent with the existing legend.
- Actors above the Client; Server below the Client; Database below the Server;
  Google Identity to the right.
- Clearly separate and label the HTTP and TCP relationships.
- Wrap descriptions with explicit line breaks and provide sufficient shape size.
- Leave generous spacing between actors, containers, and relationship labels.
- Keep the Container page legend well below the main diagram; preserve its
  examples, content, styles, and internal layout. Move the whole group only as
  needed to implement the agreed spacing.

## Preservation and verification for implementation

- Follow `AGENTS.md`: leave the complete C4 Context page and its legend unchanged.
- Preserve the existing C4 Component and C4 Class pages.
- Update only C4 Container for this plan. Server Concurrency is a separate plan.
- Validate XML, unique IDs, parent/source/target references, and edge geometry.
- Compare untouched pages and protected legend contents against the original.
- Inspect a rendered preview if a renderer is available; otherwise report that
  visual confirmation remains necessary in draw.io.

## Application record

Applied to the `C4 Container` page of `system-context-diagram.drawio.xml`.

- Implemented the logged plan with explicit wrapped descriptions and spacious
  placement of model elements and labels.
- Updated C4 Container and added Server Concurrency; the file now has five pages.
- Preserved C4 Context, C4 Component, and C4 Class byte-for-byte.
- Preserved Container legend contents, styles, size, and internal positions;
  relocated only its group below the main diagram.
- Validated XML parsing, unique IDs per page, parent/source/target references,
  and relative edge geometry. Checked activity-node bounds and corrected an
  overlapping explanatory note.
- No draw.io Desktop renderer was available. Final visual confirmation remains
  necessary in the draw.io editor.

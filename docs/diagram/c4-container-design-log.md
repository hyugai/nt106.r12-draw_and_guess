# C4 Container design log

Date: 2026-11-07

Status: Applied on 2026-11-07 after the user instructed “now apply changes to drawio file”.
Microsoft SQL Server is the selected database.

Target file: `c4-model.drawio.xml`

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

Applied to the `C4 Container` page of `c4-model.drawio.xml`.

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


## 2026-11-13 — Approved SignalR architecture and server components

This decision supersedes earlier custom-TCP gameplay statements in this log and the historical architecture section of `AGENTS.md` in this directory. The user explicitly selected ASP.NET Core SignalR for realtime gameplay and approved Vietnamese updates to Context, Container, Component, and the concurrency overview only.

- Container now shows WinForms with SignalR .NET Client, one ASP.NET Core process containing Minimal API and SignalR Hub, and SQL Server through EF Core. Accounts and sessions use HTTPS/JSON; gameplay uses SignalR over HTTPS, with WebSockets/WSS when available.
- Hub instances do not own room state. The server remains authoritative; private keywords, hints, and roles go only to eligible recipients. Active rooms remain in memory. Google sign-in remains planned.
- Replaced the Component template's empty model area with ten logical responsibilities: authentication/session, gameplay Hub, lobby/rooms, sequential room processing/match coordination, Normal rules, Imposter rules, canvas, keyword/hint selection, filtered delivery, and persistence. Added external client/database containers and explicit dependencies.
- Component responsibilities do not imply separate services or threads. Open scoring, tie, reconnect, and host-transfer policies remain open. The diagrams describe target architecture, not verified application implementation.
- Preserved all original notation legends, page IDs/names, Class page, and swimlane page. The latter two remain byte-for-byte unchanged and may show older terminology.
- Validation: XML parsing, unique IDs, parent/source/target references, relative edge geometry, and preservation checks passed. Rendered Context, Container, Component, and overview previews were inspected; expanded relationship labels after visual review. Temporary preview artifacts are under `/tmp`, outside repository deliverables.

Technical references consulted: [SignalR overview](https://learn.microsoft.com/aspnet/core/signalr/), [authentication and authorization](https://learn.microsoft.com/aspnet/core/signalr/authn-and-authz), and [Hub lifecycle](https://learn.microsoft.com/aspnet/core/signalr/hubs).


## 2026-11-13 — Add planned Redis SignalR backplane

- Authorization: the user approved adding Redis to the C4 Container page only, with English records in this log and `agent.md`.
- Added `ct-redis`, a separate Redis data-store container inside the Draw & Guess system boundary, labeled in Vietnamese as a planned SignalR backplane for multiple server instances.
- Added `ct-e-redis`, Game Server → Redis, for distributing SignalR updates across servers, labeled `Redis protocol / TLS`. TLS is a target design choice, not verified deployment configuration.
- Redis is scoped to the backplane in this change. SQL Server retains durable accounts, keywords, and match results; Redis does not replace authoritative in-memory room state. No cache, shared room directory, RabbitMQ, or multi-server deployment was implemented.
- Validation passed: XML parsing, unique IDs, parent/source/target references, relative edge geometry, and rendered Container preview inspection. All pre-existing Container elements, including its legend, are unchanged; all five other diagram pages are byte-for-byte identical to the pre-edit snapshot.


## 2026-11-13 — Remove Redis from current Container architecture

- Authorization: the user approved removing Redis and its Game Server relationship from the C4 Container page and updating the English logs.
- Removed only `ct-redis` and `ct-e-redis`. The current architecture uses one ASP.NET Core server process with SignalR and SQL Server; Redis is deferred. This supersedes the earlier Redis addition for the current diagram.
- Validation passed: XML parsing, unique IDs, parent/source/target references, relative edge geometry, and absence of Redis on the Container page. All remaining Container elements and legends are unchanged; all five other pages are byte-for-byte preserved. No new rendered preview was generated for this removal.


## 2026-11-13 — Clarify HTTPS initialization and SignalR transports

- Authorization: user approved the finalized Vietnamese wording for the two gameplay relationships and associated English log updates.
- Updated only `ct-e-actions` and `ct-e-updates` on the Container page. Client → Server explicitly describes HTTPS connection initialization followed by secure WebSocket (WSS) delivery or an HTTPS fallback transport. Server → Client describes updates through the established WSS or HTTPS fallback connection. Both identify ASP.NET Core SignalR separately from transport details.
- Expanded label width from 190px to 260px for readability. Account traffic remains HTTPS/JSON. No connection policy or application code was changed.
- Validation passed: XML parsing, unique IDs, graph references, relative edge geometry, and rendered preview inspection. Exactly two relationship elements differ from the pre-edit snapshot; every other Container element and all five other pages are preserved.


## 2026-11-13 — Remove Google Identity from Container scope

- Authorization: the user approved removing the optional Google Identity integration from the Container diagram after discussion of its necessity.
- Removed `ct-google`, `ct-e-google-client`, and `ct-e-google-server`; removed the Google identity-link reference from the database description. Existing HTTPS/JSON account authentication remains.
- Validation passed: XML parsing, unique IDs, graph references, relative edge geometry, no remaining Google references on the Container page, unchanged legends and remaining elements, and byte-for-byte preservation of all five other pages. No new render was generated.
- Scope: Container page only. Context and concurrency pages retain their earlier Google references; cross-page alignment would require a separate approved change. No application code or authentication implementation was modified.


## 2026-11-13 — Balance Container layout for Google Docs

- Authorization: user approved the proposed Container-only layout update, preserving wording/architecture and updating the two English logs.
- Centered the Player/Host pair above the client; aligned client, server, and SQL Server vertically. Moved the architecture note beside the server, rerouted account traffic, repositioned relationship labels, and increased model typography for document use.
- Reduced page size from 1700 × 2100 to a compact landscape 1600 × 1470. Moved the entire original 696 × 220 legend group below the diagram without changing its contents, size, or internal geometry.
- Rendered previews exposed clipped actor/database text in the first layout; adjusted actor typography and shape heights, then inspected the corrected final preview. Temporary final PNG: `/tmp/c4-container-balanced-final.png`. Actual readability in the destination Google Doc depends on insertion size and was not tested in Google Docs.
- Validation passed: XML, unique IDs, references, relative edges, unchanged names/descriptions/technology and label text, unchanged relationships, intact legend contents, and byte-for-byte preservation of all five other pages.

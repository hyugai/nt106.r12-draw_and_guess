# Server concurrency design log

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

Related plan: [C4 Container](c4-container-design-log.md).

The server uses EF Core with the SQL Server provider for asynchronous persistence.
The Minimal API endpoints and custom TCP listener share one server process.

## Server concurrency activity diagram

Page: add a separate `Server Concurrency` page.

Title: **Game Server — Concurrent Connection and Room Processing**

Notation: UML activity diagram with swimlanes. This is a supporting architecture
view, not an additional C4 level or a C4 Container diagram.

### Swimlanes

| Swimlane | Activities |
| --- | --- |
| TCP Listener | Start listener, accept a connection, create a connection handler, and immediately continue accepting connections. |
| Connection Handler — one per client | Validate session, asynchronously receive bytes, assemble complete messages, validate and route actions; repeat until disconnected. |
| Room Processor — one per room | Queue actions, process one at a time, check permissions and game phase, update authoritative state, and produce recipient-specific events. |
| Outbound Delivery — one queue per client | Queue events, serialize and frame messages, and asynchronously send them in order. |
| Persistence | Load required data and save completed results using EF Core asynchronous operations against Microsoft SQL Server. |

### Concurrency and lifecycle behavior

1. Show Client A and Client B routed to Room 1, and Client C routed to Room 2.
2. Connections and different rooms operate concurrently; each room processes
   state-changing actions sequentially to prevent conflicting updates.
3. Show private delivery of keywords and roles, and room broadcasts of drawing
   updates, turns, and public results.
4. Give each client an outbound queue and a single ordered send loop. Bound the
   queues so a slow client cannot indefinitely consume memory or block a room;
   signal overload to the disconnect path rather than silently dropping
   authoritative game events. The exact queue limit remains an implementation
   detail.
5. On disconnect or connection failure, cancel connection tasks, remove room
   membership through the room's processing path, release resources, and notify
   remaining participants. Host transfer and reconnect policy are unspecified.
6. Keep database work out of the accept loop. Preserve per-room sequencing for
   operations whose results affect room state; asynchronous I/O does not imply
   unrestricted parallel mutation of room state.
7. Label receive and send loops as asynchronous tasks; do not imply a dedicated
   operating-system thread per client.

Use activity/swimlane notation with readable labels. Do not reuse C4 shapes as
activity nodes; provide a small activity-specific legend only if needed.

## Preservation and verification for implementation

- Follow `AGENTS.md`: leave the complete C4 Context page and its legend unchanged.
- Preserve the existing C4 Component and C4 Class pages.
- Add only Server Concurrency for this plan; preserve existing diagram pages.
- Validate XML, unique IDs, parent/source/target references, and edge geometry.
- Compare untouched pages and protected legend contents against the original.
- Inspect a rendered preview if a renderer is available; otherwise report that
  visual confirmation remains necessary in draw.io.

## Application record

Applied to the `Server Concurrency` page of `c4-model.drawio.xml`.

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

## Additional overview page

At the user's request, added a separate `Concurrency Overview` page using the
supplied event-loop/thread-pool image as a layout reference. The existing
`Server Concurrency` page was explicitly protected and remains byte-for-byte
unchanged, as do all other pre-existing pages.

The new overview adapts the reference to .NET rather than introducing a single
global event-loop thread or worker-blocking database I/O:

- WinForms Clients A and B route to Room 1; Client C routes to Room 2.
- Per-connection asynchronous receive handlers frame and validate messages.
- A router forwards actions to per-room queues with sequential consumers.
- A shared .NET thread pool executes ready continuations and game logic;
  dashed execution links illustrate this logical relationship, not dedicated
  workers reserved for particular rooms or clients.
- Private and broadcast events pass through recipient filtering and bounded
  per-client outbound queues, then ordered asynchronous send loops.
- EF Core asynchronous persistence accesses SQL Server over TDS with TLS.
- Pending network/database I/O does not reserve a worker thread. Disconnects,
  failures, and full outbound queues trigger cleanup and room notifications.

The file now contains six pages. XML parsing, unique IDs, graph references,
relative edge geometry, and attribute escaping checks passed. No rendered
preview was available; final appearance should be checked in draw.io.

### Overview readability revision

After the user reported overlapping arrows and labels, reformatted only the
`Concurrency Overview` page:

- Used larger, aligned boxes with explicitly wrapped text and open routing gaps.
- Combined the receive handlers in a clearly labeled panel, with three parallel
  incoming client paths and one route to the message router.
- Separated Room 1 and Room 2 routing and recipient-event paths.
- Replaced three crossing response routes with a single return path to the
  grouped clients.
- Replaced crossing scheduler arrows with a shared thread-pool execution band;
  this band is an annotation, not a message-processing stage.
- Kept the async persistence dependency distinct from application message flow.
- Verified all other pages, including `Server Concurrency`, remained
  byte-for-byte unchanged. XML and graph reference checks passed.

A mounted draw.io executable was found, but its renderer failed to start under
the environment's process/sandbox restrictions. No visual render was obtained.

### Edge label corrections from screenshots

Set explicit label widths and non-wrapping HTML on the Room 1, Room 2, and async
persistence connectors. Placed client-routing labels above their horizontal
segments. Shortened the persistence label to `Async load/save (all rooms)` and
removed redundant waypoints, leaving one bend. Verified that only these three
edges on Concurrency Overview changed; all other diagram content was preserved.
XML validation passed.

### Concurrency model brief

Added the user-approved event-driven/thread-pool/asynchronous non-blocking I/O
brief at the top left of Concurrency Overview, below its title. The brief
explains event examples, ready continuations, pending I/O, and per-room ordering.
Reserved a dedicated 190px-high text box and shifted the drawing and connector
waypoints down by 220px to avoid overlap. Expanded page height accordingly.
All other pages remain unchanged; XML validation passed.


## 2026-11-13 — Approved SignalR concurrency overview

Updated only `server-concurrency-overview` (`Concurrency Diagram - v0`) after user approval. This entry supersedes its earlier custom-TCP receive/framing/send design.

- Translated actual overview content into Vietnamese. SignalR Hub invocations now feed validated actions into sequential room queues; state lives outside Hub instances. Timer expiry and membership changes use the same ordering path.
- Retained shared .NET thread-pool execution, asynchronous non-blocking I/O, room independence, and recipient-specific secret delivery. Application-managed bounded outbound queues feed one ordered sender per connection through IHubContext. These queues and ordering are application design obligations, not automatic SignalR guarantees.
- Added a Vietnamese transport note: SignalR handles transport/framing; WebSockets/WSS is used when available. Reconnect, queue limits, and host transfer remain unspecified.
- Preserved the original English reading-guide legend exactly as approved and noted its historical origin separately. Preserved the older swimlane page byte-for-byte; it still depicts the prior TCP design.
- Checks passed: XML, IDs, graph references, relative edges, preserved legends and untouched pages. Inspected a rendered overview and widened relationship labels to avoid stacked words. Final label changes received structural validation.

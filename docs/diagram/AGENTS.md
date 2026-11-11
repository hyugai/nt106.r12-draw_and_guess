# Diagram editing instructions

## Start here: current handoff

- Main editable artifact: `c4-model.drawio.xml` in this directory.
  It is an uncompressed, six-page draw.io XML file, not application source code.
- The requested architecture diagrams and subsequent formatting changes have
  been applied. There is no previously authorized implementation work left
  pending. Continue from the user's next request; do not rebuild the diagrams
  from the original proposals or reapply historical changes.
- XML/reference checks passed during editing. Final rendered appearance has
  not been independently verified; screenshots revealed layout problems that
  were corrected, but the last corrections still need a visual check.
- Read the relevant design log for detail. Logs contain chronological history:
  later application/revision records supersede earlier proposals, page counts,
  and layout descriptions. The inventory below was checked against the actual
  file. Future explicit user instructions take precedence over this handoff.
- Use stable diagram IDs to identify pages when names change. Re-read current
  page names before editing; the user may rename or reorder tabs in draw.io.

| Current page name | Stable diagram ID | State / intended use |
| --- | --- | --- |
| C4 Context | `zNMGI6wU0Mi8Qe2H5Q59` | Implemented system context; preserve unless targeted. |
| C4 Container | `7UhaJ9ljh7ebol46HkWr` | Implemented client/server/SQL Server architecture. |
| C4 Component | `2XVK7RYDKxdhMDquu4st` | Existing template content; outside current assignment work. |
| C4 Class | `S9xD85C3ral9A_xj9ERV` | Existing template content; outside current assignment work. |
| Concurrency Diagram - v0 | `server-concurrency-overview` | Newer architecture-style concurrency diagram; primary view being refined. |
| Server Concurrency - swimlane diagram | `server-concurrency-architecture` | Earlier activity/swimlane view; explicitly preserved during newer-view edits. |

Important elements on `server-concurrency-overview`:

- `ov-title`: displayed title **Game Server — Concurrency Diagram**.
- `ov-model-brief`: approved top-left explanation of events, the thread pool,
  pending non-blocking I/O, and per-room processing.
- `ov-e-room1` / `ov-e-room2`: client-routing labels with explicit widths and
  non-wrapping HTML. Keep `A / B` on one horizontal line.
- `ov-e-persist`: `Async load/save (all rooms)` label and a single-bend route.
- Shared thread-pool execution is shown as an explanatory band; scheduler
  arrows were removed to avoid crossings. Preserve this later design choice.

## Project and assignment

- Act as a C4 system design collaborator with C# expertise.
- Project: multiplayer Draw & Guess Game with Normal and Imposter modes.
- The user's assignment is system architecture: overall architecture and
  multithreading/multiple-connection diagrams. C4 Context, C4 Container, and the
  concurrency diagram cover that assigned scope; they do not cover the entire
  team's deliverables.
- Requirements: `final-project-requirements/Đồ án môn học.pptx`, especially
  slides 2–3. The supplied assignment screenshot further divides team duties.
- At least two GUI clients, a server-side database, a team-developed network
  stack, and concurrent connections are required. Detailed ports, framing,
  packet/message definitions, game flows, GUI wireframes, and database schema
  belong to other assigned work unless the user expands the scope.

## Editing workflow

- Brainstorm and present proposed architectural changes before applying them.
  Once the user authorizes a concrete change, apply it without asking again.
- Record design decisions and changes in the corresponding log:
  `c4-context-design-log.md`, `c4-container-design-log.md`, or
  `server-concurrency-design-log.md`. Preserve these separate files.
- Update only the requested diagram page or elements. Preserve all unrelated
  pages and verify their contents remain unchanged.
- The newer architecture-style view was originally called `Concurrency Overview`;
  it is now `Concurrency Diagram - v0`. The older `Server Concurrency` page is
  now `Server Concurrency - swimlane diagram`. Leave the older page untouched
  when editing the newer one unless the user explicitly requests otherwise.
- Do not automatically change displayed titles and page names together.

## Established architecture

- Client: C# / Windows Forms.
- Server: C# / ASP.NET Core; Minimal API endpoints and a custom TCP listener
  share one process and one C4 container.
- Gameplay uses a team-developed application protocol over TCP, not SignalR.
- Registration, sign-in, and session acquisition use HTTPS / JSON.
- Database: Microsoft SQL Server. Server data access uses EF Core with the
  SQL Server provider; the diagram's database connection is TDS over TLS.
- Google Identity is an external software system. Google sign-in uses the
  system browser and OpenID Connect / HTTPS; detailed authentication flow
  remains an implementation decision to coordinate with its owner.
- Accounts are required to play. Host is a Player with room creation, mode
  selection, and game-start controls.
- The system chooses keywords from its default pool. The host does not supply
  the keyword and may be assigned the imposter role.
- In Imposter mode, n−1 players know the keyword; the imposter tries to infer it
  and blend in. The server controls turns, votes, reveal, and results. Do not
  invent unresolved Normal-mode rules, imposter drawing rules, tie handling,
  host transfer, or reconnect policies.
- The server owns authoritative state and limits secret keyword/role delivery
  to eligible recipients. Active room state initially lives in server memory.

## Concurrency model

- Event-driven asynchronous non-blocking I/O with .NET thread-pool execution.
  Events include incoming connections, received data, timer expiry, and
  disconnections; this does not require C#'s `event` keyword.
- Use asynchronous receive/send tasks per connection, not dedicated threads
  per client. Pending network/database I/O does not reserve a waiting thread.
- The thread pool executes ready continuations and game logic. Do not depict
  a single global event-loop thread or routine blocking database calls handed
  to workers as the chosen architecture.
- Route actions to one sequential processing queue per room. Different rooms
  may progress concurrently; each room's state changes are serialized.
- Use bounded outbound queues and one ordered asynchronous send loop per
  client. Slow clients must not block room processing; disconnect/failure/full
  queue handling triggers cleanup and queued membership removal.
- Preserve room ordering when an asynchronous database result affects state.
- The concurrency diagram is a supporting architecture view, not an extra C4
  abstraction level. The activity view and architecture overview may coexist.

## Layout and validation

- Keep generous space between actors and software systems/containers, and
  place legends well away from the main drawing.
- Use explicit line breaks and sufficient shape dimensions for descriptions.
  Use the correctly cased draw.io style `whiteSpace=wrap` on wrapped nodes.
- Give edge labels explicit widths where needed. Keep short arrow labels
  horizontal and non-wrapping; place them in open space above horizontal
  segments. Avoid narrow labels that stack words or individual characters.
- Minimize connector bends and crossings. Preserve readable parallel routes;
  use a shared execution annotation instead of many crossing scheduler arrows.
- Keep the model brief at the top left of the newer concurrency diagram in its own
  reserved space, explaining events, the thread pool, non-blocking I/O, and
  sequential room processing. Shift waypoints consistently when moving nodes.
- Validate XML parsing, IDs and graph references per page, and relative edge
  geometry. Compare unrelated pages and protected legend contents with their
  originals. Inspect a rendered result when possible; report honestly when
  rendering is unavailable. XML validity alone does not prove visual quality.

## Preserve the C4 Context legend

When editing `c4-model.drawio.xml`, leave the entire Legend group
on the `C4 Context` page unchanged unless the user explicitly requests a change
to that legend.

- The legend group ID is `GGAcaCNyiWMHBxoHMokF-1`. Preserve the group and all
  descendants, including their labels, attributes, styles, geometry, and edges.
- The legend intentionally illustrates C4 notation, including people, software
  systems, containers, components, deployment elements, databases, and relationships.
- Labels such as `name`, `Description`, `technology`, and `Relationship` inside
  the legend are intentional examples. Do not flag them as unfinished model
  content or replace them.
- Do not simplify, remove, move, resize, restyle, or automatically lay out the
  legend as part of other diagram edits.
- Inspect and edit actual model elements outside the legend independently.

## Practical continuation and checks

- Inspect the latest file before edits, as it may include unsaved-session or
  user-applied changes since a previous turn. Never restore a temporary copy
  over the user's current artifact or touch draw.io's hidden backup files.
- Preserve unrelated page XML byte-for-byte where possible. Avoid serializing
  the entire document just to modify one page: that can rewrite protected XML.
- Python is available as `python3`; `python` was not available. Python's standard
  `xml.etree.ElementTree` can inspect this XML. `xmllint` is also available.
- Basic XML validation: `xmllint --noout c4-model.drawio.xml`.
  Additionally check duplicate IDs per page and that each cell's parent, source,
  and target reference exists on that page. Object-wrapped C4 nodes carry their
  IDs on `<object>`, not necessarily on the nested `<mxCell>`.
- A mounted draw.io executable was discovered under a temporary AppImage mount,
  but export failed under process/sandbox restrictions, even with GPU disabled.
  Do not assume that temporary path persists or repeatedly retry the same
  failure. Detect rendering capabilities anew if a preview is needed.
- Temporary scripts and snapshots under `/tmp` are not durable handoff assets.
  These instructions, the three Markdown logs, and the current draw.io XML are
  the durable project context.

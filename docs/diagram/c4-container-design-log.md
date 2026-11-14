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


## 2026-11-13 — Translate displayed actor types

- Authorization: the user approved Vietnamese label terminology while retaining the C4 term Container and technology names.
- Files: `c4-model.drawio.xml` (Container displayed actor labels) and this log; shared/export changes are recorded in root `agent.md` and the Context log.
- Changes: changed displayed type text for `ct-player` and `ct-host` from the Person placeholder to Người dùng. English C4 metadata is retained. Container type labels remain unchanged.
- Verification: rendered Container preview inspected; both translated labels fit. XML, IDs, references, relative edge geometry, and exact element comparisons passed. Legend and all other Container elements are unchanged. Four other pages are byte-for-byte preserved.
- Limits: Component already uses Thành phần and concurrency has no applicable English type labels outside legends, so neither needed edits. Legends and historical pages remain unchanged.


## 2026-11-14 — Export the current Container diagram without its legend

- Authorization: the user approved the specific proposal for a 2×, tightly cropped, white-background Container PNG without the legend and updates to both logs.
- Files changed: new `docs/diagram/c4-container.png`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Method: extracted the current Container page (`7UhaJ9ljh7ebol46HkWr`) to a temporary copy, removed the legend group and descendants only from that copy, and rendered with draw.io 32.6.10 at 2× scale and a 16-unit border. Output dimensions: 3109 × 2377 pixels.
- Verification: temporary XML parsing, unique IDs, and graph references passed; inspected the PNG for readable labels, intact model content, white background, and absent legend. PNG signature/dimensions checked. SHA-256 comparison confirms the complete source XML is unchanged. `git diff --check` passed.
- Limits/pending: current diagram exported as-is; Container/Component layout optimization remains deferred. Google Docs insertion/readability at final placement size is not verified. Concurrency review/page-fit/export, report explanations/multi-room walkthrough, implementation/testing evidence, instructor confirmation/failure policies, and final document review remain pending. No application tests required or run.


## 2026-11-14 — Remove title and architecture note from the Container export

- Authorization: the user approved an export-only revision removing the top-left title and yellow architecture note, with both logs updated.
- Files changed: `docs/diagram/c4-container.png`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes: regenerated the 2× white PNG from a temporary Container copy without `ct-title`, `ct-note`, or the previously excluded legend. Output: 3109 × 2277 pixels, cropped with a 16-unit border. All actual model nodes, descriptions, relationships, and the system boundary are preserved.
- Verification: export-copy XML/IDs/references passed; visually inspected the PNG for the requested removals, readable model labels, and intact crop. Checked PNG signature/dimensions. SHA-256 comparison confirms source `c4-model.drawio.xml` is unchanged. `git diff --check` passed.
- Limits/pending: removed annotations remain in the editable source. This is an export revision only; Container/Component optimization, concurrency review/page-fit/export, report explanations/evidence, instructor confirmation/failure policies, and final document review remain pending.


## 2026-11-14 — Compact the Container export and translate the mode label

- Authorization: the user approved compacting both exports and replacing visible Imposter labels with Kẻ giả mạo, while preserving both editable XML files and font sizes.
- Files: `c4-container.png` and this log; root `agent.md` records both exports.
- Changes in the temporary export copy: narrowed the system boundary to 1080 units, recentered actors and the client/server/database column, tightened vertical spacing, and arranged authentication/action/update labels in separate clear columns. Moved the database connector label into clear space. Retained the previous title/note/legend exclusions. Replaced the two visible Imposter occurrences with Kẻ giả mạo.
- Output: white, 2× PNG with 16-unit border, 2229 × 2247 pixels (previously 3109 × 2277). Source node/arrow fonts and all logical endpoints preserved.
- Verification: inspected the rendered export for wrapping, clipping, overlaps, and margins. Temporary XML/IDs/references/relative edges, terminology, unchanged font sizes, and original edge endpoints passed. Both source XML SHA-256 hashes are unchanged. `git diff --check` passed.
- Limits: layout and terminology changes apply to the PNG only; the editable source retains its prior layout and Imposter wording. Container source optimization remains deferred; actual Google Docs placement remains unchecked.


## 2026-11-14 — Enlarge export typography and verify A4 portrait fit

- Authorization: the user approved larger fonts in both exports and required Google Docs page fit, preserving source XML and updating both design logs and the shared log.
- Files: `c4-container.png` and this log; root `agent.md` records both outputs.
- Changes in the export copy: enlarged actors and connector labels to 18, main container text to 19, and database text to 18, with matching line heights. Actors use 18 rather than the proposed 17 to improve final document readability. Narrowed the boundary to 740 units; moved account and database relationship labels to a left rail and separated gameplay labels in the central gap. Resized/reflowed boxes and preserved all wording, technology names, endpoints, dashed relationships, and Kẻ giả mạo labels. A square boundary corner prevents its outline crossing the system label. Title, yellow note, and legend remain excluded.
- Output: 1549 × 2357 PNG at 2×, white background, 16-unit border.
- Verification: inspected final PNG and the Container page of `/tmp/c4-large-type-a4-proofs.pdf`. A4 portrait (594.96 × 841.92 pt), image width 16 cm, margins left 3 cm and others 2 cm; figure height about 24.35 cm, plus caption fits. At this insertion width, smallest body/connector type is about 10.5 pt and main box text about 11.1 pt. XML/IDs/references/relative edges, normalized wording, endpoints, PNG dimensions, source SHA-256, and `git diff --check` passed.
- Limits: proof verifies physical fit/readability under these settings, not actual insertion into Google Docs. Keep one figure and short caption on its own page, preserving aspect ratio. Source XML remains unchanged; export-only layout/font/terminology differences persist.


## 2026-11-14 — Scale down Container visuals while preserving current wording

- Authorization: the user approved the revised Container-only scope: retain current wording, scale down text/arrows, adjust padding/label spacing, and verify overlap and A4 fit. The previously proposed shortened wording was explicitly superseded and was not applied.
- Files changed: `docs/diagram/c4-container.png`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes in the temporary export copy: rounded the approximately 12% type reduction to 16–17, reduced connector stroke from 1.5 to 1.3 and arrowhead size to 5, tightened box/actor dimensions and padding, and applied consistent dash spacing. Put actor bends above labels, moved account/database routes to clear left rails, and separated gameplay arrow gutters from text. Shifted the boundary below actor labels. Kept every current description/technology string exactly, including long HTTPS/WSS explanations and Kẻ giả mạo.
- Output: 1549 × 2343, 2× white PNG.
- Verification: inspected final render and `/tmp/c4-container-scaled-a4.pdf` (A4 portrait, 594.96 × 841.92 pt). At 16 cm width, image height is about 24.20 cm and a caption fits with left 3 cm/other 2 cm margins. XML/IDs/references/relative edges, exact wording/topology comparison, conservative connector-segment/label-bound checks, PNG dimensions, and `git diff --check` passed. SHA-256 checks confirm Context PNG and both repository XML sources are unchanged.
- Limits/pending: smaller type is about 9.4–10 pt at 16 cm width, trading some text size for the user's requested visual spacing; actual Google Docs insertion remains unchecked. Changes remain export-only. Pending: concurrency review/page-fit/export; deferred source Container/Component layouts; report explanations/evidence; instructor confirmation/failure policies; final document review.


## 2026-11-14 — Apply finalized Container descriptions and attach labels to connectors

- Authorization: the user approved the finalized Client/Server/Database and both gameplay-direction descriptions, with explicit thời gian thực wording, and the pending correction attaching labels clearly to their arrows.
- Files changed: `docs/diagram/c4-container.png`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes in the temporary export copy: applied all five approved descriptions, retaining ASP.NET Core SignalR and other technology labels. Added explicit thời gian thực to the client and both gameplay directions. Centered every relationship label on its own connector with small white backgrounds and visible before/after segments; separated parallel channels and preserved logical endpoints. Enlarged the client box slightly for the approved text and balanced the update label's line breaks. Current scaled-down type, Kẻ giả mạo labels, dashed arrows, white background, and title/note/legend exclusions are retained.
- Output: 1549 × 2343 PNG at 2×.
- Verification: exact approved wording comparison (ignoring presentation breaks), technology/topology preservation, own-connector label-axis checks, XML/IDs/references/relative edges, PNG signature/dimensions, and `git diff --check` passed. Inspected final PNG and `/tmp/c4-container-final-wording-a4.pdf`: A4 portrait (594.96 × 841.92 pt), 16 cm image width, about 24.20 cm figure height, caption fits within left 3 cm/other 2 cm margins. Label associations are clear, with no visible text collisions. Hash checks confirm Context PNG and both editable XML files are unchanged.
- Limits/pending: actual Google Docs insertion remains unchecked; use the verified width/margins and preserve aspect ratio. Source XML retains older wording/layout because this was an export-only change. Pending: concurrency review/page-fit/export; deferred source Container/Component layouts; report explanations/multi-room walkthrough; implementation/testing evidence; instructor confirmation/failure policies; final document review.


## 2026-11-14 — Apply the minimal approved Container text changes to XML

- Authorization: the user approved a Container-only source patch covering the five finalized descriptions, Player's Imposter → Kẻ giả mạo wording, and both logs; no layout or PNG changes.
- Files changed: `docs/diagram/c4-model.drawio.xml`, this log, and root `agent.md`.
- Changes: updated text attributes on exactly six objects: `ct-client`, `ct-server`, `ct-db`, `ct-e-actions`, `ct-e-updates`, and `ct-player`. Client and both gameplay directions explicitly retain thời gian thực. Updated the two gameplay display templates with the approved HTTPS/WSS wording while preserving their widths, type sizes, and technologies.
- Verification: parsed XML and checked unique IDs, parent/source/target references, and relative edge geometry on all seven pages. Exact comparison confirms only the approved attributes in six opening tags differ; removing those tags leaves the rest of the file byte-for-byte identical. All geometry, styles, connectors, legends, and six unrelated pages are preserved. Inspected `/tmp/c4-container-minimal-text-review.png`; new descriptions wrap within the existing boxes. `git diff --check` passed.
- Limits: source layout intentionally remains unchanged and differs from the compact PNG export. No repository image regenerated; no application tests required or run.


## 2026-11-14 — Align Component responsibilities with Context, Container, and concurrency

- Authorization: the user approved the eight corrections identified in the cross-diagram review.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes: updated Component terminology to Kẻ giả mạo/bỏ phiếu; aligned realtime transport labels; clarified Hub validation, room resolution/membership checks, authoritative room-state ownership, ordered canvas updates, host startup permissions, per-connection bounded queues/senders, and account writes. Added delivery-to-room-management failure notification feeding the existing room-event queue path. Retained ten logical components and open gameplay/failure policies.
- Verification: XML parsing, unique IDs, parent/source/target references and relative edge geometry pass for all seven pages. The six other page blocks are byte-for-byte unchanged. Inspected temporary Component renders; corrected narrow wrapping of the new failure label. Updated descriptions fit existing boxes. Full page layout optimization remains deferred. No application tests were required; this records target architecture only.
- Pending: Component/Container layout and export refinement; Context source/export terminology synchronization; Google Docs sizing and report references; architecture explanations/multi-room walkthrough; implementation/testing evidence; scoring/tie/reconnect/host-transfer/queue policies and instructor confirmation; final report review.


## 2026-11-14 — Split Component diagram into two Google Docs report pages

- Authorization: the user approved two compact portrait pages in the original XML, two PNG exports without the c4 prefix, and updates to the design and shared logs.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/component-1.png`, `docs/diagram/component-2.png`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Added pages: `component-report-1` (reception and delivery) and `component-report-2` (room processing and data). All seven existing pages remain byte-for-byte unchanged, including the complete overview. A/B/C endpoints preserve room actions, outgoing events, and account-persistence dependencies. Both pages identify the same server process.
- Layout: two columns, compact boxes, consistent 22-unit body and 20-unit relationship text, light backgrounds, explicit label placement, and shared C#/ASP.NET Core boundary labels replacing repeated component technology tags. All ten component descriptions are preserved. Template legends and bottom notes are excluded from report views; the overview retains design notes.
- Exports: both PNGs are 1866 × 2836, 2×, white background, 16-unit border, with matching bounds for consistent insertion scale.
- Verification: XML, unique IDs, references, relative edges, exact component-description comparison, and logical endpoint comparison through A–C passed. Inspected final renders and two-page A4 proof `/tmp/component-a4-proof.pdf`. At 16 cm width each image is 24.32 cm tall, body text approximately 10.69 pt and relationships 9.72 pt; both fit with captions using left 3 cm and other 2 cm margins. Corrected intermediate label overlaps. No application tests required.
- Limits/pending: actual Google Docs insertion and exported report PDF remain unchecked. Pending: report references/placement; deferred Container source layout; Context source/export terminology synchronization; architecture explanations/multi-room walkthrough; implementation/testing evidence; unresolved policies/instructor confirmation; final report review.

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


## 2026-11-13 — Remove Google identity-link scope from concurrency overview

- Authorization: the user approved aligning Context and concurrency with the Container scope excluding Google Identity.
- Files: `c4-model.drawio.xml` (only `ov-sql` on `server-concurrency-overview`) and this log; Context/export/guide changes are recorded in the Context log and root `agent.md`.
- Changed the SQL Server description from accounts/Google links to accounts. Retained all other overview elements, geometry, relationships, and the reading-guide legend. The historical swimlane is byte-for-byte unchanged.
- Verification: XML, unique IDs, graph references, relative edge geometry, exact element comparison, and byte preservation of the four unrelated pages passed. Inspected a new overview PNG rendered with draw.io 32.6.10; the changed database text is readable and contains no Google reference.
- Limits: the preview also shows a pre-existing connector-label overlap around the central action router. Layout was preserved within this scope; that readability issue remains pending a separate approved correction. No application behavior changed.


## 2026-11-13 — Clear the action-router label overlap

- Authorization: the user approved the three-file proposal to correct the incoming action label on the concurrency overview and update both logs.
- Files changed: `c4-model.drawio.xml` (`ov-e-route` only on `server-concurrency-overview`) and this log; root `agent.md` records the shared change summary.
- Changes: reduced the connector label's HTML width from 240px to 80px, set an explicit 80px non-wrapping label width, and raised its offset from -16 to -26. Text, endpoints, and connector routing are unchanged.
- Verification: inspected a new draw.io 32.6.10 PNG at `/tmp/c4-router-label-fixed.png`; Hành động sits in the gap above the connector and the router title is fully visible. XML, unique IDs, references, and relative edge checks passed. Exact comparison confirms only `ov-e-route` changed on the overview; the legend and all remaining elements are unchanged. The other five pages are byte-for-byte preserved. `git diff --check` passed.
- Limits: layout correction only; no application tests required or run. No repository preview/export file was added.


## 2026-11-13 — Split concurrency into two report pages and clear remaining label masks

- Authorization: the user approved Context/concurrency layout work, report exports, guides, and relevant logs; Container/Component changes were explicitly deferred.
- Files: `c4-model.drawio.xml`, new `c4-report.drawio.xml`, new `c4-concurrency-1.png`, new `c4-concurrency-2.png`, and this log. Shared/report-guide changes are recorded in root `agent.md`.
- Original overview: narrowed `ov-e-in-a/b/c` labels to 100px, set explicit widths/non-wrapping text, and raised their offsets. Narrowed `ov-e-events2` to 130px and moved its label to clear the room-2 box and room note. Text, endpoints, and routes remain unchanged. Exact comparison confirmed only these four cells changed; five other pages and all legends are preserved.
- Report views: part 1 covers Hub validation, routing, room queues, shared thread-pool execution, timers/membership ordering, and independent rooms. Part 2 continues with recipient filtering, per-connection bounded queues, ordered IHubContext delivery, asynchronous persistence and result ordering, and cleanup. Matched numbering/continuation notes connect the parts. Solid/dashed meaning is explained; neither the thread pool nor persistence is drawn as a mandatory sequential processing stage. Queue limits/reconnect/host transfer remain open.
- Exports: 2× white PNGs with 16-unit borders, 1509 × 2096 and 1509 × 2197 pixels. No full historical legend is copied into these report views; the original legend remains intact.
- Verification: inspected both report PNGs and the corrected full overview. The first part-2 render exposed an overfull note, corrected before final export without reducing font size. Inspected a three-page A4 proof PDF (594.96 × 841.92 pt) and its page renders; at 16 cm width, figures are about 22.22/23.29 cm high, body labels about 12 pt, with captions within report margins. XML, IDs, references, relative edges, preservation checks, and `git diff --check` passed.
- Limits: temporary A4 proof is `/tmp/c4-report-a4-proofs.pdf`; actual Google Docs insertion remains to be checked. Container/Component layout, report prose, implementation evidence, and unresolved policies are pending. No application tests run.


## 2026-11-13 — Prepare an overview-preserving split demo before image export

- Request: the user rejected the appearance of the newly composed concurrency report images and requested a dividing line on the current overview, with continuity connections and a demo before image export. This supersedes treating the prior split PNGs as accepted report visuals.
- Demo: `/tmp/c4-concurrency-split-demo.drawio.xml`, a temporary one-page editable copy of the current `server-concurrency-overview`. All original overview elements, wording, styles, geometry, and routes are preserved; only additive demo annotations and a larger demo page height are used. Repository concurrency sources/images were not modified in this step.
- Proposed cut: a red vertical page divider at x=1660 through the processing region, between room processors and recipient filtering. Matched A–A/B–B/C–C/D–D markers identify async persistence, room-1 output, room-2 output, and the queue-to-sender return path. Common thread-pool/explanatory material applies to both regions. The divider is a page annotation, not a message path or process boundary.
- Verification: XML parsing, unique IDs, references, relative edge geometry, and canonical comparison of every original overview element passed. No concurrency PNG was exported, as requested; rendered appearance and eventual page fit are not yet verified.
- Pending: user review of the demo, placement corrections if needed, final two-part layout/export and corresponding report-guide revisions. Prior split PNGs and insertion guidance remain historical drafts pending replacement. Container/Component optimization remains deferred. The temporary demo is not a durable repository deliverable.


## 2026-11-13 — Put the vertical-swimlane demo in the original draw.io file

- Authorization: the user requested vertical swimlanes and a new page in the original XML instead of a separate demo file.
- Files changed: `c4-model.drawio.xml` and this log; root `agent.md` records the shared summary.
- Added page `Xử lý đồng thời — Demo swimlane dọc`, stable ID `concurrency-vertical-swimlane-demo`. The file now has seven pages. All six existing pages, including the original overview and historical swimlane, are byte-for-byte unchanged.
- New demo: two actual swimlane containers arranged as vertical columns with top headers. Lane 1 contains client reception, Hub, routing, room queues, and the sender; lane 2 contains recipient filtering, outbound queues, persistence, and SQL Server. Common thread-pool and explanatory material stays outside the lanes. Reparented copied nodes with coordinate compensation; retained all original connection endpoints, labels, and route topology. Paired A–D markers identify cross-lane persistence, room outputs, and the queue-to-sender return path. Lane membership describes presentation regions of the same architecture, not different processes or threads.
- Verification: XML parsing, seven-page count, unique IDs, parent/source/target references, relative edge geometry, node containment below lane headers, original edge endpoint/label comparison, and byte-for-byte preservation of every pre-existing page passed. `git diff --check` passed.
- Limits: no PNG exported and no rendered visual check performed, per the demo-first request. The user should review the new tab before approving final page fit/export. The old temporary divider demo is superseded; it is not the source for further work. Container/Component optimization remains pending.


## 2026-11-13 — Compact and visually verify the vertical-swimlane demo

- Authorization: the user requested space optimization and correction of overlapping text/arrows on the current demo, within the previously approved concurrency refinement scope.
- Files changed: `c4-model.drawio.xml` (only `concurrency-vertical-swimlane-demo`) and this log; root `agent.md` records the shared summary.
- Layout: reduced the demo canvas from 2750 × 2660 to 2300 × 1910 (about 40% less area). Arranged the model brief/thread-pool explanation side by side; aligned client/Hub rows, room processors, and lane headers; compacted the lower send path and grouped supporting notes. Increased most process text to 18px and connector text to 17px, with explicit label widths and deliberate offsets.
- Continuity: converted A–D circles from overlays into actual connector endpoints. Each original cross-lane connection now follows its matched marker pair, so lines stop at circle borders instead of crossing letters. Added eight connecting segments while preserving logical source-to-target paths, arrow directions, dashed persistence meaning, and all existing process/annotation wording.
- Verification: inspected before/after temporary draw.io renders, including a final correction narrowing invocation labels and moving C off a vertical segment. Final preview has no visible label/box collisions or lines through marker text. XML, IDs, references, relative edges, lane child containment, approximate connector-label/box bounds, and traversal comparisons of every original connection and label passed. All six other page blocks are byte-for-byte unchanged. `git diff --check` passed.
- Limits: final preview is `/tmp/concurrency-lanes-final.png` for internal layout review only. Repository report PNGs were not regenerated; actual two-page readability/Google Docs fit and final export remain pending user review. Container/Component changes remain deferred.


## 2026-11-13 — Enlarge typography consistently across the demo lanes

- Authorization: the user explicitly requested larger fonts with care and consistency across the concurrency diagram's parts.
- Files changed: `c4-model.drawio.xml` (only `concurrency-vertical-swimlane-demo`) and this log; root `agent.md` contains the shared record.
- Typography hierarchy: title 32, both lane headers 24, all process/client/connection text and continuation letters 22, all explanatory text and connector labels 20. Removed duplicate font-size style declarations so each styled cell has exactly one font size.
- Layout: enlarged boxes, marker circles, lane-header bands, and supporting-note areas; widened the sender to match the outbound-queue width; balanced Hub/room-note line breaks and padding. Repositioned routes, labels, and continuation rows to accommodate the larger type. The canvas is now 2300 × 2120, retaining the two-lane structure. Changes to visible words were limited to line breaks; all wording and logical connections remain the same.
- Verification: inspected initial and final temporary renders. Initial Hub-header/sender crowding was corrected while retaining the chosen type sizes. Final preview shows text contained within boxes with clear marker letters and arrow labels. Checked the exact font hierarchy, single font-size declaration per cell, unchanged normalized text, edge topology/dashed/arrow semantics, lane containment, XML/IDs/references, and conservative connector-label bounds. All six other pages remain byte-for-byte unchanged. `git diff --check` passed.
- Limits: temporary final preview `/tmp/concurrency-fonts-final.png` is for review only; no repository report PNG was regenerated. Page-fit and final export remain pending, as do deferred Container/Component changes.


## 2026-11-14 — Export the approved concurrency swimlanes without a C4 filename prefix

- Authorization: the user approved exporting the current vertical-swimlane demo as two images and explicitly requested filenames without the c4 prefix.
- Files changed: `docs/diagram/concurrency-1.png`, `docs/diagram/concurrency-2.png`, `docs/diagram/server-concurrency-design-log.md`, and `agent.md`.
- Changes: exported each lane from page `concurrency-vertical-swimlane-demo` in temporary single-page copies, preserving original boxes, wording, typography, internal connectors, and matching A–D continuation endpoints. Translated global connector waypoints with the lane origin; omitted cross-page bridges. Added compact Vietnamese continuity/shared notes beneath each lane. Both PNGs use 2× rendering, a white background, and a 16-unit border.
- Outputs: part 1 2870 × 2649; part 2 1770 × 2649.
- Verification: inspected both final renders for clipping and marker continuity. Source and temporary XML parsing, unique IDs, parent/source/target references, relative edge geometry, complete A–D marker sets, and PNG signatures/dimensions passed. SHA-256 confirms the original draw.io file is unchanged. No application tests were needed for image exports.
- Limits/pending: these are architecture design exports, not implementation evidence. Actual Google Docs page fit and consistent insertion scale remain unverified; the lanes have different widths. Historical c4-prefixed draft images and report-guide references were preserved outside this scope. Pending: report insertion/reference updates; deferred Container/Component source layouts; report explanations/multi-room walkthrough; implementation/testing evidence; instructor confirmation and unresolved failure policies; final document review.


## 2026-11-14 — Remove bottom yellow notes from both concurrency exports

- Authorization: the user approved the proposal to remove the bottom yellow notes and crop the freed space in both current concurrency PNGs, with updates to both logs.
- Files changed: `docs/diagram/concurrency-1.png`, `docs/diagram/concurrency-2.png`, `docs/diagram/server-concurrency-design-log.md`, and `agent.md`.
- Changes: removed only the export-added bottom notes in temporary rendering copies; re-exported at 2× on white with a 16-unit border. All remaining diagram cells, typography, internal notes, connectors, and A–D markers are preserved. The editable repository XML is unchanged.
- Outputs: part 1 2870 × 2170; part 2 1770 × 2170.
- Verification: inspected both final renders; bottom notes are absent and lane borders/diagram elements are not clipped. Temporary XML/ID/reference and A–D marker checks passed; all remaining cells match the prior export copies. PNG signatures/dimensions and source SHA-256 preservation passed. No application tests were required.
- Limits/pending: explanatory bottom notes are omitted from the images as requested. Google Docs insertion/page fit and report references remain pending, along with deferred Container/Component source layouts, report explanations/multi-room walkthrough, implementation/testing evidence, instructor confirmation/failure policies, and final document review.

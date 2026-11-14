# Change log

## 2026-11-13 — Establish the approval workflow

- Authorization: the user explicitly requested brainstorming and approval before file changes, with changes recorded in `agent.md`.
- Files created: root-level `AGENTS.md` and `agent.md`.
- Changes: established a workflow for file-specific proposals, explicit approval, scope control, verification, and change logging.
- Verification: inspection before creation confirmed neither file existed at the repository root; contents were reviewed through the patch.
- Pending: a detailed proposal and approval for updating the C4 model in Vietnamese. `docs/diagram/c4-model.drawio.xml` was not changed during this work.

## 2026-11-13 — Set language conventions

- Authorization: the user approved updating `AGENTS.md` and recording the language convention in `agent.md`.
- Files changed: `AGENTS.md` and `agent.md`.
- Changes: require English for discussion with the user, Vietnamese for output files, and English for log files. Preserve technical names, API names, and identifiers. Translated the existing log entry into English while preserving its historical content.
- Verification: reviewed both files for consistency with the approved language convention.
- Pending: C4 diagram updates still require a detailed proposal and approval.


## 2026-11-13 — Apply approved SignalR C4 model update

- Authorization: the user approved the revised proposal selecting SignalR gameplay and Vietnamese content on Context, Container, Component, and the concurrency overview only.
- Files changed: `docs/diagram/c4-model.drawio.xml`, the three diagram design logs, and this log.
- Changes: replaced custom-TCP gameplay on selected pages with SignalR; added ten server components; translated model descriptions; retained sequential room processing and recipient-specific delivery. Logs remain in English.
- Verification: XML parsing, unique IDs, references, relative edge geometry, protected legend comparison, and byte-for-byte preservation of Class/swimlane pages passed. Rendered previews were inspected and relationship labels widened for readability. No application tests were run because this change edits architecture documents only.
- Limits: preserved notation legends remain in English; untouched Class/swimlane pages retain historical content. Current design decisions supersede older TCP statements in logs and the diagram-directory handoff. No application code, gameplay rules, or deployment configuration was changed.


## 2026-11-13 — Add Redis to C4 Container

- Authorization: user approved the specific proposal to add a planned Redis SignalR backplane to the Container page and update the two logs.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes: added a Vietnamese Redis container and Game Server → Redis relationship using `Redis protocol / TLS`, scoped to future multi-instance SignalR delivery.
- Verification: XML, unique IDs, graph references, and edge geometry passed. Rendered preview inspected. All original Container elements and legends are preserved; the other five pages remain byte-for-byte unchanged.
- Limits: documentation only; Redis, TLS, and scale-out were not configured in application code. Temporary snapshot and preview are under `/tmp`.


## 2026-11-13 — Remove Redis from C4 Container

- Authorization: user approved the removal proposal covering the Container page and two English logs.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes: removed the Redis container and Game Server → Redis relationship; deferred Redis from the current architecture.
- Verification: XML parsing, unique IDs, graph references, relative edges, absence of Redis on the Container page, preservation of all remaining elements/legends, and byte-for-byte preservation of the other five pages passed. No new render was generated.
- Limits: documentation only; no application code or deployment configuration changed.


## 2026-11-13 — Clarify Container gameplay connection labels

- Authorization: user approved the finalized proposal for HTTPS/WSS wording on the two gameplay relationships.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes: Vietnamese labels now distinguish HTTPS connection initialization, ASP.NET Core SignalR, WSS gameplay delivery, and HTTPS fallback. Widened the two labels for readability.
- Verification: XML, unique IDs, graph references, relative edges, and rendered Container preview passed. Account relationship and legends unchanged; five other pages byte-for-byte preserved.
- Limits: architecture documentation only; no implementation, transport configuration, or deployment changes.


## 2026-11-13 — Remove Google Identity from C4 Container

- Authorization: user approved removal of the optional Google Identity integration discussed for the Container page.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes: removed the external Google Identity system, its two connections, and the database Google-link reference on the Container page.
- Verification: XML, IDs, references, relative edges, absence of Google references on the target page, and preservation checks passed. All legends and five other pages are unchanged. No new render was generated.
- Limits: other pages retain historical Google references; this change is documentation only.


## 2026-11-13 — Balance C4 Container for document use

- Authorization: user approved the Container layout proposal for later Google Docs insertion.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes: aligned actors/containers, placed the architecture note beside the server, improved text sizing and connector-label spacing, reduced unused margins, and moved the intact legend below the model on a 1600 × 1470 landscape page.
- Verification: inspected the corrected rendered preview; XML, IDs, references, relative geometry, unchanged text/relationships, protected legend contents, and preservation of five other pages passed.
- Limits: Google Docs insertion itself was not tested. The final preview is `/tmp/c4-container-balanced-final.png`; no additional repository export files were created.


## 2026-11-13 — Export C4 Context without legend

- Authorization: user approved a tightly cropped, white-background Context PNG at 2× scale, excluding the legend, with this log updated.
- File created: `docs/diagram/c4-context.png` (1507 × 1227 pixels).
- Method: extracted the Context page into a temporary copy, removed the legend group and its descendants only from that copy, and rendered with a 16-unit border.
- Verification: inspected the PNG for readable content and absence of the legend; validated PNG header/dimensions and confirmed the source XML SHA-256 is unchanged.
- Limits: exported current Context content as-is, including its existing planned Google Identity integration; no source labels or architecture were edited.


## 2026-11-13 — Consolidate agent instructions at the repository root

- Authorization: the user explicitly requested removal of `docs/diagram/AGENTS.md`, use of root-level agent Markdown files only, and English contents for `AGENTS.md`.
- Files changed: `AGENTS.md`, `docs/diagram/AGENTS.md` (deleted), and `agent.md`.
- Changes: translated the root rules into English; established root-only agent instructions; removed the dependency on nested instructions; retained root-level draw.io validation and preservation requirements. Agent instructions are explicitly exempt from the Vietnamese output convention. Existing specialized design logs remain project records.
- Verification: `git diff --check` passed; file discovery confirmed that only root `AGENTS.md` and `agent.md` remain as agent Markdown files.
- Limits: report guides, diagrams, PDF, and historical design logs were not changed. Existing documentation links to the removed instructions are outside this change's scope and remain to be updated.


## 2026-11-13 — Align report guidance with the approved SignalR architecture

- Authorization: the user approved the three-file proposal to update the report outline, review checklist, and shared log.
- Files changed: `docs/midterm-report/report-structure-and-content.md`, `docs/midterm-report/formatting-and-review-checklist.md`, and `agent.md`.
- Changes: aligned architecture guidance with Minimal API and SignalR in one ASP.NET Core process, HTTPS/JSON accounts, WSS/HTTPS gameplay, state outside Hub instances, and application-managed room ordering and outbound delivery. Updated Component status to the ten logical responsibilities; replaced custom TCP framing guidance with application-message contracts and corresponding verification scenarios. Corrected the PDF link and redirected the deleted nested-instructions link to root `AGENTS.md`.
- Verification: `git diff --check` passed; all eight Markdown links across the two guides resolve. Reviewed both diffs and remaining TCP/template mentions, which now describe historical material or exclusions. Preserved open gameplay decisions and unchecked review items; did not claim application tests passed.
- Limits: SignalR acceptance against the assignment's team-developed network-stack requirement remains unconfirmed. Google Identity scope differs between Context/concurrency and Container and is explicitly documented. Diagrams, PDF, application code, root instructions, and specialized design logs were not changed in this step; pre-existing workspace changes were preserved.


## 2026-11-13 — Align architecture views without Google Identity

- Authorization: the user approved removing Google Identity from Context and concurrency, regenerating the Context PNG, and updating the two guides and three logs. The user also requested a pending-task list after each completed task.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/c4-context.png`, `docs/diagram/c4-context-design-log.md`, `docs/diagram/server-concurrency-design-log.md`, `docs/midterm-report/report-structure-and-content.md`, `docs/midterm-report/formatting-and-review-checklist.md`, and `agent.md`.
- Changes: removed the Context Google system and two relationships; removed the concurrency database Google-link wording; updated guides to the aligned scope. Refreshed the legend-free, white-background Context PNG at 2× scale (1006 × 1227 pixels). Source legends remain intact.
- Verification: XML, unique IDs, references, relative edges, exact scoped element comparisons, and byte preservation of the other four pages passed. All eight guide links resolve. Inspected draw.io-rendered Context and concurrency PNGs; checked the Context PNG header/dimensions. `git diff --check` passed.
- Limits/pending: PDF and application code unchanged; no application tests run. Concurrency preview revealed a pre-existing label overlap at the central action router, which was preserved and needs a separate layout correction. Remaining work includes report diagrams/explanations, a multi-room concurrency walkthrough, evidence-based implementation/testing claims, instructor acceptance of SignalR, unresolved failure policies, and final PDF review. Temporary renderer and previews are under `/tmp`; pre-existing workspace changes were preserved.


## 2026-11-13 — Apply approved architecture label terminology

- Authorization: the user approved label terminology following the proposed Vietnamese mapping, retaining Container and technology names. Applied to actual model elements; legends and historical pages remain protected.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/c4-context.png`, `docs/diagram/c4-context-design-log.md`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes: translated five displayed type labels on Context/Container to Người dùng and Hệ thống phần mềm. Preserved English C4 metadata by editing only display templates. Component already uses Thành phần; concurrency needed no substitutions. Regenerated the white, legend-free Context PNG at 2× scale (1006 × 1227 pixels).
- Verification: XML parsing, IDs, references, relative edges, exact comparisons of every element except the five approved label substitutions, and byte preservation of the four other pages passed. Inspected new Context and Container renders; translated labels fit. Checked PNG signature/dimensions and `git diff --check`.
- Limits/pending: legends retain English notation examples; no source geometry or application behavior changed. Pending: concurrency router label overlap, report diagrams/explanations, multi-room walkthrough, implementation/testing evidence, instructor acceptance of SignalR, unresolved failure policies, and final PDF review.


## 2026-11-13 — Fix the concurrency action-router label overlap

- Authorization: the user approved the specific proposal covering the overview connector and two logs.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/server-concurrency-design-log.md`, and `agent.md`.
- Changes: narrowed the incoming Hành động label to 80px and raised it above the connector, clearing the Định tuyến hành động title. Preserved wording, architecture, endpoints, routing, all other elements, and legends.
- Verification: XML parsing, unique IDs, graph references, relative edge geometry, and exact scoped comparisons passed; all five other pages are byte-for-byte unchanged. Inspected the corrected rendered overview. `git diff --check` passed. Temporary preview: `/tmp/c4-router-label-fixed.png`.
- Limits/pending: no application code or tests affected. Remaining tasks: report diagrams/explanations, multi-room concurrency walkthrough, evidence-based implementation/testing claims, instructor confirmation of SignalR acceptance, unresolved failure policies, and final PDF review. Preserved all pre-existing workspace changes.


## 2026-11-13 — Prepare approved Context and concurrency figures for report pages

- Authorization: the user approved the proposed overlap/page-fit work except Container and Component, which must remain pending.
- Files changed: `docs/diagram/c4-model.drawio.xml`, new `docs/diagram/c4-report.drawio.xml`, refreshed `docs/diagram/c4-context.png`, new `docs/diagram/c4-concurrency-1.png`, new `docs/diagram/c4-concurrency-2.png`, `docs/diagram/c4-context-design-log.md`, `docs/diagram/server-concurrency-design-log.md`, both Markdown report guides under `docs/midterm-report/`, and `agent.md`.
- Changes: fixed four remaining concurrency connector-label masks; created an editable three-page report source with compact Context and two linked concurrency views. Exported white 2× PNGs; documented source provenance, insertion order/width, continuation meaning, and pending Container/Component work. Increased the internal report target from 24 to 25 pages to accommodate the extra concurrency figure, updating section and chapter allocation.
- Verification: parsed both XML sources; checked page counts, unique IDs, references, and relative edges. Exact comparison confirms only four overview labels changed in the original; all five other pages, including Container/Component, and every original legend remain unchanged. Inspected all final PNGs and the full corrected overview; validated PNG dimensions and all 11 local Markdown links. Rendered and inspected three A4 PDF proofs with report margins, figures at 16 cm width, approximately 12 pt body labels, and room for captions. `git diff --check` passed.
- Limits/pending: actual Google Docs insertion and the existing report PDF are unchanged; A4 proof is temporary at `/tmp/c4-report-a4-proofs.pdf`. Container/Component optimization (including the Component database-edge label) remains pending. Also pending: report explanations and multi-room walkthrough, implementation/testing evidence, instructor confirmation of SignalR acceptance, unresolved failure policies, and final PDF review. No application code or tests changed; prior workspace changes are preserved.


## 2026-11-13 — Correct Context arrows and prepare the requested concurrency split demo

- Authorization: direct user request for dashed Context arrows and a demo dividing the current concurrency overview with continuity markers before any new concurrency image export.
- Repository files changed: `docs/diagram/c4-report.drawio.xml` (two Context arrow styles), `docs/diagram/c4-context.png`, `docs/diagram/c4-context-design-log.md`, `docs/diagram/server-concurrency-design-log.md`, and `agent.md`.
- Changes: restored dashed Context arrows and refreshed its PNG. Prepared `/tmp/c4-concurrency-split-demo.drawio.xml` from the original overview, preserving its existing elements and adding a vertical red divider with paired A–D continuity markers and Vietnamese reading notes. Prior newly composed concurrency PNGs did not meet the user's expectations and are not final accepted report visuals.
- Verification: Context style-only comparison passed; refreshed Context render inspected. Demo XML/ID/reference/edge checks and preservation comparison of every original overview element passed. `git diff --check` passed. No new concurrency image was exported; demo visual quality and future page fit remain unverified.
- Pending: review/approval of the actual-overview split demo and final export; Container/Component optimization; report explanations/multi-room walkthrough; implementation/testing evidence; instructor confirmation of SignalR; failure policies; Google Docs insertion/final PDF review. Existing report concurrency images/guidance await revision after the split is accepted.


## 2026-11-13 — Add the concurrency vertical-swimlane demo as a source-file page

- Authorization: direct user instruction to use vertical swimlanes and create a new page in the original file rather than a separate demo file.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/server-concurrency-design-log.md`, and `agent.md`.
- Changes: appended `Xử lý đồng thời — Demo swimlane dọc` (`concurrency-vertical-swimlane-demo`) with two vertical swimlane containers, the current overview's processing elements and routes, shared execution/cleanup explanations, and paired A–D continuity markers. No separate repository demo file created; the original file now has seven pages.
- Verification: XML/page count, unique IDs, references, relative edge geometry, swimlane child bounds, unchanged edge endpoints/labels, and byte-for-byte preservation of all six existing pages passed. `git diff --check` passed.
- Limits/pending: the new tab is an XML-validated demo, not a visually verified or exported deliverable. Review the swimlane split before image export; previous split report PNGs remain unaccepted drafts. Container/Component optimization, report explanations/multi-room walkthrough, implementation/testing evidence, instructor confirmation, failure policies, and Google Docs/final PDF checks remain pending.


## 2026-11-13 — Refine spacing and remove collisions in the vertical-swimlane demo

- Authorization: direct user request to optimize space and address overlapping text/arrows in the active concurrency demo, continuing the approved layout work.
- Files changed: `docs/diagram/c4-model.drawio.xml` (only the seventh/demo page), `docs/diagram/server-concurrency-design-log.md`, and `agent.md`.
- Changes: reduced canvas area about 40%, aligned boxes and rows, moved shared explanations/notes into compact bands, enlarged process/connector text, and placed arrow labels in clear space. Made the A–D continuation markers actual connector endpoints, adding eight path segments to prevent arrows crossing their letters. Preserved original wording and logical message/persistence paths.
- Verification: inspected temporary before/after/final renders; no visible text/arrow collisions remain in the final preview. XML, seven-page count, IDs, references, relative edge geometry, lane child bounds, approximate label bounds, and original source-to-target/label traversal checks passed. All six other pages remain byte-for-byte unchanged. `git diff --check` passed.
- Limits/pending: `/tmp/concurrency-lanes-final.png` is a temporary review preview; no final repository report image export was made. Pending: review and page-fit/export of the swimlane layout; deferred Container/Component optimization; report explanations/multi-room walkthrough; implementation/testing evidence; instructor confirmation; failure policies; Google Docs insertion and final PDF review. Prior split PNGs remain drafts rejected for visual presentation.


## 2026-11-13 — Enlarge and standardize concurrency-demo typography

- Authorization: direct user request for larger, carefully applied fonts consistent between both concurrency parts.
- Files changed: `docs/diagram/c4-model.drawio.xml` (demo page only), `docs/diagram/server-concurrency-design-log.md`, and `agent.md`.
- Changes: applied a uniform hierarchy of 32/24/22/20 for title/lane headers/processes and markers/notes and connectors. Enlarged affected boxes and note regions, widened the sender, balanced line breaks, and adjusted routes and label positions; removed duplicate font-size definitions. Preserved wording, the two lanes, logical connections, and continuation markers.
- Verification: inspected initial/final temporary renders and corrected the initial tight Hub/sender areas without shrinking fonts. XML, seven-page count, IDs/references/relative edges, role-based typography consistency, normalized wording, graph/arrow semantics, lane bounds, approximate label bounds, and `git diff --check` passed. All six other pages are byte-for-byte unchanged.
- Limits/pending: `/tmp/concurrency-fonts-final.png` is a temporary review preview; final report PNGs were not exported. Remaining tasks: review the swimlane demo and prepare page-fit/export; deferred Container/Component optimization; report explanations/multi-room walkthrough; implementation/testing evidence; instructor confirmation and failure policies; Google Docs insertion/final PDF review.


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


## 2026-11-14 — Compact Context/Container exports and use Kẻ giả mạo

- Authorization: the user approved the combined export-only proposal for spacing optimization, visible Imposter → Kẻ giả mạo replacement, and updates to both design logs and this log.
- Files changed: `docs/diagram/c4-container.png`, `docs/diagram/c4-context.png`, `docs/diagram/c4-container-design-log.md`, `docs/diagram/c4-context-design-log.md`, and `agent.md`.
- Changes: narrowed/rebalanced the Container boundary and model column, separated connector labels, and shortened Context's actor-to-system gap while retaining dashed arrows. Translated all four visible mode-label occurrences across the two images. Preserved font sizes and the Container title/note/legend exclusions.
- Outputs: Container 2229 × 2247; Context 1469 × 1467, both 2× on white with 16-unit border.
- Verification: inspected both final renders; temporary XML/IDs/references/relative edges, PNG signatures/dimensions, original endpoint comparisons, terminology, font-size comparisons, and `git diff --check` passed. SHA-256 confirms `c4-model.drawio.xml` and `c4-report.drawio.xml` are unchanged.
- Limits/pending: revisions affect exports only; source layout/Imposter wording remain as before. Pending: concurrency review/page-fit/export; deferred source Container/Component optimization; report explanations/multi-room walkthrough; implementation/testing evidence; instructor confirmation/failure policies; Google Docs placement/final PDF review.


## 2026-11-14 — Enlarge both architecture exports and verify document page fit

- Authorization: the user approved the two-export font proposal and explicitly required Google Docs fit.
- Files changed: `docs/diagram/c4-container.png`, `docs/diagram/c4-context.png`, `docs/diagram/c4-container-design-log.md`, `docs/diagram/c4-context-design-log.md`, and `agent.md`.
- Changes: increased Container text to 18–19 and Context body/arrows/title to 24/24/28. Reflowed the Container into a narrower portrait layout with account/database label rails, enlarged affected boxes, and balanced Context line breaks. Preserved all wording, Kẻ giả mạo labels, dashed arrows, topology, and Container annotation exclusions. Actors use 18 rather than the initially proposed 17 for document readability.
- Outputs: Container 1549 × 2357; Context 1589 × 1607, both white 2× PNGs.
- Verification: inspected both final images and two-page A4 PDF proofs (`/tmp/c4-large-type-a4-proofs.pdf`, 594.96 × 841.92 pt). At 16 cm width with left 3 cm/other 2 cm margins, each image plus caption fits a separate portrait page. Container height about 24.35 cm, type about 10.5–11.1 pt; Context height about 16.18 cm, body about 13.7 pt. Temporary XML/ID/reference/edge checks, normalized wording/topology comparisons, PNG dimensions, and `git diff --check` passed. SHA-256 confirms both repository XML sources are unchanged.
- Limits/pending: actual Google Docs placement remains unchecked and must use the verified sizing/margins with aspect ratio preserved. No application tests required. Pending: concurrency review/page-fit/export; deferred source Container/Component optimization; report explanations/multi-room walkthrough; implementation/testing evidence; instructor confirmation/failure policies; final document review.


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


## 2026-11-14 — Synchronize approved Container descriptions with minimal XML edits

- Authorization: the user explicitly approved the three-file proposal for six Container text updates only.
- Files changed: `docs/diagram/c4-model.drawio.xml`, `docs/diagram/c4-container-design-log.md`, and `agent.md`.
- Changes: applied the five finalized descriptions to Client, Server, Database, and both gameplay relationships, including explicit thời gian thực; replaced Imposter with Kẻ giả mạo in Player. Only approved description/display-template attributes were edited.
- Verification: XML/IDs/references/relative edges passed on all seven pages. Exact approved-attribute and byte-level comparison passed: six object opening tags changed; all other content, geometry, fonts, styles, connectors, legends, and six other pages are unchanged. Inspected a temporary Container render; updated text fits existing boxes. `git diff --check` passed.
- Limits/pending: no PNG regenerated. Source layout remains intentionally different from the compact export. Pending: concurrency review/page-fit/export; deferred source Container/Component layout work; report explanations/multi-room walkthrough; implementation/testing evidence; instructor confirmation/failure policies; final document review.


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


## 2026-11-14 — Remove the Context export headline

- Authorization: the user approved removing the top Draw & Guess headline and cropping the freed space in the Context PNG, with updates to both logs.
- Files changed: `docs/diagram/c4-context.png`, `docs/diagram/c4-context-design-log.md`, and `agent.md`.
- Changes: re-rendered a temporary Context copy without the title, retaining the current enlarged fonts, actor/system boxes, Vietnamese descriptions, Kẻ giả mạo terminology, dashed arrows and label alignment. Export is 1589 × 1457, 2× on white with a 16-unit border. The system name inside the system box remains.
- Verification: inspected the rendered image for clipping and text/arrow separation; temporary XML/IDs/references/relative edges and dashed styles passed. PNG signature/dimensions passed. SHA-256 confirms both repository XML sources remain unchanged. No application tests needed.
- Pending: actual Google Docs placement and report references; deferred Container source layout; Context source/export terminology synchronization; architecture evidence, unresolved policies/instructor confirmation, and final report review.

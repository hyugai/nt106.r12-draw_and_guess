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

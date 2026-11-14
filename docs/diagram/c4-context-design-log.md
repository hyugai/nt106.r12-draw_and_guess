# C4 Context design log

Date: 2026-11-07

Status: Approved by the user and applied to the C4 Context page on 2026-11-07.

Target file: `c4-model.drawio.xml`
Target page: `C4 Context`
Proposed title: **Draw & Guess Game — System Context**

## Confirmed requirements

- The multiplayer Draw & Guess Game supports Normal and Imposter modes.
- Users must register and sign in before playing.
- Google sign-in is supported.
- Keywords come from the system's default pool, with the system selecting the
  keyword instead of the host supplying it.
- In Imposter mode, there are n players. All except the imposter know the keyword.
  Non-imposters draw strokes representing parts of the keyword on their turns.
  The imposter tries to infer the keyword and blend in. Players vote to identify
  the imposter, who is then revealed, and the system determines the winning side.

## Proposed context elements

| Element | Type | Description |
| --- | --- | --- |
| Player | Person | A registered user who joins rooms, plays Normal and Imposter modes, draws, guesses, votes when applicable, and views results. |
| Host | Person | A registered player who creates rooms, selects the game mode, and starts games. Also participates as a player. |
| Draw & Guess Game | Software System | An online multiplayer game that manages accounts, rooms, real-time drawing and guessing, Normal and Imposter modes, voting, scoring, and results. |
| Google Identity | External Software System | Provides Google sign-in to authenticate users. |

Host responsibilities above were included in the approved design.
Host is a Player role; the separate actor highlights room-hosting interactions.
No UML inheritance arrow is proposed for this context diagram.

## Proposed relationships

| From | To | Label |
| --- | --- | --- |
| Player | Draw & Guess Game | Registers, signs in, joins rooms, plays games, and views results |
| Host | Draw & Guess Game | Creates rooms, selects the game mode, and starts games |
| Player | Google Identity | Signs in with Google |
| Draw & Guess Game | Google Identity | Uses Google to authenticate users |

The Host also has Player interactions, including Google sign-in. A duplicate
Host-to-Google relationship is omitted for readability.

## Scope and layout

- Keep Normal and Imposter modes inside the Game system, rather than drawing
  them as separate software systems.
- Keep the keyword pool, hidden-role assignment, keyword distribution, drawing
  turns, voting, imposter reveal, scoring, and win determination inside the Game.
- System-selected keywords allow the host to be eligible for the imposter role.
- Place Player and Host above the Game, with Google Identity to the right.
- Use the existing legend's Person, blue Software System, gray external Software
  System, and Relationship styles.
- Replace the obsolete `Status Dashboard (Context)` title and actual-model
  relationship placeholders. Do not replace example labels in the legend.
- Position the actual diagram elements within the page without moving the legend.
- Limit eventual diagram edits to the C4 Context page.

## Legend preservation

Follow `AGENTS.md`. Leave the complete Legend group
`GGAcaCNyiWMHBxoHMokF-1` and all descendants unchanged, including labels,
attributes, styles, geometry, and edges, unless the user explicitly requests
changes to the legend. Its placeholder labels are intentional notation examples.

## Gameplay details still unspecified

These details do not block the proposed system context, but must not be invented
in later detailed designs:

- Normal mode's exact turn structure and scoring rules.
- Whether the imposter draws on their own turn.
- Voting ties and exact winning-side conditions.

## Application record

The user authorized application with “now apply changes”. The design above has
been applied to `c4-model.drawio.xml` on the `C4 Context` page.

- Updated the title, Player and Host descriptions, Game description, and existing
  relationships.
- Added Google Identity as an external software system and both approved Google
  sign-in relationships.
- Removed technology placeholders from actual model relationships.
- Positioned the model within the page above the preserved legend.
- Verified that the entire legend and all other pages remain unchanged.
- XML parsing, unique ID checks, relationship references, and the XML repair pass
  succeeded. No draw.io Desktop CLI was available for a rendered preview.

### Description readability fix

After the user reported overlapping Player and Host descriptions, added explicit
HTML line breaks and compact text sizing, and corrected `whitespace=wrap` to
`whiteSpace=wrap` on those two model actors. Kept their geometry unchanged.
XML validation passed; the legend, relationships, and other pages were verified
unchanged. Rendered appearance still needs confirmation in the draw.io editor.

### Layout spacing adjustment

At the user's explicit request to move the legend farther away and increase the
distance between people and the software system:

- Moved the Game and Google Identity to Y=450, giving a 220px vertical gap below
  Player and Host.
- Moved the entire legend group to Y=820, giving a 235px gap below the systems.
- Preserved all legend contents, styling, internal positions, and size. This
  user-authorized group move is an exception to the default legend position rule.
- Verified that only these three Y coordinates changed in the diagram, and that
  XML validation passed. All other pages remain unchanged.


## 2026-11-13 — Approved Vietnamese context labels

The user approved the revised four-page update. Translated actual Context model names, descriptions, and relationships into Vietnamese; clarified Host as a Player role and Google sign-in as planned integration. Preserved page identity, geometry, and the complete notation legend. This is a design update, not evidence of implemented features. XML, IDs, references, legend preservation, and rendered preview checks passed.


## 2026-11-13 — Remove Google Identity and refresh Context export

- Authorization: the user approved removing Google Identity from Context and concurrency, refreshing the Context PNG, and updating the guides and logs.
- Files: `c4-model.drawio.xml` (Context page), `c4-context.png`, and this log; related guide/shared-log changes are recorded in root `agent.md`.
- Removed the Google Identity system and its Player/Game relationships. All remaining Context elements, including the complete legend, are preserved. Four unrelated pages are byte-for-byte unchanged; the concurrency SQL label is the only other diagram change.
- Exported a temporary Context-only copy with the legend and its descendants removed from that copy, white background, 2× scale, and 16-unit border using draw.io 32.6.10. Refreshed repository PNG: 1006 × 1227 pixels. The editable source retains its legend.
- Verification: XML parsing, unique IDs, references, relative edge geometry, exact scoped element comparisons, unrelated-page byte comparisons, and PNG header/dimensions passed. Inspected the regenerated Context PNG: labels are readable, with no Google Identity or legend.
- Limits: documentation only; no authentication implementation changed. Existing historical log entries are retained and superseded for current Google Identity scope.


## 2026-11-13 — Apply approved Vietnamese type labels

- Authorization: the user approved the proposed label terminology: Person → Người dùng, Software System → Hệ thống phần mềm, Component → Thành phần, retaining Container and technology names.
- Files: `c4-model.drawio.xml` (Context displayed labels), `c4-context.png`, and this log; Container changes are recorded in its log.
- Changes: translated the two actual actor type labels and the game system type label. Retained English `c4Type` metadata for tool compatibility; only display templates changed. Refreshed the white, legend-free Context PNG at 2× scale, 16-unit border, 1006 × 1227 pixels.
- Verification: XML, unique IDs, references, relative edges, exact element comparisons, and unrelated-page byte comparisons passed. Inspected the new Context render; translated labels fit and are readable. PNG signature/dimensions checked.
- Limits: legends remain in English under their existing preservation scope. Names, descriptions, geometry, technologies, and architecture did not change.


## 2026-11-13 — Create the compact Context report view

- Authorization: the user approved Context/concurrency page-fit work while explicitly leaving Container and Component optimization pending.
- Files: new `c4-report.drawio.xml` (Context page), refreshed `c4-context.png`, and this log. Related concurrency, report-guide, and shared-log changes are recorded in their corresponding files.
- Changes: created a compact report-specific Context with larger type, shorter actor-to-system paths, the same two actor roles and system responsibilities, and no Google integration. Kept the original editable Context and its legend byte-for-byte unchanged. The report copy omits the full template legend.
- Export: draw.io 32.6.10 PNG, white background, 2× scale, 16-unit border; 1506 × 1607 pixels. The existing PNG now derives from the Context page of `c4-report.drawio.xml`; the guide records both sources and the need to keep architecture changes aligned.
- Verification: inspected the PNG and its A4 PDF proof at 16 cm insertion width, with 3 cm left and 2 cm other margins. Figure height is about 17.07 cm, body labels about 12 pt, and caption fits. XML/IDs/references/edges and original-page preservation passed; source legends are intact.
- Limits: actual Google Docs insertion and the existing report PDF remain untested/unchanged. Container and Component report layouts remain pending.


## 2026-11-13 — Restore dashed Context relationships in the report copy

- Authorization: the user explicitly requested dashed Context arrows.
- Files: `c4-report.drawio.xml` (only `ctx-play` and `ctx-start` styles), refreshed `c4-context.png`, and this log.
- Changes: set dashed relationships with a 6/4 dash pattern. The original Context in `c4-model.drawio.xml` already uses dashed arrows and needed no change.
- Verification: exact comparison confirms only the two report relationship styles changed; both report concurrency pages are preserved. XML/IDs/references passed. Inspected the refreshed 2× Context PNG; arrows are dashed and labels readable. `git diff --check` passed.
- Limits: no concurrency images were regenerated in this step.


## 2026-11-14 — Tighten Context spacing and translate the mode label in the export

- Authorization: the user approved adding Context to the export-only spacing/terminology revision, retaining dashed arrows, source XML, and font sizes.
- Files: `c4-context.png` and this log; root `agent.md` records both exports.
- Changes in the temporary copy of report Context: reduced the actor-to-system gap from 190 to 120 units, balanced horizontal placement, adjusted arrow labels, and replaced the two visible Imposter occurrences with Kẻ giả mạo. Retained its title, dashed relationships, all responsibilities, and font sizes.
- Output: white, 2× PNG with 16-unit border, 1469 × 1467 pixels (previously 1506 × 1607).
- Verification: inspected the final PNG for readable Vietnamese text, clipping, arrow-label separation, and compact crop. Temporary XML/IDs/references/relative edges, terminology, unchanged font sizes, and original edge endpoints passed. Both editable source hashes are unchanged. `git diff --check` passed.
- Limits: the export differs from its editable source in layout and the translated mode wording; XML files were deliberately preserved under the approved scope. Google Docs insertion remains pending.


## 2026-11-14 — Enlarge Context export typography for document use

- Authorization: the user approved enlarging both exports with care for visual quality and Google Docs page fit, preserving source XML.
- Files: `c4-context.png` and this log; root `agent.md` records both outputs.
- Changes in temporary export copy: body/arrow type 24 and title 28; enlarged actor/system boxes, rebalanced the gap and labels, and inserted balanced description breaks so Vẽ đoán is not split awkwardly. Preserved all visible wording, Kẻ giả mạo terminology, dashed arrows, and logical relationships.
- Output: 1589 × 1607 PNG at 2×, white background, 16-unit border.
- Verification: inspected final render and its A4 portrait proof at 16 cm width, report margins (left 3 cm, others 2 cm), with caption. Figure height about 16.18 cm; body text about 13.7 pt at insertion size. No clipping/overlap seen. XML/IDs/references/relative edges, normalized wording, endpoints, PNG signature/dimensions, unchanged source hashes, and `git diff --check` passed.
- Limits: actual Google Docs insertion remains to be checked; preserve aspect ratio and use one image per page. Both editable XML files are unchanged.

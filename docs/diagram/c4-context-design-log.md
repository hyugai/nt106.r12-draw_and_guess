# C4 Context design log

Date: 2026-11-07

Status: Approved by the user and applied to the C4 Context page on 2026-11-07.

Target file: `system-context-diagram.drawio.xml`
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
been applied to `system-context-diagram.drawio.xml` on the `C4 Context` page.

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

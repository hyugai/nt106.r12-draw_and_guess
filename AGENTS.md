# Repository working rules

## Scope

These rules apply to the entire repository. Use only the root-level agent Markdown files: `AGENTS.md` for instructions and `agent.md` for the shared change log. Do not create or rely on nested agent instruction files. Direct user instructions take precedence in case of conflict.

## Proposals and approval before changes

1. You may read, search, and analyze files to prepare a proposal without permission. Do not perform writes during this preparation stage.
2. Before creating, modifying, deleting, renaming, or moving any file, present a proposal for the user to review. Identify each file path, the problem to solve, the intended changes, significant choices or tradeoffs, and the verification method.
3. After presenting the proposal, stop and wait for explicit user approval. A general request such as “update the diagram” does not replace approval of a specific proposal; silence is not consent.
4. Apply changes only within the approved scope. Do not ask again for the same approved proposal. If additional files or changes become necessary, present a supplementary proposal and wait for approval before applying that part.
5. Preserve the user's existing changes. Do not revert, overwrite, or clean up files outside the approved scope.
6. This workflow applies to source code, documentation, diagrams, configuration, and agent instruction files themselves. Do not bypass approval with tools or commands that write implicitly.

## Implementation and verification

- Use English when communicating and discussing proposals with the user, including proposals, approval questions, progress updates, and completion reports.
- Use Vietnamese for output file contents, including documentation and diagram labels, except that agent instructions and logs use English. Preserve necessary technology names, API names, and identifiers.
- Run checks appropriate to the approved changes. If a verification tool creates or modifies files in the repository, include those outputs in the proposal before running it.
- Distinguish planned design, implemented functionality, and verified results. Do not settle unresolved gameplay rules independently or claim tests passed without running them.
- For draw.io files, validate XML, IDs, and references, and preserve pages and legends outside the approved scope.

## Logging after changes

- Use the root-level `agent.md` as the shared change log; do not confuse it with `AGENTS.md`, which contains instructions.
- Write logs in English, including `agent.md` and specialized design logs.
- Include updates to `agent.md` and any relevant specialized logs in each proposal. Once the user approves that proposal, update the logs after implementation and verification; do not request approval again for the same proposed log entry.
- Each entry must record the date, request or approval basis, changed files, main changes, verification results, and limitations or pending work.
- Append entries only; preserve prior history. Do not log secrets, tokens, or sensitive information.
- Continue updating specialized design logs when included in the approved scope; the shared log does not replace them. Existing design logs remain project records, not nested agent instruction files.

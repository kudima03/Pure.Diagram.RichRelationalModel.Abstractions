# Changelog

All notable changes to Pure.Diagram.RichRelationalModel.Abstractions are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.1.0.0] — 2026-04-19

### Changed

- **Breaking:** `ISeriesRichRelationalModel` renamed to `IDiagramSeriesRichRelationalModel`,
  and now extends `IDiagramSeries` and `IDiagramSeriesRelationalModel` instead of
  `ISeries` and `ISeriesRelationalModel`.
- Updated the `Pure.Diagram.Model.Abstractions` dependency to `0.1.0-preview.1.0.0`.
- Updated the `Pure.Diagram.RelationalModel.Abstractions` dependency to
  `0.1.0-preview.2.0.0`.

## [0.1.0-preview.0.1.0] — 2026-02-12

Initial release.

### Added

- **`IDiagramRichRelationalModel`** — combines `IDiagram` and
  `IDiagramRelationalModel`.
- **`ISeriesRichRelationalModel`** — combines `ISeries` and
  `ISeriesRelationalModel`.
- **`IDiagramTypeRichRelationalModel`** — combines `IDiagramType` and
  `IDiagramTypeRelationalModel`.

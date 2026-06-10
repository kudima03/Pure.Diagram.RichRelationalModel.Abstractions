# Pure.Diagram.RichRelationalModel.Abstractions

Combined diagram domain-model and relational-model interfaces for the **Pure** ecosystem.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.Abstractions/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.Abstractions/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.Abstractions/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.Abstractions/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.RichRelationalModel.Abstractions)](https://www.nuget.org/packages/Pure.Diagram.RichRelationalModel.Abstractions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.RichRelationalModel.Abstractions` defines interfaces that each merge a diagram domain-model interface (navigation properties, human-readable semantics) with its relational-model counterpart (identity via `IGuid`, foreign-key columns). The result is a *rich* view suitable for EF Core entity types or any persistence layer that needs both navigation and flat relational identity on the same object.

## Interfaces

| Interface | Extends | Description |
|---|---|---|
| `IDiagramRichRelationalModel` | `IDiagram`, `IDiagramRelationalModel` | Diagram entity with title, description, type navigation, series collection, plus `Id` and `TypeId` FK columns |
| `IDiagramSeriesRichRelationalModel` | `IDiagramSeries`, `IDiagramSeriesRelationalModel` | Diagram series entity with label, source, plus `Id` and `DiagramId` FK |
| `IDiagramTypeRichRelationalModel` | `IDiagramType`, `IDiagramTypeRelationalModel` | Diagram-type entity with `Name` property plus `Id` |

## Design Principles

- **Dual surface** — each interface satisfies both the structural domain model and the relational model contracts simultaneously.
- **Immutable** — inherited from both contract families; all properties are read-only.

## Dependencies

- [`Pure.Diagram.Model.Abstractions`](https://github.com/kudima03/Pure.Diagram.Model.Abstractions) — diagram domain interfaces
- [`Pure.Diagram.RelationalModel.Abstractions`](https://github.com/kudima03/Pure.Diagram.RelationalModel.Abstractions) — diagram relational model interfaces

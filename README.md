[![](https://img.shields.io/nuget/v/Soenneker.Dtos.IdNamePair.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Dtos.IdNamePair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamepair/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamepair/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Dtos.IdNamePair.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Dtos.IdNamePair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamepair/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamepair/actions/workflows/codeql.yml)

# Soenneker.Dtos.IdNamePair

Provides a compact API reference to another resource using its stable identifier and human-readable display name.

## Install

```bash
dotnet add package Soenneker.Dtos.IdNamePair
```

## What you get

- `IdNamePair` — Provides a compact API reference to another resource using its stable identifier and human-readable display name.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `IdNamePair.Id` | Stable unique identifier of the referenced resource. | Stable unique identifier of the referenced resource. |
| `IdNamePair.Name` | Human-readable display name of the referenced resource. | Human-readable display name of the referenced resource. |

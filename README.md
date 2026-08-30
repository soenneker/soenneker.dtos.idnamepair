[![](https://img.shields.io/nuget/v/Soenneker.Dtos.IdNamePair.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Dtos.IdNamePair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamepair/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamepair/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Dtos.IdNamePair.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Dtos.IdNamePair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamepair/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamepair/actions/workflows/codeql.yml)

# Soenneker.Dtos.IdNamePair

Represents a compact resource reference containing an identifier and display name.

## Installation

```bash
dotnet add package Soenneker.Dtos.IdNamePair
```

## Usage

```csharp
using Soenneker.Dtos.IdNamePair;

var owner = new IdNamePair
{
    Id = "user-42",
    Name = "Ada Lovelace"
};
```

Both System.Text.Json and Newtonsoft.Json serialize the record as:

```json
{
  "id": "user-42",
  "name": "Ada Lovelace"
}
```

`required` enforces property assignment for normal C# construction, and `[Required]` supplies validation metadata. Neither mechanism validates identifier format, trims names, enforces uniqueness, or guarantees that deserialized input is valid; run your application’s validator at trust boundaries.

Because this is a record, equality and hash codes include `Id` and `Name`. Both properties are mutable, so do not change them while an instance is being used as a dictionary key or stored in a hash set. Use `with` to create a changed copy when stable value semantics matter:

```csharp
IdNamePair renamed = owner with {Name = "Ada Byron"};
```

The type is marked with `PublicOpenApiObject` for Soenneker OpenAPI discovery.

# Query Abstraction Migration

Domos contracts previously exposed EF6 `IDbSet<T>` so EF6 extension methods were available to application logic. The current contracts expose `IEntitySet<T>` instead.

Consumers should import `Grammophone.DataAccess.QueryExtensions` for query shaping and async terminal methods.

Typical migration steps:

- Replace `using System.Data.Entity;` with `using Grammophone.DataAccess.QueryExtensions;` where the import was only needed for query methods.
- Replace `IDbSet<T>` parameters with `IEntitySet<T>` where provider-specific APIs are not required.
- Rewrite EF6 collection includes using `Select` to portable `ThenInclude` chains.
- Register provider-specific adapters as the Domos domain-container contracts.

The result is query code that can run over EF6 or EF Core through the same Domos logic layer.

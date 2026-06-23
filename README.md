# Grammophone.Domos.DataAccess

`Grammophone.Domos.DataAccess` defines provider-neutral domain-container contracts for the Domos entity model.

The contracts derive from `Grammophone.DataAccess.IDomainContainer` and expose `IEntitySet<T>` properties for users, roles, workflow, accounting, funds transfer and optional invoice entities. Application logic consumes these contracts rather than Entity Framework `DbContext`, EF6 `DbSet` or EF Core `DbSet` types.

## Main Features

- `IUsersDomainContainer<U>` exposes user, role, disposition, credential, session and file metadata sets.
- `IWorkflowUsersDomainContainer<U, BST>` adds workflow graph, state, path and transition sets.
- `IDomosDomainContainer<U, BST, P, R, J>` adds accounting and funds transfer sets.
- `IDomosDomainContainer<U, BST, P, R, J, ILTC, IL, IE, I>` adds optional invoice sets.
- Query code should use `Grammophone.DataAccess.QueryExtensions` for portable includes, async terminal methods and set operations.

## Documentation

- [Overview](documentation/overview.md)
- [Domain container contracts](documentation/domain-container-contracts.md)
- [Query abstraction migration](documentation/query-abstraction-migration.md)

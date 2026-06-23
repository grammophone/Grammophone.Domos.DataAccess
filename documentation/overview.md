# Overview

`Grammophone.Domos.DataAccess` defines the provider-neutral repository surface for Domos.

The interfaces derive from `IDomainContainer` and expose `IEntitySet<T>` properties. This keeps application logic independent of EF6 `DbSet`, EF Core `DbSet` or any other provider-specific query object.

The contracts are layered to match Domos feature levels:

- `IUsersDomainContainer<U>` for user/security-related entities.
- `IWorkflowUsersDomainContainer<U, BST>` for workflow-enabled systems.
- `IDomosDomainContainer<U, BST, P, R, J>` for accounting and funds transfer.
- `IDomosDomainContainer<U, BST, P, R, J, ILTC, IL, IE, I>` for optional invoices.

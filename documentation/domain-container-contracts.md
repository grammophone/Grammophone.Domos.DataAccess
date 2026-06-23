# Domain Container Contracts

`IUsersDomainContainer<U>` exposes sets for users, registrations, roles, dispositions, content types, disposition types, WebAuthn credentials, browser sessions and client IP addresses.

`IWorkflowUsersDomainContainer<U, BST>` adds workflow states, groups, paths, transitions and graphs.

`IDomosDomainContainer<U, BST, P, R, J>` adds accounts, credit systems, journals, postings, remittances, funds transfer requests, funds transfer events, batches, batch messages and request groups.

The invoice-enabled `IDomosDomainContainer` overload adds invoices, invoice events, invoice lines and invoice line tax components.

Provider implementations should expose these contracts through adapters, not by making provider contexts themselves the application-facing contract.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grammophone.DataAccess;
using Grammophone.Domos.Domain;
using Grammophone.Domos.Domain.Accounting;
using Grammophone.Domos.Domain.Workflow;

namespace Grammophone.Domos.DataAccess
{
	/// <summary>
	/// Abstract repository of a Domos repository,
	/// containing users, roles, accounting, workflow, managers and permissions.
	/// </summary>
	/// <typeparam name="U">
	/// The type of users, derived from <see cref="User"/>.
	/// </typeparam>
	/// <typeparam name="BST">
	/// The base type of the system's state transitions, derived from <see cref="StateTransition{U}"/>.
	/// </typeparam>
	/// <typeparam name="P">The type of the postings, derived from <see cref="Posting{U}"/>.</typeparam>
	/// <typeparam name="R">The type of remittances, derived from <see cref="Remittance{U}"/>.</typeparam>
	/// <typeparam name="J">
	/// The type of accounting journals, derived from <see cref="Journal{U, ST, P, R}"/>.
	/// </typeparam>
	public interface IDomosDomainContainer<U, BST, P, R, J> : IWorkflowUsersDomainContainer<U, BST>
		where U : User
		where BST : StateTransition<U>
		where P : Posting<U>
		where R : Remittance<U>
		where J : Journal<U, BST, P, R>
	{
		/// <summary>
		/// Entity set of accounts in the system.
		/// </summary>
		IEntitySet<Account> Accounts { get; }

		/// <summary>
		/// Entity set of credit systems in the system.
		/// </summary>
		IEntitySet<CreditSystem> CreditSystems { get; }

		/// <summary>
		/// Entity set of accounting journals in the system.
		/// </summary>
		IEntitySet<J> Journals { get; }

		/// <summary>
		/// Entity set of the accounting postings in the system.
		/// </summary>
		IEntitySet<P> Postings { get; }

		/// <summary>
		/// Entity set of the accounting remittances in the system.
		/// </summary>
		IEntitySet<R> Remittances { get; }

		/// <summary>
		/// The Electronic Funds Transfer (EFT/ACH) requests in the system.
		/// </summary>
		IEntitySet<FundsTransferRequest> FundsTransferRequests { get; }

		/// <summary>
		/// The events taking place for <see cref="FundsTransferRequests"/> in the system.
		/// </summary>
		IEntitySet<FundsTransferEvent> FundsTransferEvents { get; }

		/// <summary>
		/// Batches of <see cref="FundsTransferRequest"/>s.
		/// </summary>
		IEntitySet<FundsTransferBatch> FundsTransferBatches { get; }

		/// <summary>
		/// Messages recording the history of <see cref="FundsTransferBatches"/>.
		/// </summary>
		IEntitySet<FundsTransferBatchMessage> FundsTransferBatchMessages { get; }

		/// <summary>
		/// The set of funds transfer request groups in the system.
		/// </summary>
		IEntitySet<FundsTransferRequestGroup> FundsTransferRequestGroups { get; }
	}

	/// <summary>
	/// Abstract repository of a Domos repository,
	/// containing users, roles, accounting, workflow, managers and permissions.
	/// </summary>
	/// <typeparam name="U">
	/// The type of users, derived from <see cref="User"/>.
	/// </typeparam>
	/// <typeparam name="BST">
	/// The base type of the system's state transitions, derived from <see cref="StateTransition{U}"/>.
	/// </typeparam>
	/// <typeparam name="P">The type of the postings, derived from <see cref="Posting{U}"/>.</typeparam>
	/// <typeparam name="R">The type of remittances, derived from <see cref="Remittance{U}"/>.</typeparam>
	/// <typeparam name="J">
	/// The type of accounting journals, derived from <see cref="Journal{U, ST, P, R}"/>.
	/// </typeparam>
	/// <typeparam name="ILTC">The type of invoice line tax components, derived from <see cref="InvoiceLineTaxComponent{U, P, R}"/>.</typeparam>
	/// <typeparam name="IL">The type of invoice line, derived from <see cref="InvoiceLine{U, P, R, ILTC}"/>.</typeparam>
	/// <typeparam name="IE">The type of invoice event, derived from <see cref="InvoiceEvent{U, P, R}"/>.</typeparam>
	/// <typeparam name="I">The type of invoices, derived from <see cref="Invoice{U, P, R, ILTC, IL, IE}"/>.</typeparam>
	public interface IDomosDomainContainer<U, BST, P, R, J, ILTC, IL, IE, I> : IDomosDomainContainer<U, BST, P, R, J>
		where U : User
		where BST : StateTransition<U>
		where P : Posting<U>
		where R : Remittance<U>
		where J : Journal<U, BST, P, R>
		where ILTC : InvoiceLineTaxComponent<U, P, R>
		where IL : InvoiceLine<U, P, R, ILTC>
		where IE : InvoiceEvent<U, P, R>
		where I : Invoice<U, P, R, ILTC, IL, IE>
	{
		/// <summary>
		/// The set of invoices in the system.
		/// </summary>
		IEntitySet<I> Invoices { get; }

		/// <summary>
		/// The set of invoice events in the system.
		/// </summary>
		IEntitySet<IE> InvoiceEvents { get; }

		/// <summary>
		/// The set of invoice lines in the system.
		/// </summary>
		IEntitySet<IL> InvoiceLines { get; }

		/// <summary>
		/// The set of invoice line tax components in the system.
		/// </summary>
		IEntitySet<ILTC> InvoiceLineTaxComponents { get; }
	}
}

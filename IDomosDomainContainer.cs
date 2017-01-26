using System;
using System.Collections.Generic;
using System.Data.Entity;
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
	/// <typeparam name="A">The type of accounts, derived from <see cref="Account{U}"/>.</typeparam>
	/// <typeparam name="P">The type of the postings, derived from <see cref="Posting{U, A}"/>.</typeparam>
	/// <typeparam name="R">The type of remittances, derived from <see cref="Remittance{U, A}"/>.</typeparam>
	/// <typeparam name="J">
	/// The type of accounting journals, derived from <see cref="Journal{U, ST, A, P, R}"/>.
	/// </typeparam>
	public interface IDomosDomainContainer<U, BST, A, P, R, J> : IWorkflowUsersDomainContainer<U, BST>
		where U : User
		where BST : StateTransition<U>
		where A : Account<U>
		where P : Posting<U, A>
		where R : Remittance<U, A>
		where J : Journal<U, BST, A, P, R>
	{
		/// <summary>
		/// Entity set of accounts in the system.
		/// </summary>
		IDbSet<A> Accounts { get; }

		/// <summary>
		/// Entity set of credit systems in the system.
		/// </summary>
		IDbSet<CreditSystem> CreditSystems { get; }

		/// <summary>
		/// Entity set of accounting journals in the system.
		/// </summary>
		IDbSet<J> Journals { get; }

		/// <summary>
		/// Entity set of the accounting postings in the system.
		/// </summary>
		IDbSet<P> Postings { get; }

		/// <summary>
		/// Entity set of the accounting remittances in the system.
		/// </summary>
		IDbSet<R> Remittances { get; }

		/// <summary>
		/// The Electronic Funds Transfer (EFT/ACH) requests in the system.
		/// </summary>
		IDbSet<FundsTransferRequest> FundsTransferRequests { get; }

		/// <summary>
		/// The events taking place for <see cref="FundsTransferRequests"/> in the system.
		/// </summary>
		IDbSet<FundsTransferEvent> FundsTransferEvents { get; }
	}
}

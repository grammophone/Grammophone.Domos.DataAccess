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
	/// <typeparam name="ST">
	/// The type of state transitions, derived from <see cref="StateTransition{U}"/>.
	/// </typeparam>
	public interface IDomosDomainContainer<U, ST> : IWorkflowUsersDomainContainer<U, ST>
		where U : User
		where ST : StateTransition<U>
	{
		/// <summary>
		/// Entity set of accounts in the system.
		/// </summary>
		IDbSet<Account> Accounts { get; }

		/// <summary>
		/// Entity set of accounting batches in the system.
		/// </summary>
		IDbSet<Batch> Batches { get; }

		/// <summary>
		/// Entity set of credit systems in the system.
		/// </summary>
		IDbSet<CreditSystem> CreditSystems { get; }

		/// <summary>
		/// Entity set of accounting journals in the system.
		/// </summary>
		IDbSet<Journal> Journals { get; }

		/// <summary>
		/// Entity set of accounting journal lines in the system.
		/// </summary>
		IDbSet<JournalLine> JournalLines { get; }
	}
}

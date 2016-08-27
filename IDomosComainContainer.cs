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
	/// The type of users. Must be derived from <see cref="User"/>.
	/// </typeparam>
	public interface IDomosComainContainer<U> : IDomainContainer
		where U : User
	{
		#region Users, segregations, dispositions and security

		/// <summary>
		/// Entity set of users in the system.
		/// </summary>
		IDbSet<U> Users { get; }

		/// <summary>
		/// Entity set of registrations in the system.
		/// </summary>
		IDbSet<Registration> Registrations { get; }

		/// <summary>
		/// Entity set of roles in the system.
		/// </summary>
		IDbSet<Role> Roles { get; }

		/// <summary>
		/// Entity set of entity accesses in the system,
		/// only used if defined in database.
		/// </summary>
		IDbSet<EntityAccess> EntityAccesses { get; }

		/// <summary>
		/// Entity set of manager accesses in the system,
		/// only used if defined in database.
		/// </summary>
		IDbSet<ManagerAccess> ManagerAccesses { get; }

		/// <summary>
		/// Entity set of permissions in the system,
		/// only used if defined in database.
		/// </summary>
		IDbSet<Permission> Permissions { get; }

		/// <summary>
		/// Entity set of segregations in the system.
		/// </summary>
		IDbSet<Segregation<U>> Segregations { get; }

		/// <summary>
		/// Entity set of dispositions in the system.
		/// </summary>
		IDbSet<Disposition<U>> Dispositions { get; }

		#endregion

		#region Accounting

		/// <summary>
		/// Entity set of accounts in the system.
		/// </summary>
		IDbSet<Account<U>> Accounts { get; }

		/// <summary>
		/// Entity set of accounting batches in the system.
		/// </summary>
		IDbSet<Batch<U>> Batches { get; }

		/// <summary>
		/// Entity set of remittances belonging to a batch in the system.
		/// </summary>
		IDbSet<BatchRemittance<U>> BatchRemittances { get; }

		/// <summary>
		/// Entity set of credit systems in the system.
		/// </summary>
		IDbSet<CreditSystem> CreditSystems { get; }

		/// <summary>
		/// Entity set of accounting journals in the system.
		/// </summary>
		IDbSet<Journal<U>> Journals { get; }

		/// <summary>
		/// Entity set of accounting journal lines in the system.
		/// </summary>
		IDbSet<JournalLine<U>> JournalLines { get; }

		#endregion

		#region Workflow

		/// <summary>
		/// Entity set of state transition attachments in the system.
		/// </summary>
		IDbSet<Attachment<U>> Attachments { get; }

		/// <summary>
		/// Entity set of contents of state transition attachments in the system.
		/// </summary>
		IDbSet<AttachmentContent<U>> AttachmentContents { get; }

		/// <summary>
		/// Entity set of workflow states in the system.
		/// </summary>
		IDbSet<State> State { get; }

		/// <summary>
		/// Entity set of workflow state groups in the system.
		/// </summary>
		IDbSet<StateGroup> StateGroups { get; }

		/// <summary>
		/// Entity set of workflow state paths in the system.
		/// </summary>
		IDbSet<StatePath> StatePaths { get; }

		/// <summary>
		/// Entity set of transitions occurred between workflow states in the system.
		/// </summary>
		IDbSet<StateTransition<U>> StateTransitions { get; }

		/// <summary>
		/// Entity set of workflow graphs in the system.
		/// </summary>
		IDbSet<WorkflowGraph> WorkflowGraphs { get; }

		#endregion
	}
}

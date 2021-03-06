﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grammophone.Domos.Domain;
using Grammophone.Domos.Domain.Workflow;

namespace Grammophone.Domos.DataAccess
{
	/// <summary>
	/// Abstract repository of a Domos repository,
	/// containing users, roles, workflow, managers and permissions.
	/// </summary>
	/// <typeparam name="U">
	/// The type of users, derived from <see cref="User"/>.
	/// </typeparam>
	/// <typeparam name="BST">
	/// The base type of the system's state transitions, derived from <see cref="StateTransition{U}"/>.
	/// </typeparam>
	public interface IWorkflowUsersDomainContainer<U, BST> : IUsersDomainContainer<U>
		where U : User
		where BST : StateTransition<U>
	{
		/// <summary>
		/// Entity set of workflow states in the system.
		/// </summary>
		IDbSet<State> States { get; }

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
		IDbSet<BST> StateTransitions { get; }

		/// <summary>
		/// Entity set of workflow graphs in the system.
		/// </summary>
		IDbSet<WorkflowGraph> WorkflowGraphs { get; }
	}
}

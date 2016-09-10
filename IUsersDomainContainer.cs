using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grammophone.DataAccess;
using Grammophone.Domos.Domain;

namespace Grammophone.Domos.DataAccess
{
	/// <summary>
	/// Abstract repository of a Domos repository,
	/// containing users, roles and permissions.
	/// </summary>
	/// <typeparam name="U">
	/// The type of users, derived from <see cref="User"/>.
	/// </typeparam>
	public interface IUsersDomainContainer<U> : IDomainContainer
		where U : User
	{
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
		/// Entity set of dispositions in the system.
		/// </summary>
		IDbSet<Disposition> Dispositions { get; }
	}
}

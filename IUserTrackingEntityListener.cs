using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grammophone.DataAccess;
using Grammophone.Domos.Domain;

namespace Grammophone.Domos.DataAccess
{
	/// <summary>
	/// Marker interface for entity listeners
	/// updating <see cref="TrackingEntity{U}.CreatorUser"/>,
	/// <see cref="TrackingEntity{U}.CreationDate"/>, 
	/// <see cref="TrackingEntity{U}.LastModifierUser"/>
	/// <see cref="TrackingEntity{U}.LastModificationDate"/>
	/// and <see cref="UserTrackingEntity{U}.OwningUser"/>.
	/// </summary>
	public interface IUserTrackingEntityListener : IEntityListener
	{
	}
}

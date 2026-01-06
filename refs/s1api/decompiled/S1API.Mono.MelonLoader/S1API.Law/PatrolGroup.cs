using ScheduleOne.NPCs.Behaviour;
using UnityEngine;

namespace S1API.Law;

public sealed class PatrolGroup
{
	internal readonly PatrolGroup S1PatrolGroup;

	public int MemberCount => S1PatrolGroup?.Members.Count ?? 0;

	public int CurrentWaypoint => S1PatrolGroup?.CurrentWaypoint ?? 0;

	public FootPatrolRoute Route
	{
		get
		{
			if ((Object)(object)S1PatrolGroup?.Route == (Object)null)
			{
				return null;
			}
			return new FootPatrolRoute(S1PatrolGroup.Route);
		}
	}

	internal PatrolGroup(PatrolGroup s1PatrolGroup)
	{
		S1PatrolGroup = s1PatrolGroup;
	}

	public void DisbandGroup()
	{
		PatrolGroup s1PatrolGroup = S1PatrolGroup;
		if (s1PatrolGroup != null)
		{
			s1PatrolGroup.DisbandGroup();
		}
	}

	public void AdvanceGroup()
	{
		PatrolGroup s1PatrolGroup = S1PatrolGroup;
		if (s1PatrolGroup != null)
		{
			s1PatrolGroup.AdvanceGroup();
		}
	}

	public bool IsGroupReadyToAdvance()
	{
		PatrolGroup s1PatrolGroup = S1PatrolGroup;
		return s1PatrolGroup != null && s1PatrolGroup.IsGroupReadyToAdvance();
	}

	public bool IsPaused()
	{
		PatrolGroup s1PatrolGroup = S1PatrolGroup;
		return s1PatrolGroup == null || s1PatrolGroup.IsPaused();
	}
}

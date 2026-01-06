using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.Police;
using S1API.Entities;
using UnityEngine;

namespace S1API.Law;

public static class LawManager
{
	private static LawManager Internal => Singleton<LawManager>.Instance;

	public static int DispatchOfficerCount => 2;

	public static float DispatchVehicleUseThreshold => 25f;

	public static float SearchTimeInvestigating => 60f;

	public static float SearchTimeArresting => 25f;

	public static float SearchTimeNonLethal => 30f;

	public static float SearchTimeLethal => 40f;

	public static float EscalationTimeArresting => 25f;

	public static float EscalationTimeNonLethal => 120f;

	public static int ActiveOfficerCount => PoliceOfficer.Officers.Count;

	public static void CallPolice(Player target)
	{
		if (!((Object)(object)Internal == (Object)null) && target != null)
		{
			Internal.PoliceCalled(target.S1Player, (Crime)null);
		}
	}

	public static void SetWantedLevel(Player target, PursuitLevel level)
	{
		target?.CrimeData.SetPursuitLevel(level);
	}

	public static void ClearWantedLevel(Player target)
	{
		target?.CrimeData.SetPursuitLevel(PursuitLevel.None);
	}

	public static PursuitLevel GetWantedLevel(Player target)
	{
		return target?.CrimeData.CurrentPursuitLevel ?? PursuitLevel.None;
	}

	public static void EscalateWantedLevel(Player target)
	{
		target?.CrimeData.Escalate();
	}

	public static void DeescalateWantedLevel(Player target)
	{
		target?.CrimeData.Deescalate();
	}

	public static bool IsPlayerWanted(Player target)
	{
		if (target == null)
		{
			return false;
		}
		return target.CrimeData.CurrentPursuitLevel != PursuitLevel.None;
	}

	public static bool IsUnderInvestigation(Player target)
	{
		if (target == null)
		{
			return false;
		}
		return target.CrimeData.CurrentPursuitLevel >= PursuitLevel.Investigating;
	}

	public static bool IsLethalForceAuthorized(Player target)
	{
		if (target == null)
		{
			return false;
		}
		return target.CrimeData.CurrentPursuitLevel == PursuitLevel.Lethal;
	}

	public static PatrolGroup StartFootPatrol(FootPatrolRoute route, int requestedMembers = 2)
	{
		if ((Object)(object)Internal == (Object)null || (Object)(object)route?.S1Route == (Object)null)
		{
			return null;
		}
		PatrolGroup val = Internal.StartFootpatrol(route.S1Route, requestedMembers);
		return (val != null) ? new PatrolGroup(val) : null;
	}

	public static bool StartVehiclePatrol(VehiclePatrolRoute route)
	{
		if ((Object)(object)Internal == (Object)null || (Object)(object)route?.S1Route == (Object)null)
		{
			return false;
		}
		PoliceOfficer val = Internal.StartVehiclePatrol(route.S1Route);
		return (Object)(object)val != (Object)null;
	}

	public static FootPatrolRoute FindFootPatrolRoute(string routeName)
	{
		if (string.IsNullOrEmpty(routeName))
		{
			return null;
		}
		Il2CppArrayBase<FootPatrolRoute> val = Object.FindObjectsOfType<FootPatrolRoute>();
		for (int i = 0; i < val.Length; i++)
		{
			if (val[i].RouteName == routeName)
			{
				return new FootPatrolRoute(val[i]);
			}
		}
		return null;
	}

	public static VehiclePatrolRoute FindVehiclePatrolRoute(string routeName)
	{
		if (string.IsNullOrEmpty(routeName))
		{
			return null;
		}
		Il2CppArrayBase<VehiclePatrolRoute> val = Object.FindObjectsOfType<VehiclePatrolRoute>();
		for (int i = 0; i < val.Length; i++)
		{
			if (val[i].RouteName == routeName)
			{
				return new VehiclePatrolRoute(val[i]);
			}
		}
		return null;
	}

	public static FootPatrolRoute[] GetAllFootPatrolRoutes()
	{
		Il2CppArrayBase<FootPatrolRoute> val = Object.FindObjectsOfType<FootPatrolRoute>();
		FootPatrolRoute[] array = new FootPatrolRoute[val.Length];
		for (int i = 0; i < val.Length; i++)
		{
			array[i] = new FootPatrolRoute(val[i]);
		}
		return array;
	}

	public static VehiclePatrolRoute[] GetAllVehiclePatrolRoutes()
	{
		Il2CppArrayBase<VehiclePatrolRoute> val = Object.FindObjectsOfType<VehiclePatrolRoute>();
		VehiclePatrolRoute[] array = new VehiclePatrolRoute[val.Length];
		for (int i = 0; i < val.Length; i++)
		{
			array[i] = new VehiclePatrolRoute(val[i]);
		}
		return array;
	}
}

using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.NPCs.Behaviour;
using UnityEngine;

namespace S1API.Law;

public sealed class FootPatrolRoute
{
	internal readonly FootPatrolRoute S1Route;

	public string RouteName
	{
		get
		{
			FootPatrolRoute s1Route = S1Route;
			return ((s1Route != null) ? s1Route.RouteName : null) ?? string.Empty;
		}
	}

	public int WaypointCount
	{
		get
		{
			FootPatrolRoute s1Route = S1Route;
			return ((s1Route == null) ? ((int?)null) : ((Il2CppArrayBase<Transform>)(object)s1Route.Waypoints)?.Length).GetValueOrDefault();
		}
	}

	public int StartWaypointIndex
	{
		get
		{
			FootPatrolRoute s1Route = S1Route;
			return (s1Route != null) ? s1Route.StartWaypointIndex : 0;
		}
	}

	public Vector3 Position
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			FootPatrolRoute s1Route = S1Route;
			return (s1Route != null) ? ((Component)s1Route).transform.position : Vector3.zero;
		}
	}

	internal FootPatrolRoute(FootPatrolRoute s1Route)
	{
		S1Route = s1Route;
	}

	public Vector3 GetWaypointPosition(int index)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		FootPatrolRoute s1Route = S1Route;
		if (((s1Route != null) ? s1Route.Waypoints : null) == null || index < 0 || index >= ((Il2CppArrayBase<Transform>)(object)S1Route.Waypoints).Length)
		{
			return Vector3.zero;
		}
		return ((Il2CppArrayBase<Transform>)(object)S1Route.Waypoints)[index].position;
	}
}

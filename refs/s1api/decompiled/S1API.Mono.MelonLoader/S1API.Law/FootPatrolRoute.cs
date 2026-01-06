using ScheduleOne.NPCs.Behaviour;
using UnityEngine;

namespace S1API.Law;

public sealed class FootPatrolRoute
{
	internal readonly FootPatrolRoute S1Route;

	public string RouteName => S1Route?.RouteName ?? string.Empty;

	public int WaypointCount => (S1Route?.Waypoints?.Length).GetValueOrDefault();

	public int StartWaypointIndex => S1Route?.StartWaypointIndex ?? 0;

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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (S1Route?.Waypoints == null || index < 0 || index >= S1Route.Waypoints.Length)
		{
			return Vector3.zero;
		}
		return S1Route.Waypoints[index].position;
	}
}

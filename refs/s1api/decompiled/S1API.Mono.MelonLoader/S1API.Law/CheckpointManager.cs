using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Law;
using ScheduleOne.NPCs;
using ScheduleOne.Police;
using UnityEngine;

namespace S1API.Law;

public static class CheckpointManager
{
	private static CheckpointManager Internal => NetworkSingleton<CheckpointManager>.Instance;

	public static void SetCheckpointEnabled(CheckpointLocation location, bool enabled, int requestedOfficers = 2)
	{
		if (!((Object)(object)Internal == (Object)null))
		{
			Internal.SetCheckpointEnabled((ECheckpointLocation)location, enabled, requestedOfficers);
		}
	}

	public static bool IsCheckpointEnabled(CheckpointLocation location)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		if ((Object)(object)Internal == (Object)null)
		{
			return false;
		}
		RoadCheckpoint checkpoint = Internal.GetCheckpoint((ECheckpointLocation)location);
		if ((Object)(object)checkpoint == (Object)null)
		{
			return false;
		}
		return (int)checkpoint.ActivationState == 1;
	}

	public static void EnableAllCheckpoints(int officersPerCheckpoint = 2)
	{
		SetCheckpointEnabled(CheckpointLocation.Western, enabled: true, officersPerCheckpoint);
		SetCheckpointEnabled(CheckpointLocation.Docks, enabled: true, officersPerCheckpoint);
		SetCheckpointEnabled(CheckpointLocation.NorthResidential, enabled: true, officersPerCheckpoint);
		SetCheckpointEnabled(CheckpointLocation.WestResidential, enabled: true, officersPerCheckpoint);
	}

	public static void DisableAllCheckpoints()
	{
		SetCheckpointEnabled(CheckpointLocation.Western, enabled: false, 0);
		SetCheckpointEnabled(CheckpointLocation.Docks, enabled: false, 0);
		SetCheckpointEnabled(CheckpointLocation.NorthResidential, enabled: false, 0);
		SetCheckpointEnabled(CheckpointLocation.WestResidential, enabled: false, 0);
	}

	public static Vector3 GetCheckpointPosition(CheckpointLocation location)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Internal == (Object)null)
		{
			return Vector3.zero;
		}
		RoadCheckpoint checkpoint = Internal.GetCheckpoint((ECheckpointLocation)location);
		if ((Object)(object)checkpoint == (Object)null)
		{
			return Vector3.zero;
		}
		return ((Component)checkpoint).transform.position;
	}

	public static int GetAssignedOfficerCount(CheckpointLocation location)
	{
		if ((Object)(object)Internal == (Object)null)
		{
			return 0;
		}
		RoadCheckpoint checkpoint = Internal.GetCheckpoint((ECheckpointLocation)location);
		if ((Object)(object)checkpoint == (Object)null)
		{
			return 0;
		}
		return checkpoint.AssignedNPCs.Count;
	}

	public static List<NPC> GetAssignedOfficers(CheckpointLocation location)
	{
		List<NPC> list = new List<NPC>();
		if ((Object)(object)Internal == (Object)null)
		{
			return list;
		}
		RoadCheckpoint checkpoint = Internal.GetCheckpoint((ECheckpointLocation)location);
		if ((Object)(object)checkpoint == (Object)null)
		{
			return list;
		}
		list.AddRange(checkpoint.AssignedNPCs);
		return list;
	}

	public static bool IsGate1Open(CheckpointLocation location)
	{
		if ((Object)(object)Internal == (Object)null)
		{
			return false;
		}
		RoadCheckpoint checkpoint = Internal.GetCheckpoint((ECheckpointLocation)location);
		if ((Object)(object)checkpoint == (Object)null)
		{
			return false;
		}
		return checkpoint.Gate1Open;
	}

	public static bool IsGate2Open(CheckpointLocation location)
	{
		if ((Object)(object)Internal == (Object)null)
		{
			return false;
		}
		RoadCheckpoint checkpoint = Internal.GetCheckpoint((ECheckpointLocation)location);
		if ((Object)(object)checkpoint == (Object)null)
		{
			return false;
		}
		return checkpoint.Gate2Open;
	}

	public static CheckpointInfo GetCheckpointInfo(CheckpointLocation location)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Internal == (Object)null)
		{
			return null;
		}
		RoadCheckpoint checkpoint = Internal.GetCheckpoint((ECheckpointLocation)location);
		if ((Object)(object)checkpoint == (Object)null)
		{
			return null;
		}
		return new CheckpointInfo
		{
			Location = location,
			IsEnabled = ((int)checkpoint.ActivationState == 1),
			Position = ((Component)checkpoint).transform.position,
			AssignedOfficerCount = checkpoint.AssignedNPCs.Count,
			IsGate1Open = checkpoint.Gate1Open,
			IsGate2Open = checkpoint.Gate2Open
		};
	}

	public static List<CheckpointInfo> GetAllCheckpointInfo()
	{
		List<CheckpointInfo> list = new List<CheckpointInfo>();
		foreach (CheckpointLocation value in Enum.GetValues(typeof(CheckpointLocation)))
		{
			CheckpointInfo checkpointInfo = GetCheckpointInfo(value);
			if (checkpointInfo != null)
			{
				list.Add(checkpointInfo);
			}
		}
		return list;
	}
}

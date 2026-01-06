using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace S1API.Entities;

public class NPCMovement
{
	internal readonly NPC NPC;

	public Vector3 FootPosition => ((Object)(object)NPC.S1NPC.Movement != (Object)null) ? NPC.S1NPC.Movement.FootPosition : NPC.gameObject.transform.position;

	public Vector3 CurrentDestination => ((Object)(object)NPC.S1NPC.Movement != (Object)null) ? NPC.S1NPC.Movement.CurrentDestination : NPC.gameObject.transform.position;

	public bool IsMoving => (Object)(object)NPC.S1NPC.Movement != (Object)null && NPC.S1NPC.Movement.IsMoving;

	public float SpeedMultiplier
	{
		get
		{
			NPCSpeedController? speedController = SpeedController;
			return (speedController != null) ? speedController.SpeedMultiplier : 1f;
		}
		set
		{
			if ((Object)(object)SpeedController != (Object)null)
			{
				SpeedController.SpeedMultiplier = value;
			}
		}
	}

	public float DefaultWalkSpeed
	{
		get
		{
			NPCSpeedController? speedController = SpeedController;
			return (speedController != null) ? speedController.DefaultWalkSpeed : 0.08f;
		}
	}

	internal NPCSpeedController? SpeedController
	{
		get
		{
			NPCMovement movement = NPC.S1NPC.Movement;
			return (movement != null) ? movement.SpeedController : null;
		}
	}

	internal NPCMovement(NPC npc)
	{
		NPC = npc;
		((Behaviour)NPC.S1NPC.Movement).enabled = true;
	}

	public void SetDestination(Vector3 position)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NPC.S1NPC.Movement != (Object)null)
		{
			NPC.S1NPC.Movement.SetDestination(position);
		}
	}

	public void Warp(Vector3 position)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NPC.S1NPC.Movement != (Object)null)
		{
			NPC.S1NPC.Movement.Warp(position);
		}
		else
		{
			NPC.gameObject.transform.position = position;
		}
	}

	public void Stop()
	{
		if ((Object)(object)NPC.S1NPC.Movement != (Object)null)
		{
			NPC.S1NPC.Movement.Stop();
		}
	}

	public bool CanGetTo(Vector3 position)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		return (Object)(object)NPC.S1NPC.Movement != (Object)null && NPC.S1NPC.Movement.CanGetTo(position, 1f);
	}

	public bool CanGetTo(Vector3 position, float within)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		return (Object)(object)NPC.S1NPC.Movement != (Object)null && NPC.S1NPC.Movement.CanGetTo(position, within);
	}

	public void FaceDirection(Vector3 forward)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NPC.S1NPC.Movement != (Object)null)
		{
			NPC.S1NPC.Movement.FaceDirection(forward, 0.5f);
		}
	}

	public void FacePoint(Vector3 position)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NPC.S1NPC.Movement != (Object)null)
		{
			NPC.S1NPC.Movement.FacePoint(position, 0.5f);
		}
	}

	public void AddSpeedControl(string id, int priority, float speed)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		if ((Object)(object)SpeedController != (Object)null)
		{
			SpeedControl val = new SpeedControl(id, priority, speed);
			SpeedController.AddSpeedControl(val);
		}
	}

	public void RemoveSpeedControl(string id)
	{
		NPCSpeedController? speedController = SpeedController;
		if (speedController != null)
		{
			speedController.RemoveSpeedControl(id);
		}
	}

	public bool DoesSpeedControlExist(string id)
	{
		NPCSpeedController? speedController = SpeedController;
		return speedController != null && speedController.DoesSpeedControlExist(id);
	}
}

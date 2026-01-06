using System.Collections;
using Il2CppScheduleOne.Casino;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Schedules;
using MelonLoader;
using S1API.Casino;
using S1API.Internal.Utils;
using S1API.Logging;
using S1API.Map;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class UseSlotMachineSpec : IScheduleActionSpec
{
	private static readonly Log Logger = new Log("UseSlotMachineSpec");

	public int StartTime { get; set; }

	public Vector3 MachinePosition { get; set; }

	public int BetAmount { get; set; } = 10;

	public GamblingSessionMode SessionMode { get; set; } = GamblingSessionMode.SingleSpin;

	public int SpinCount { get; set; } = 1;

	public int EndTime { get; set; }

	public float TimeBetweenSpins { get; set; } = 10f;

	public float MaxSearchDistance { get; set; } = 5f;

	public string Name { get; set; }

	public global::S1API.Map.Building Building { get; set; }

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		NPC nPC = schedule.NPC;
		if (nPC == null)
		{
			Logger.Warning("ApplyTo called with null NPC");
			return;
		}
		TimeManager instance = NetworkSingleton<TimeManager>.Instance;
		int num = (((Object)(object)instance != (Object)null) ? instance.CurrentTime : (-1));
		bool flag = num >= 0 && num >= StartTime;
		bool flag2 = false;
		if (flag && (Object)(object)instance != (Object)null)
		{
			flag2 = (SessionMode != GamblingSessionMode.UntilTime && SessionMode != GamblingSessionMode.UntilTimeOrBroke) || ((EndTime <= StartTime) ? (num < EndTime || num >= StartTime) : (num < EndTime));
			if (!flag2)
			{
				return;
			}
		}
		int num2 = ((flag && flag2) ? Mathf.Max(1, num) : StartTime);
		if (Building != null)
		{
			int num3 = Mathf.Max(1, num2 - 5);
			NPCEvent_StayInBuilding val = schedule.AddActionInternal<NPCEvent_StayInBuilding>(num3, string.IsNullOrEmpty(Name) ? "EnterBuildingForSlotMachine" : (Name + "_EnterBuilding"));
			if ((Object)(object)val != (Object)null)
			{
				object obj = Building.ResolveGameBuilding();
				if (obj != null)
				{
					int num4 = 60;
					num4 = ((SessionMode != GamblingSessionMode.UntilTime && SessionMode != GamblingSessionMode.UntilTimeOrBroke) ? 60 : ((EndTime > StartTime) ? (EndTime - num3) : (1440 - num3 + EndTime)));
					((NPCEvent)val).Duration = Mathf.Max(1, num4);
					int num5 = TimeManager.AddMinutesTo24HourTime(num3, ((NPCEvent)val).Duration);
					ReflectionUtils.TrySetFieldOrProperty(val, "EndTime", num5);
					ReflectionUtils.TrySetFieldOrProperty(val, "Building", obj);
				}
				else
				{
					Logger.Warning("[" + nPC.ID + "] Failed to resolve game building: " + Building.Name);
				}
			}
			else
			{
				Logger.Warning("[" + nPC.ID + "] Failed to create StayInBuilding action");
			}
		}
		Vector3 val2 = MachinePosition;
		if (!nPC.Movement.CanGetTo(val2))
		{
			Logger.Warning("[" + nPC.ID + "] Initial position not reachable, searching for nearest slot machine");
			SlotMachine val3 = SlotMachineHelper.FindNearestSlotMachine(val2, MaxSearchDistance * 2f);
			if (!((Object)(object)val3 != (Object)null))
			{
				Logger.Error("[" + nPC.ID + "] No slot machine found near position, aborting");
				return;
			}
			if (!nPC.Movement.CanGetTo(((Component)val3).transform.position))
			{
				Logger.Error("[" + nPC.ID + "] Found slot machine but it's not reachable, aborting");
				return;
			}
			val2 = ((Component)val3).transform.position;
		}
		Transform val4 = NPCDestinationContainer.CreateDestinationMarker(((Object)nPC.gameObject).name, "SlotMachineDestination", val2);
		if ((Object)(object)val4 == (Object)null)
		{
			Logger.Error("[" + nPC.ID + "] Failed to create destination marker, aborting");
			return;
		}
		NPCSignal_WalkToLocation val5 = schedule.AddActionInternal<NPCSignal_WalkToLocation>(num2, string.IsNullOrEmpty(Name) ? "WalkToSlotMachine" : (Name + "_Walk"));
		if ((Object)(object)val5 == (Object)null)
		{
			Logger.Error("[" + nPC.ID + "] Failed to create WalkTo action, aborting");
			return;
		}
		val5.Destination = val4;
		val5.FaceDestinationDir = true;
		val5.DestinationThreshold = 2f;
		val5.WarpIfSkipped = flag && flag2;
		MelonCoroutines.Start(WaitForArrivalThenGamble(nPC, val2, BetAmount, MaxSearchDistance, SessionMode, SpinCount, EndTime, TimeBetweenSpins, num2));
	}

	private static IEnumerator WaitForArrivalThenGamble(NPC npc, Vector3 targetPosition, int bet, float maxDistance, GamblingSessionMode mode, int spinCount, int endTime, float timeBetweenSpins, int startTime)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		TimeManager timeManager = NetworkSingleton<TimeManager>.Instance;
		int currentTime = (((Object)(object)timeManager != (Object)null) ? timeManager.CurrentTime : (-1));
		if (currentTime >= 0 && currentTime < startTime)
		{
			while ((Object)(object)timeManager != (Object)null && timeManager.CurrentTime < startTime)
			{
				yield return (object)new WaitForSeconds(1f);
			}
		}
		if (npc != null && (Object)(object)npc.gameObject != (Object)null && !npc.Movement.CanGetTo(targetPosition))
		{
			Logger.Warning("[" + npc.ID + "] NPC can't pathfind to target, searching for alternative");
			SlotMachine machine = SlotMachineHelper.FindNearestSlotMachine(targetPosition, maxDistance * 2f);
			if (!((Object)(object)machine != (Object)null))
			{
				Logger.Error("[" + npc.ID + "] No alternative slot machine found, aborting");
				yield break;
			}
			targetPosition = ((Component)machine).transform.position;
		}
		float arrivalThreshold = 2f;
		int maxWaitTime = 300;
		int waitedSeconds = 0;
		while (npc != null && (Object)(object)npc.gameObject != (Object)null && waitedSeconds < maxWaitTime)
		{
			float distance = Vector3.Distance(npc.Movement.FootPosition, targetPosition);
			bool isMoving = npc.Movement.IsMoving;
			if (distance <= arrivalThreshold && !isMoving)
			{
				break;
			}
			yield return (object)new WaitForSeconds(1f);
			waitedSeconds++;
		}
		if (waitedSeconds >= maxWaitTime)
		{
			Logger.Warning($"[{npc?.ID}] Max wait time reached ({maxWaitTime}s), proceeding anyway");
		}
		if (npc != null && (Object)(object)npc.gameObject != (Object)null)
		{
			yield return GamblingSession(npc, targetPosition, bet, maxDistance, mode, spinCount, endTime, timeBetweenSpins);
		}
		else
		{
			Logger.Error("[" + npc?.ID + "] NPC is null when trying to start gambling session");
		}
	}

	private static IEnumerator GamblingSessionDelayed(NPC npc, Vector3 position, int bet, float maxDistance, GamblingSessionMode mode, int spinCount, int endTime, float timeBetweenSpins, int startTime)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		TimeManager timeManager = NetworkSingleton<TimeManager>.Instance;
		while ((Object)(object)timeManager != (Object)null && timeManager.CurrentTime < startTime)
		{
			yield return (object)new WaitForSeconds(1f);
		}
		yield return GamblingSession(npc, position, bet, maxDistance, mode, spinCount, endTime, timeBetweenSpins);
	}

	private static IEnumerator GamblingSession(NPC npc, Vector3 position, int bet, float maxDistance, GamblingSessionMode mode, int spinCount, int endTime, float timeBetweenSpins)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		yield return (object)new WaitForSeconds(1f);
		int num;
		if (npc != null)
		{
			NPC s1NPC = npc.S1NPC;
			num = (((Object)(object)((s1NPC != null) ? s1NPC.Inventory : null) != (Object)null) ? 1 : 0);
		}
		else
		{
			num = 0;
		}
		if (num != 0)
		{
			float currentCash = SlotMachineHelper.GetNPCCash(npc);
			NPCInventory inventory = npc.S1NPC.Inventory;
			if (currentCash == 0f && inventory.RandomCash && inventory.RandomCashMax > 0)
			{
				int cashToAdd = Random.Range(Mathf.Max(inventory.RandomCashMin, bet), inventory.RandomCashMax + 1);
				SlotMachineHelper.AddNPCCash(npc, cashToAdd);
				yield return null;
			}
		}
		int completedSpins = 0;
		TimeManager timeManager = NetworkSingleton<TimeManager>.Instance;
		int loopIteration = 0;
		while (true)
		{
			loopIteration++;
			if (npc == null || (Object)(object)npc.gameObject == (Object)null)
			{
				Logger.Warning("[" + npc?.ID + "] NPC is null in gambling session loop, breaking");
				break;
			}
			float npcCash = SlotMachineHelper.GetNPCCash(npc);
			int currentTime = (((Object)(object)timeManager != (Object)null) ? timeManager.CurrentTime : (-1));
			if (1 == 0)
			{
			}
			bool flag = mode switch
			{
				GamblingSessionMode.SingleSpin => completedSpins < 1, 
				GamblingSessionMode.SpinCount => completedSpins < spinCount, 
				GamblingSessionMode.UntilTime => (Object)(object)timeManager != (Object)null && currentTime < endTime, 
				GamblingSessionMode.UntilBroke => npcCash >= (float)bet, 
				GamblingSessionMode.UntilTimeOrBroke => (Object)(object)timeManager != (Object)null && currentTime < endTime && npcCash >= (float)bet, 
				_ => false, 
			};
			if (1 == 0)
			{
			}
			if (!flag || npcCash < (float)bet)
			{
				break;
			}
			if (!SlotMachineHelper.UseSlotMachine(npc, position, bet, maxDistance))
			{
				Logger.Warning($"[{npc.ID}] Failed to use slot machine (attempt {loopIteration}), will retry in 5s");
				yield return (object)new WaitForSeconds(5f);
			}
			else
			{
				completedSpins++;
				if (mode != GamblingSessionMode.SingleSpin || completedSpins < 1)
				{
					yield return (object)new WaitForSeconds(timeBetweenSpins);
				}
			}
		}
	}
}

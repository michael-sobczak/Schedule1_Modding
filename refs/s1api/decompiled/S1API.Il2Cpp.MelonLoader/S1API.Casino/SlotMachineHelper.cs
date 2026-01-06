using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Casino;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.NPCs;
using MelonLoader;
using S1API.Entities;
using S1API.Logging;
using S1API.Utils;
using UnityEngine;

namespace S1API.Casino;

public static class SlotMachineHelper
{
	public enum Outcome
	{
		Jackpot,
		BigWin,
		SmallWin,
		MiniWin,
		NoWin
	}

	private static readonly Log Logger = new Log("SlotMachineHelper");

	public static float GetNPCCash(NPC npc)
	{
		object obj;
		if (npc == null)
		{
			obj = null;
		}
		else
		{
			NPC s1NPC = npc.S1NPC;
			obj = ((s1NPC != null) ? s1NPC.Inventory : null);
		}
		if ((Object)obj == (Object)null)
		{
			return 0f;
		}
		try
		{
			float num = 0f;
			int num2 = 0;
			NPCInventory inventory = npc.S1NPC.Inventory;
			return inventory.GetCashInInventory();
		}
		catch (Exception ex)
		{
			Logger.Warning("Failed to get cash for NPC " + npc?.ID + ": " + ex.Message);
			return 0f;
		}
	}

	public static bool RemoveNPCCash(NPC npc, int amount)
	{
		object obj;
		if (npc == null)
		{
			obj = null;
		}
		else
		{
			NPC s1NPC = npc.S1NPC;
			obj = ((s1NPC != null) ? s1NPC.Inventory : null);
		}
		if ((Object)obj == (Object)null || amount <= 0)
		{
			return false;
		}
		try
		{
			NPCInventory inventory = npc.S1NPC.Inventory;
			float nPCCash = GetNPCCash(npc);
			if (nPCCash < (float)amount)
			{
				return false;
			}
			MethodInfo method = ((object)inventory).GetType().GetMethod("RemoveCash", BindingFlags.Instance | BindingFlags.Public);
			if (method != null)
			{
				method.Invoke(inventory, new object[1] { (float)amount });
				float nPCCash2 = GetNPCCash(npc);
				float num = nPCCash - nPCCash2;
				if (num >= (float)amount - 0.01f)
				{
					return true;
				}
				Logger.Warning($"[{npc.ID}] RemoveNPCCash: Partial removal (Requested: ${amount}, Actual: ${num})");
				return false;
			}
			Logger.Warning("[" + npc.ID + "] RemoveNPCCash: RemoveCash method not found on inventory type");
			return false;
		}
		catch (Exception ex)
		{
			Logger.Warning("Failed to remove cash for NPC " + npc?.ID + ": " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
			return false;
		}
	}

	public static void AddNPCCash(NPC npc, int amount)
	{
		object obj;
		if (npc == null)
		{
			obj = null;
		}
		else
		{
			NPC s1NPC = npc.S1NPC;
			obj = ((s1NPC != null) ? s1NPC.Inventory : null);
		}
		if ((Object)obj == (Object)null || amount <= 0)
		{
			Log logger = Logger;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 3);
			defaultInterpolatedStringHandler.AppendLiteral("AddNPCCash: Invalid parameters - NPC=");
			defaultInterpolatedStringHandler.AppendFormatted(npc?.ID);
			defaultInterpolatedStringHandler.AppendLiteral(", Amount=");
			defaultInterpolatedStringHandler.AppendFormatted(amount);
			defaultInterpolatedStringHandler.AppendLiteral(", Inventory=");
			object obj2;
			if (npc == null)
			{
				obj2 = null;
			}
			else
			{
				NPC s1NPC2 = npc.S1NPC;
				obj2 = ((s1NPC2 != null) ? s1NPC2.Inventory : null);
			}
			defaultInterpolatedStringHandler.AppendFormatted(((Object)obj2 != (Object)null) ? "Valid" : "Null");
			logger.Warning(defaultInterpolatedStringHandler.ToStringAndClear());
			return;
		}
		try
		{
			NPCInventory inventory = npc.S1NPC.Inventory;
			npc.Inventory?.EnsureInitialized();
			if (inventory.ItemSlots == null || inventory.ItemSlots.Count == 0)
			{
				Logger.Warning("[" + npc.ID + "] AddNPCCash: Inventory slots not initialized (ItemSlots is null or empty). Cannot add cash.");
				return;
			}
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < inventory.ItemSlots.Count; i++)
			{
				ItemSlot val = inventory.ItemSlots[i];
				if (val == null)
				{
					continue;
				}
				try
				{
					bool valueOrDefault = ReflectionUtils.TryGetFieldOrProperty(val, "IsLocked") as bool? == true;
					bool valueOrDefault2 = ReflectionUtils.TryGetFieldOrProperty(val, "IsAddLocked") as bool? == true;
					if (!valueOrDefault && !valueOrDefault2)
					{
						num++;
						if (val.ItemInstance == null)
						{
							num2++;
						}
					}
				}
				catch
				{
				}
			}
			try
			{
				MethodInfo method = ((object)inventory).GetType().GetMethod("AddCash", BindingFlags.Instance | BindingFlags.Public);
				if (method != null)
				{
					method.Invoke(inventory, new object[1] { (float)amount });
					return;
				}
				throw new MissingMethodException("AddCash method not found! Did Schedule 1 update recently?");
			}
			catch (Exception ex)
			{
				Logger.Warning($"[{npc.ID}] AddNPCCash: Could not use AddCash method ({ex.Message}), falling back to manual insertion");
				MoneyManager instance = NetworkSingleton<MoneyManager>.Instance;
				if ((Object)(object)instance == (Object)null)
				{
					Logger.Warning("[" + npc.ID + "] AddNPCCash: MoneyManager not available to create cash item");
					return;
				}
				float num3 = amount;
				while (num3 > 0.1f)
				{
					float num4 = Mathf.Min(num3, 1000f);
					num3 -= num4;
					CashInstance cashInstance = instance.GetCashInstance((float)(int)num4);
					if (cashInstance == null)
					{
						Logger.Warning($"[{npc.ID}] AddNPCCash: GetCashInstance returned null for chunk ${num4}");
						break;
					}
					if (!inventory.CanItemFit((ItemInstance)(object)cashInstance))
					{
						Logger.Warning($"[{npc.ID}] AddNPCCash: Cash item (${num4}) cannot fit. UnlockedSlots={num}, FreeSlots={num2}");
						break;
					}
					inventory.InsertItem((ItemInstance)(object)cashInstance, true);
				}
			}
		}
		catch (Exception ex2)
		{
			Logger.Warning("[" + npc.ID + "] AddNPCCash: Failed with exception: " + ex2.Message);
			Logger.Warning("[" + npc.ID + "] AddNPCCash: Stack trace: " + ex2.StackTrace);
		}
	}

	public static bool UseSlotMachine(NPC npc, Vector3 machinePosition, int betAmount, float maxSearchDistance = 5f)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I4, but got Unknown
		if (npc == null || betAmount <= 0)
		{
			return false;
		}
		try
		{
			SlotMachine val = FindNearestSlotMachine(machinePosition, maxSearchDistance);
			if ((Object)(object)val == (Object)null)
			{
				Logger.Warning($"No slot machine found near position {machinePosition}");
				return false;
			}
			if (val.IsSpinning)
			{
				return false;
			}
			float nPCCash = GetNPCCash(npc);
			if (nPCCash < (float)betAmount)
			{
				return false;
			}
			if (!RemoveNPCCash(npc, betAmount))
			{
				Logger.Warning("Failed to remove cash from NPC " + npc.ID);
				return false;
			}
			ESymbol[] array = (ESymbol[])(object)new ESymbol[((Il2CppArrayBase<SlotReel>)(object)val.Reels).Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (ESymbol)(int)SlotMachine.GetRandomSymbol();
			}
			MelonCoroutines.Start(SpinSlotMachineForNPC(npc, val, array, betAmount));
			return true;
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to use slot machine for NPC " + npc.ID + ": " + ex.Message);
			return false;
		}
	}

	public static SlotMachine FindNearestSlotMachine(Vector3 position, float maxDistance)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Il2CppArrayBase<SlotMachine> val = Object.FindObjectsOfType<SlotMachine>();
			if (val == null || val.Length == 0)
			{
				return null;
			}
			SlotMachine result = null;
			float num = float.MaxValue;
			foreach (SlotMachine item in val)
			{
				if (!((Object)(object)item == (Object)null) && !((Object)(object)((Component)item).gameObject == (Object)null))
				{
					float num2 = Vector3.Distance(position, ((Component)item).transform.position);
					if (num2 < num && num2 <= maxDistance)
					{
						num = num2;
						result = item;
					}
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			Logger.Warning("Failed to find slot machine: " + ex.Message);
			return null;
		}
	}

	private static IEnumerator SpinSlotMachineForNPC(NPC npc, SlotMachine machine, ESymbol[] symbols, int betAmount)
	{
		PropertyInfo isSpinningProp = typeof(SlotMachine).GetProperty("IsSpinning");
		if (isSpinningProp != null && isSpinningProp.CanWrite)
		{
			isSpinningProp.SetValue(machine, true);
		}
		for (int i = 0; i < ((Il2CppArrayBase<SlotReel>)(object)machine.Reels).Length; i++)
		{
			yield return (object)new WaitForSeconds(0.2f);
			((Il2CppArrayBase<SlotReel>)(object)machine.Reels)[i].Spin();
			if (i == 0 && (Object)(object)machine.SpinLoop != (Object)null)
			{
				machine.SpinLoop.Play();
			}
		}
		yield return (object)new WaitForSeconds(0.5f);
		EOutcome outcome = EvaluateOutcome(machine, symbols);
		for (int j = 0; j < ((Il2CppArrayBase<SlotReel>)(object)machine.Reels).Length; j++)
		{
			if (j == ((Il2CppArrayBase<SlotReel>)(object)machine.Reels).Length - 1 && (int)outcome != 0 && symbols.Length >= 3 && (int)symbols[j - 1] == (int)symbols[j - 2])
			{
				yield return (object)new WaitForSeconds(0.3f);
			}
			yield return (object)new WaitForSeconds(0.6f);
			if ((int)outcome == 0)
			{
				if (j == 0 && (Object)(object)machine.JackpotSound != (Object)null)
				{
					machine.JackpotSound.Play();
				}
				else
				{
					yield return (object)new WaitForSeconds(0.35f);
				}
			}
			((Il2CppArrayBase<SlotReel>)(object)machine.Reels)[j].Stop(symbols[j]);
		}
		if ((Object)(object)machine.SpinLoop != (Object)null)
		{
			machine.SpinLoop.Stop();
		}
		int winAmount = GetWinAmount(outcome, betAmount);
		if (winAmount > 0)
		{
			AddNPCCash(npc, winAmount);
		}
		try
		{
			MethodInfo displayMethod = typeof(SlotMachine).GetMethod("DisplayOutcome", BindingFlags.Instance | BindingFlags.NonPublic);
			if (displayMethod != null)
			{
				displayMethod.Invoke(machine, new object[2] { outcome, winAmount });
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Failed to display outcome: " + ex.Message);
		}
		if (isSpinningProp != null && isSpinningProp.CanWrite)
		{
			isSpinningProp.SetValue(machine, false);
		}
	}

	private static EOutcome EvaluateOutcome(SlotMachine machine, ESymbol[] outcome)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MethodInfo method = typeof(SlotMachine).GetMethod("EvaluateOutcome", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method != null)
			{
				return (EOutcome)method.Invoke(machine, new object[1] { outcome });
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Failed to call EvaluateOutcome via reflection: " + ex.Message);
		}
		if (IsUniform(outcome))
		{
			if ((int)outcome[0] == 5)
			{
				return (EOutcome)0;
			}
			if ((int)outcome[0] == 4)
			{
				return (EOutcome)1;
			}
			if (IsFruit(outcome[0]))
			{
				return (EOutcome)2;
			}
		}
		if (IsAllFruit(outcome))
		{
			return (EOutcome)3;
		}
		return (EOutcome)4;
	}

	private static int GetWinAmount(EOutcome outcome, int betAmount)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		if (1 == 0)
		{
		}
		int result = (int)outcome switch
		{
			0 => betAmount * 100, 
			1 => betAmount * 25, 
			2 => betAmount * 10, 
			3 => betAmount * 2, 
			_ => 0, 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	private static bool IsUniform(ESymbol[] symbols)
	{
		for (int i = 1; i < symbols.Length; i++)
		{
			if ((int)symbols[i] != (int)symbols[i - 1])
			{
				return false;
			}
		}
		return true;
	}

	private static bool IsFruit(ESymbol symbol)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		return (int)symbol == 0 || (int)symbol == 1 || (int)symbol == 2 || (int)symbol == 3;
	}

	private static bool IsAllFruit(ESymbol[] symbols)
	{
		for (int i = 0; i < symbols.Length; i++)
		{
			if (!IsFruit(symbols[i]))
			{
				return false;
			}
		}
		return true;
	}
}

using System;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Calling;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppScheduleOne.UI.Phone;
using MelonLoader;
using S1API.Internal.Utils;
using S1API.PhoneCalls;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal static class CallManagerPatches
{
	[HarmonyPatch(typeof(CallManager), "QueueCall")]
	[HarmonyPrefix]
	private static bool QueueCall_Prefix(PhoneCallData data)
	{
		if (CallManager.IsDispatchingToGameQueue)
		{
			return true;
		}
		CallManager instance = Singleton<CallManager>.Instance;
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CallInterface instance2 = Singleton<CallInterface>.Instance;
		bool flag = (Object)(object)instance2 != (Object)null && (Object)(object)instance2.ActiveCallData != (Object)null;
		bool flag2 = CallManager.PendingCount > 0;
		object obj = ReflectionUtils.TryGetFieldOrProperty(instance, "QueuedCallData");
		PhoneCallData val = (PhoneCallData)((obj is PhoneCallData) ? obj : null);
		bool flag3 = (Object)(object)val != (Object)null;
		if (flag || flag2 || flag3)
		{
			CallManager.QueueCall(data);
			return false;
		}
		return true;
	}

	[HarmonyPatch(typeof(CallManager), "CallCompleted")]
	[HarmonyPostfix]
	private static void CallCompleted_Postfix()
	{
		CallManager.TryProcessQueue();
	}

	[HarmonyPatch(typeof(CallInterface), "Close")]
	[HarmonyPostfix]
	private static void Close_Postfix()
	{
		CallInterface instance = Singleton<CallInterface>.Instance;
		if (!((Object)(object)instance == (Object)null) && !instance.IsOpen && (Object)(object)instance.ActiveCallData == (Object)null)
		{
			CallManager.TryProcessQueue();
		}
	}

	[HarmonyPatch(typeof(CallInterface), "StartCall")]
	[HarmonyPrefix]
	private static void StartCall_Prefix(ref PhoneCallData data)
	{
		if ((Object)(object)data == (Object)null)
		{
			return;
		}
		try
		{
			if ((Object)(object)data.CallerID == (Object)null)
			{
				CallerID val = ScriptableObject.CreateInstance<CallerID>();
				val.Name = "Unknown Caller";
				val.ProfilePicture = null;
				data.CallerID = val;
			}
			if (data.Stages != null && ((Il2CppArrayBase<Stage>)(object)data.Stages).Length != 0)
			{
			}
		}
		catch (Exception ex)
		{
			try
			{
				MelonLogger.Warning("[CallManager] StartCall_Prefix failed: " + ex.Message + "\n" + ex.StackTrace);
			}
			catch
			{
			}
		}
	}
}

using System;
using System.Collections.Generic;
using S1API.Internal.Utils;
using ScheduleOne.Calling;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using ScheduleOne.UI.Phone;
using UnityEngine;

namespace S1API.PhoneCalls;

public static class CallManager
{
	private static readonly Queue<PhoneCallData> PendingCalls = new Queue<PhoneCallData>();

	internal static bool IsDispatchingToGameQueue;

	public static int PendingCount => PendingCalls.Count;

	public static void QueueCall(PhoneCallDefinition phoneCallDefinition)
	{
		if (phoneCallDefinition == null)
		{
			throw new ArgumentNullException("phoneCallDefinition");
		}
		PendingCalls.Enqueue(phoneCallDefinition.S1PhoneCallData);
		TryProcessQueue();
	}

	internal static void QueueCall(PhoneCallData phoneCallData)
	{
		if ((Object)(object)phoneCallData == (Object)null)
		{
			throw new ArgumentNullException("phoneCallData");
		}
		PendingCalls.Enqueue(phoneCallData);
		TryProcessQueue();
	}

	public static void ClearPendingQueue()
	{
		PendingCalls.Clear();
	}

	private static PhoneCallData GetQueuedCallData(CallManager manager)
	{
		object obj = ReflectionUtils.TryGetFieldOrProperty(manager, "QueuedCallData");
		return (PhoneCallData)((obj is PhoneCallData) ? obj : null);
	}

	internal static void TryProcessQueue()
	{
		CallManager instance = Singleton<CallManager>.Instance;
		if ((Object)(object)instance == (Object)null)
		{
			return;
		}
		CallInterface instance2 = Singleton<CallInterface>.Instance;
		if ((Object)(object)instance2 == (Object)null || (Object)(object)instance2.ActiveCallData != (Object)null || (Object)(object)GetQueuedCallData(instance) != (Object)null || PendingCalls.Count == 0)
		{
			return;
		}
		PhoneCallData val = null;
		while (PendingCalls.Count > 0)
		{
			PhoneCallData val2 = PendingCalls.Dequeue();
			if ((Object)(object)val2 == (Object)null)
			{
				continue;
			}
			try
			{
				if ((Object)(object)val2.CallerID == (Object)null)
				{
					CallerID val3 = ScriptableObject.CreateInstance<CallerID>();
					val3.Name = "Unknown Caller";
					val3.ProfilePicture = null;
					val2.CallerID = val3;
				}
				if (val2.Stages == null)
				{
					val2.Stages = Array.Empty<Stage>();
				}
			}
			catch
			{
			}
			if (val2.Stages == null || val2.Stages.Length == 0)
			{
				continue;
			}
			val = val2;
			break;
		}
		if ((Object)(object)val == (Object)null)
		{
			return;
		}
		IsDispatchingToGameQueue = true;
		try
		{
			instance.QueueCall(val);
		}
		finally
		{
			IsDispatchingToGameQueue = false;
		}
	}
}

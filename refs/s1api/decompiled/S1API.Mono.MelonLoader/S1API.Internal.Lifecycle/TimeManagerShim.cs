using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace S1API.Internal.Lifecycle;

internal class TimeManagerShim
{
	private static TimeManagerShim _instance;

	internal Action onSleepStart = delegate
	{
	};

	internal Action onHourPass = delegate
	{
	};

	internal static TimeManagerShim Instance => _instance ?? (_instance = new TimeManagerShim());

	private TimeManagerShim()
	{
	}

	internal void AddDelegatesToReal()
	{
		try
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				Debug.LogWarning((object)"TimeManagerShim: Real TimeManager instance not available yet; cannot migrate delegates.");
				return;
			}
			instance.onSleepStart = (Action)Delegate.Combine(instance.onSleepStart, onSleepStart);
			instance.onHourPass = (Action)Delegate.Combine(instance.onHourPass, onHourPass);
		}
		catch
		{
		}
	}

	internal void DeleteDelegatesFromReal()
	{
		try
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				Debug.LogWarning((object)"TimeManagerShim: Real TimeManager instance no longer available; cannot delete delegates.");
				return;
			}
			instance.onSleepStart = (Action)Delegate.RemoveAll(instance.onSleepStart, onSleepStart);
			instance.onHourPass = (Action)Delegate.RemoveAll(instance.onHourPass, onHourPass);
		}
		catch
		{
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.GameTime;
using Il2CppSystem;
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

	private Action il2cppOnSleepStart;

	private Action il2cppOnHourPass;

	private readonly List<Action> _addedSleepStart = new List<Action>();

	private readonly List<Action> _addedHourPass = new List<Action>();

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
				Debug.LogWarning(Object.op_Implicit("TimeManagerShim: Real TimeManager instance not available yet; cannot migrate delegates."));
				return;
			}
			if (il2cppOnSleepStart == null)
			{
				il2cppOnSleepStart = DelegateSupport.ConvertDelegate<Action>((Delegate)onSleepStart);
			}
			if (il2cppOnHourPass == null)
			{
				il2cppOnHourPass = DelegateSupport.ConvertDelegate<Action>((Delegate)onHourPass);
			}
			if (!_addedSleepStart.Contains(il2cppOnSleepStart))
			{
				instance.onSleepStart = ((Il2CppObjectBase)Delegate.Combine((Delegate)(object)instance.onSleepStart, (Delegate)(object)il2cppOnSleepStart)).Cast<Action>();
				_addedSleepStart.Add(il2cppOnSleepStart);
			}
			if (!_addedHourPass.Contains(il2cppOnHourPass))
			{
				instance.onHourPass = ((Il2CppObjectBase)Delegate.Combine((Delegate)(object)instance.onHourPass, (Delegate)(object)il2cppOnHourPass)).Cast<Action>();
				_addedHourPass.Add(il2cppOnHourPass);
			}
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
				Debug.LogWarning(Object.op_Implicit("TimeManagerShim: Real TimeManager instance no longer available; cannot delete delegates."));
				return;
			}
			foreach (Action item in _addedSleepStart)
			{
				instance.onSleepStart = RemoveAll(instance.onSleepStart, item);
			}
			_addedSleepStart.Clear();
			foreach (Action item2 in _addedHourPass)
			{
				instance.onHourPass = RemoveAll(instance.onHourPass, item2);
			}
			_addedHourPass.Clear();
		}
		catch
		{
		}
	}

	private static Action RemoveAll(Action original, Action toRemove)
	{
		if ((Delegate)(object)original == (Delegate)null)
		{
			return null;
		}
		Il2CppReferenceArray<Delegate> invocationList = ((Delegate)original).GetInvocationList();
		Action val = null;
		foreach (Delegate item in (Il2CppArrayBase<Delegate>)(object)invocationList)
		{
			if (!((Object)item).Equals((Object)(object)toRemove))
			{
				val = (((Delegate)(object)val == (Delegate)null) ? ((Il2CppObjectBase)item).Cast<Action>() : ((Il2CppObjectBase)Delegate.Combine((Delegate)(object)val, item)).Cast<Action>());
			}
		}
		return val;
	}
}

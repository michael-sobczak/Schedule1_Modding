using System;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence;
using MelonLoader;
using UnityEngine;
using UnityEngine.Events;

namespace S1API.Lifecycle;

public static class GameLifecycle
{
	private static bool _initialized;

	public static event Action OnPreLoad;

	internal static void Initialize()
	{
		if (!_initialized)
		{
			LoadManager instance = Singleton<LoadManager>.Instance;
			if (!((Object)(object)instance == (Object)null))
			{
				instance.onPreLoad.AddListener(UnityAction.op_Implicit((Action)InvokeOnPreLoad));
				_initialized = true;
			}
		}
	}

	internal static void Reset()
	{
		_initialized = false;
	}

	private static void InvokeOnPreLoad()
	{
		try
		{
			GameLifecycle.OnPreLoad?.Invoke();
		}
		catch (Exception value)
		{
			MelonLogger.Error($"Error in GameLifecycle.OnPreLoad: {value}");
		}
	}
}

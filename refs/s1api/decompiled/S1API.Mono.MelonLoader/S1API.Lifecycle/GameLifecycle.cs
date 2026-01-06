using System;
using MelonLoader;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace S1API.Lifecycle;

public static class GameLifecycle
{
	private static bool _initialized;

	public static event Action OnPreLoad;

	internal static void Initialize()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if (!_initialized)
		{
			LoadManager instance = Singleton<LoadManager>.Instance;
			if (!((Object)(object)instance == (Object)null))
			{
				instance.onPreLoad.AddListener(new UnityAction(InvokeOnPreLoad));
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
		catch (Exception arg)
		{
			MelonLogger.Error($"Error in GameLifecycle.OnPreLoad: {arg}");
		}
	}
}

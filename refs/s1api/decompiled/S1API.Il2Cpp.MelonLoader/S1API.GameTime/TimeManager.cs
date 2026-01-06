using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.GameTime;
using Il2CppSystem;
using UnityEngine;

namespace S1API.GameTime;

public static class TimeManager
{
	public static Action OnDayPass;

	public static Action OnWeekPass;

	public static Action OnSleepStart;

	public static Action<int> OnSleepEnd;

	public static Action OnTick;

	private static int _lastSleepSkippedMinutes;

	private static TimeManager _boundInstance;

	private static readonly Action DayPassHandler;

	private static readonly Action WeekPassHandler;

	private static readonly Action TickHandler;

	private static readonly Action SleepStartHandler;

	private static readonly Action<int> TimeSkipHandler;

	private static readonly Action SleepEndHandler;

	public static Day CurrentDay => (Day)NetworkSingleton<TimeManager>.Instance.CurrentDay;

	public static int ElapsedDays => NetworkSingleton<TimeManager>.Instance.ElapsedDays;

	public static int CurrentTime => NetworkSingleton<TimeManager>.Instance.CurrentTime;

	public static bool IsNight => NetworkSingleton<TimeManager>.Instance.IsNight;

	public static bool IsEndOfDay => NetworkSingleton<TimeManager>.Instance.IsEndOfDay;

	public static bool SleepInProgress => NetworkSingleton<TimeManager>.Instance.SleepInProgress;

	public static bool TimeOverridden => NetworkSingleton<TimeManager>.Instance.TimeOverridden;

	public static float NormalizedTime => NetworkSingleton<TimeManager>.Instance.NormalizedTime;

	public static float Playtime => NetworkSingleton<TimeManager>.Instance.Playtime;

	static TimeManager()
	{
		OnDayPass = delegate
		{
		};
		OnWeekPass = delegate
		{
		};
		OnSleepStart = delegate
		{
		};
		OnSleepEnd = delegate
		{
		};
		OnTick = delegate
		{
		};
		DayPassHandler = delegate
		{
			OnDayPass();
		};
		WeekPassHandler = delegate
		{
			OnWeekPass();
		};
		TickHandler = delegate
		{
			OnTick();
		};
		SleepStartHandler = delegate
		{
			OnSleepStart();
		};
		TimeSkipHandler = delegate(int minutes)
		{
			_lastSleepSkippedMinutes = minutes;
		};
		SleepEndHandler = delegate
		{
			OnSleepEnd(_lastSleepSkippedMinutes);
		};
		TryBindToCurrentInstance();
	}

	internal static void TryBindToCurrentInstance()
	{
		TimeManager instance = NetworkSingleton<TimeManager>.Instance;
		if (!((Object)(object)instance == (Object)null) && instance != _boundInstance)
		{
			UnbindFromInstance(_boundInstance);
			_boundInstance = instance;
			instance.onDayPass += Action.op_Implicit(DayPassHandler);
			instance.onWeekPass += Action.op_Implicit(WeekPassHandler);
			AddToActionList(instance.onTick, TickHandler);
			instance.onSleepStart += Action.op_Implicit(SleepStartHandler);
			instance.onTimeSkip += Action<int>.op_Implicit(TimeSkipHandler);
			instance.onSleepEnd += Action.op_Implicit(SleepEndHandler);
		}
	}

	internal static void ResetBindings()
	{
		UnbindFromInstance(_boundInstance);
		_boundInstance = null;
		_lastSleepSkippedMinutes = 0;
	}

	private static void UnbindFromInstance(TimeManager instance)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.onDayPass -= Action.op_Implicit(DayPassHandler);
			instance.onWeekPass -= Action.op_Implicit(WeekPassHandler);
			RemoveFromActionList(instance.onTick, TickHandler);
			instance.onSleepStart -= Action.op_Implicit(SleepStartHandler);
			instance.onTimeSkip -= Action<int>.op_Implicit(TimeSkipHandler);
			instance.onSleepEnd -= Action.op_Implicit(SleepEndHandler);
		}
	}

	private static void AddToActionList(object actionList, Action handler)
	{
		if (actionList == null)
		{
			return;
		}
		MethodInfo method = actionList.GetType().GetMethod("Add", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (!(method == null))
		{
			object obj = handler;
			ParameterInfo[] parameters = method.GetParameters();
			if (parameters.Length != 0 && parameters[0].ParameterType == typeof(Action))
			{
				obj = DelegateSupport.ConvertDelegate<Action>((Delegate)handler);
			}
			method.Invoke(actionList, new object[1] { obj });
		}
	}

	private static void RemoveFromActionList(object actionList, Action handler)
	{
		if (actionList == null)
		{
			return;
		}
		MethodInfo method = actionList.GetType().GetMethod("Remove", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (!(method == null))
		{
			object obj = handler;
			ParameterInfo[] parameters = method.GetParameters();
			if (parameters.Length != 0 && parameters[0].ParameterType == typeof(Action))
			{
				obj = DelegateSupport.ConvertDelegate<Action>((Delegate)handler);
			}
			method.Invoke(actionList, new object[1] { obj });
		}
	}

	public static void FastForwardToWakeTime()
	{
		NetworkSingleton<TimeManager>.Instance.FastForwardToWakeTime();
	}

	public static void SetTime(int time24h, bool local = false)
	{
		NetworkSingleton<TimeManager>.Instance.SetTime(time24h, local);
	}

	public static void SetElapsedDays(int days)
	{
		NetworkSingleton<TimeManager>.Instance.SetElapsedDays(days);
	}

	public static string GetFormatted12HourTime()
	{
		return TimeManager.Get12HourTime((float)CurrentTime, true);
	}

	public static bool IsCurrentTimeWithinRange(int startTime24h, int endTime24h)
	{
		return NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(startTime24h, endTime24h);
	}

	public static int GetMinutesFrom24HourTime(int time24h)
	{
		return TimeManager.GetMinSumFrom24HourTime(time24h);
	}

	public static int Get24HourTimeFromMinutes(int minutes)
	{
		return TimeManager.Get24HourTimeFromMinSum(minutes);
	}
}

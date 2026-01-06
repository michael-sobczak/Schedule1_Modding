using System;
using System.Reflection;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
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
			instance.onDayPass = (Action)Delegate.Combine(instance.onDayPass, DayPassHandler);
			instance.onWeekPass = (Action)Delegate.Combine(instance.onWeekPass, WeekPassHandler);
			AddToActionList(instance.onTick, TickHandler);
			instance.onSleepStart = (Action)Delegate.Combine(instance.onSleepStart, SleepStartHandler);
			instance.onTimeSkip = (Action<int>)Delegate.Combine(instance.onTimeSkip, TimeSkipHandler);
			instance.onSleepEnd = (Action)Delegate.Combine(instance.onSleepEnd, SleepEndHandler);
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
			instance.onDayPass = (Action)Delegate.Remove(instance.onDayPass, DayPassHandler);
			instance.onWeekPass = (Action)Delegate.Remove(instance.onWeekPass, WeekPassHandler);
			RemoveFromActionList(instance.onTick, TickHandler);
			instance.onSleepStart = (Action)Delegate.Remove(instance.onSleepStart, SleepStartHandler);
			instance.onTimeSkip = (Action<int>)Delegate.Remove(instance.onTimeSkip, TimeSkipHandler);
			instance.onSleepEnd = (Action)Delegate.Remove(instance.onSleepEnd, SleepEndHandler);
		}
	}

	private static void AddToActionList(object actionList, Action handler)
	{
		if (actionList != null)
		{
			MethodInfo method = actionList.GetType().GetMethod("Add", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (!(method == null))
			{
				method.Invoke(actionList, new object[1] { handler });
			}
		}
	}

	private static void RemoveFromActionList(object actionList, Action handler)
	{
		if (actionList != null)
		{
			MethodInfo method = actionList.GetType().GetMethod("Remove", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (!(method == null))
			{
				method.Invoke(actionList, new object[1] { handler });
			}
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

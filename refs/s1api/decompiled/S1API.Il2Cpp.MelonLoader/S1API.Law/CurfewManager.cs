using Il2CppFishNet.Connection;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Law;
using UnityEngine;

namespace S1API.Law;

public static class CurfewManager
{
	public const int HourBeforeCurfew = 2000;

	public const int WarningTime = 2030;

	public const int CurfewStartTime = 2100;

	public const int HardCurfewStartTime = 2115;

	public const int CurfewEndTime = 500;

	private static CurfewManager Internal => NetworkSingleton<CurfewManager>.Instance;

	public static bool IsEnabled => (Object)(object)Internal != (Object)null && Internal.IsEnabled;

	public static bool IsCurrentlyActive => (Object)(object)Internal != (Object)null && Internal.IsCurrentlyActive;

	public static bool IsHardCurfewActive => (Object)(object)Internal != (Object)null && Internal.IsHardCurfewActive;

	public static void EnableCurfew()
	{
		if (!((Object)(object)Internal == (Object)null))
		{
			Internal.Enable((NetworkConnection)null);
		}
	}

	public static void DisableCurfew()
	{
		if (!((Object)(object)Internal == (Object)null))
		{
			Internal.Disable();
		}
	}

	public static bool IsWithinCurfewHours()
	{
		if (!NetworkSingleton<TimeManager>.InstanceExists)
		{
			return false;
		}
		return NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(2100, 500);
	}

	public static bool IsWithinHardCurfewHours()
	{
		if (!NetworkSingleton<TimeManager>.InstanceExists)
		{
			return false;
		}
		return NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(2115, 500);
	}

	public static int MinutesUntilCurfew()
	{
		if (!NetworkSingleton<TimeManager>.InstanceExists)
		{
			return 0;
		}
		int currentTime = NetworkSingleton<TimeManager>.Instance.CurrentTime;
		if (NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(2100, 500))
		{
			return 0;
		}
		return TimeManager.GetMinSumFrom24HourTime(2100) - TimeManager.GetMinSumFrom24HourTime(currentTime);
	}

	public static int MinutesUntilCurfewEnds()
	{
		if (!NetworkSingleton<TimeManager>.InstanceExists)
		{
			return 0;
		}
		int currentTime = NetworkSingleton<TimeManager>.Instance.CurrentTime;
		if (!NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(2100, 500))
		{
			return 0;
		}
		return TimeManager.GetMinSumFrom24HourTime(500) - TimeManager.GetMinSumFrom24HourTime(currentTime);
	}
}

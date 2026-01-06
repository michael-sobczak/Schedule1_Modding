using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Law;
using UnityEngine;

namespace S1API.Law;

public static class LawController
{
	public const int MinIntensity = 1;

	public const int MaxIntensity = 10;

	public const float DailyIntensityDrain = 0.05f;

	private static LawController Internal => Singleton<LawController>.Instance;

	public static int Intensity
	{
		get
		{
			if ((Object)(object)Internal == (Object)null)
			{
				return 1;
			}
			return Internal.LE_Intensity;
		}
	}

	public static float InternalIntensity
	{
		get
		{
			if ((Object)(object)Internal == (Object)null)
			{
				return 0f;
			}
			return 0f;
		}
	}

	public static bool IsUsingOverrideSettings
	{
		get
		{
			if ((Object)(object)Internal == (Object)null)
			{
				return false;
			}
			return Internal.OverrideSettings;
		}
	}

	public static void ChangeIntensity(float change)
	{
		if (!((Object)(object)Internal == (Object)null))
		{
			Internal.ChangeInternalIntensity(change);
		}
	}

	public static void SetInternalIntensity(float intensity)
	{
		if (!((Object)(object)Internal == (Object)null))
		{
			Internal.SetInternalIntensity(intensity);
		}
	}

	public static void SetIntensityLevel(int level)
	{
		if (!((Object)(object)Internal == (Object)null))
		{
			float internalIntensity = Mathf.InverseLerp(1f, 10f, (float)level);
			Internal.SetInternalIntensity(internalIntensity);
		}
	}

	public static void OverrideActivitySettings(LawActivitySettings settings)
	{
		if (!((Object)(object)Internal == (Object)null))
		{
			if (settings != null)
			{
				Internal.OverrideSetings(settings);
			}
			else
			{
				Internal.EndOverride();
			}
		}
	}

	public static void ClearActivitySettingsOverride()
	{
		if (!((Object)(object)Internal == (Object)null))
		{
			Internal.EndOverride();
		}
	}
}

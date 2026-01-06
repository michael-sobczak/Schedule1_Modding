using System;
using MelonLoader;

namespace S1API.Graffiti;

public static class GraffitiEvents
{
	public static event Action<SpraySurface>? GraffitiCompleted;

	internal static void OnGraffitiRewarded(SpraySurface spraySurface)
	{
		try
		{
			GraffitiEvents.GraffitiCompleted?.Invoke(spraySurface);
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[S1API.GraffitiEvents] Error in OnGraffitiRewarded: " + ex.Message);
			MelonLogger.Error("[S1API.GraffitiEvents] StackTrace: " + ex.StackTrace);
		}
	}
}

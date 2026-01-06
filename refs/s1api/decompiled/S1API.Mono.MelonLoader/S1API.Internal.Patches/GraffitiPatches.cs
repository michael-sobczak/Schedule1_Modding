using System;
using HarmonyLib;
using S1API.Graffiti;
using S1API.Logging;
using ScheduleOne.Graffiti;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal class GraffitiPatches
{
	private static readonly Log Logger = new Log("GraffitiPatches");

	[HarmonyPatch(typeof(SpraySurfaceInteraction), "Reward")]
	[HarmonyPostfix]
	private static void SpraySurfaceInteraction_Reward_Postfix(SpraySurfaceInteraction __instance)
	{
		try
		{
			if ((Object)(object)__instance == (Object)null)
			{
				Logger.Warning("__instance is null in Reward patch");
				return;
			}
			if ((Object)(object)__instance.SpraySurface == (Object)null)
			{
				Logger.Warning("SpraySurface is null in Reward patch");
				return;
			}
			SpraySurface spraySurface = new SpraySurface(__instance.SpraySurface);
			GraffitiEvents.OnGraffitiRewarded(spraySurface);
		}
		catch (Exception ex)
		{
			Logger.Error("Error in Reward patch: " + ex.Message);
			Logger.Error("StackTrace: " + ex.StackTrace);
		}
	}
}

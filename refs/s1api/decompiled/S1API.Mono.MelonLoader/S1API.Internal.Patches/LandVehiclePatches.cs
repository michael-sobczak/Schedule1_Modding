using HarmonyLib;
using S1API.Vehicles;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch(typeof(LandVehicle))]
internal class LandVehiclePatches
{
	[HarmonyPatch("OnDestroy")]
	[HarmonyPostfix]
	public static void OnDestroy(LandVehicle __instance)
	{
		try
		{
			if ((Object)(object)__instance != (Object)null)
			{
				VehicleRegistry.RemoveVehicle(__instance.GUID.ToString());
			}
		}
		catch
		{
		}
	}
}

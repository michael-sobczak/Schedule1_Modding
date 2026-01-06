using HarmonyLib;
using Il2CppScheduleOne.Vehicles;
using S1API.Vehicles;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch(typeof(LandVehicle))]
internal class LandVehiclePatches
{
	[HarmonyPatch("OnDestroy")]
	[HarmonyPostfix]
	public static void OnDestroy(LandVehicle __instance)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Object)(object)__instance != (Object)null)
			{
				VehicleRegistry.RemoveVehicle(((object)__instance.GUID/*cast due to .constrained prefix*/).ToString());
			}
		}
		catch
		{
		}
	}
}

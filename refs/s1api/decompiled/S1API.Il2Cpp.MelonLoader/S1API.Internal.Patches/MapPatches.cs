using HarmonyLib;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Map;
using S1API.Map;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal class MapPatches
{
	[HarmonyPatch(typeof(NPCEnterableBuilding), "Awake")]
	[HarmonyPostfix]
	private static void NPCEnterableBuildingAwake(NPCEnterableBuilding __instance)
	{
		global::S1API.Map.Building.Register(__instance);
	}

	[HarmonyPatch(typeof(DeliveryLocation), "Awake")]
	[HarmonyPostfix]
	private static void DeliveryLocationAwake(DeliveryLocation __instance)
	{
		DeliveryLocation.Register(__instance);
	}

	[HarmonyPatch(typeof(ParkingLot), "Awake")]
	[HarmonyPostfix]
	private static void ParkingLotAwake(ParkingLot __instance)
	{
		ParkingLotRegistry.Register(__instance);
	}
}

using HarmonyLib;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.UI.Phone.ProductManagerApp;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch(typeof(ProductManagerApp), "Start")]
internal static class ProductManagerAppStartPatch
{
	private static bool Prefix(ProductManagerApp __instance)
	{
		if (((Object)((Component)__instance).gameObject).name != "ProductManagerApp")
		{
			((App<ProductManagerApp>)(object)__instance).SetOpen(false);
			return false;
		}
		return true;
	}
}

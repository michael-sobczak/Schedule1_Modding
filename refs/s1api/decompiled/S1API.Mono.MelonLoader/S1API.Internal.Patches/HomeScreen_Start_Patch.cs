using System;
using System.Collections.Generic;
using HarmonyLib;
using S1API.Internal.Abstraction;
using S1API.Internal.Utils;
using S1API.Logging;
using S1API.PhoneApp;
using ScheduleOne.UI.Phone;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace S1API.Internal.Patches;

[HarmonyPatch(typeof(HomeScreen), "Start")]
internal static class HomeScreen_Start_Patch
{
	private static readonly Log Logger = new Log("PhoneApp");

	private static void Postfix(HomeScreen __instance)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)__instance == (Object)null)
		{
			return;
		}
		Scene activeScene = SceneManager.GetActiveScene();
		if (!string.Equals(((Scene)(ref activeScene)).name, "Main", StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		List<Type> derivedClasses = ReflectionUtils.GetDerivedClasses<global::S1API.PhoneApp.PhoneApp>();
		foreach (Type item in derivedClasses)
		{
			Logger.Msg("Found phone app: " + item.FullName);
			if (!(item.GetConstructor(Type.EmptyTypes) == null))
			{
				try
				{
					global::S1API.PhoneApp.PhoneApp phoneApp = (global::S1API.PhoneApp.PhoneApp)Activator.CreateInstance(item);
					((IRegisterable)phoneApp).CreateInternal();
					phoneApp.SpawnUI(__instance);
					phoneApp.SpawnIcon(__instance);
				}
				catch (Exception ex)
				{
					Logger.Warning("[PhoneApp] Failed to register " + item.FullName + ": " + ex.Message);
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using HarmonyLib;
using MelonLoader;
using S1API.Internal.Abstraction;
using S1API.Saveables;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal static class GenericSaveablesPatches
{
	private static string lastLoadedGameFolderPath;

	[HarmonyPatch(typeof(SaveManager), "Save", new Type[] { typeof(string) })]
	[HarmonyPostfix]
	private static void SaveManager_Save_Postfix(string saveFolderPath)
	{
		try
		{
			SaveManager instance = Singleton<SaveManager>.Instance;
			string item = "Modded";
			string item2 = Path.Combine("Modded", "Saveables");
			if (!instance.ApprovedBaseLevelPaths.Contains(item))
			{
				instance.ApprovedBaseLevelPaths.Add(item);
			}
			if (!instance.ApprovedBaseLevelPaths.Contains(item2))
			{
				instance.ApprovedBaseLevelPaths.Add(item2);
			}
			string text = Path.Combine(saveFolderPath, "Modded", "Saveables");
			Directory.CreateDirectory(text);
			foreach (Saveable registeredSaveable in SaveableAutoRegistry.GetRegisteredSaveables())
			{
				List<string> extraSaveables = new List<string>();
				string name = registeredSaveable.GetType().Name;
				string text2 = Path.Combine(text, name);
				Directory.CreateDirectory(text2);
				registeredSaveable.SaveInternal(text2, ref extraSaveables);
			}
		}
		catch (Exception ex)
		{
			try
			{
				MelonLogger.Warning("[Saveables] SaveManager_Save_Postfix failed: " + ex.Message + "\n" + ex.StackTrace);
			}
			catch
			{
			}
		}
	}

	[HarmonyPatch(typeof(LoadManager), "QueueLoadRequest")]
	[HarmonyPrefix]
	private static void BeforeBaseLoaders(LoadRequest request)
	{
		try
		{
			LoadManager lm = Singleton<LoadManager>.Instance;
			if ((Object)(object)lm == (Object)null || string.IsNullOrEmpty(lm.LoadedGameFolderPath) || lastLoadedGameFolderPath == lm.LoadedGameFolderPath)
			{
				return;
			}
			lastLoadedGameFolderPath = lm.LoadedGameFolderPath;
			string path = Path.Combine(lm.LoadedGameFolderPath, "Modded", "Saveables");
			foreach (Saveable registeredSaveable in SaveableAutoRegistry.GetRegisteredSaveables())
			{
				Saveable saveable = registeredSaveable;
				if (saveable.LoadOrder == SaveableLoadOrder.BeforeBaseGame)
				{
					string name = saveable.GetType().Name;
					string text = Path.Combine(path, name);
					if (Directory.Exists(text))
					{
						saveable.LoadInternal(text);
					}
					else
					{
						EventHelper.AddListener(InitializeOnLoadComplete, lm.onLoadComplete);
					}
				}
				void InitializeOnLoadComplete()
				{
					try
					{
						EventHelper.RemoveListener(InitializeOnLoadComplete, lm.onLoadComplete);
						((IRegisterable)saveable).CreateInternal();
					}
					catch (Exception ex2)
					{
						try
						{
							MelonLogger.Warning("[Saveables] InitializeOnLoadComplete (Before) failed: " + ex2.Message + "\n" + ex2.StackTrace);
						}
						catch
						{
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			try
			{
				MelonLogger.Warning("[Saveables] BeforeBaseLoaders failed: " + ex.Message + "\n" + ex.StackTrace);
			}
			catch
			{
			}
		}
	}

	[HarmonyPatch(typeof(NPCsLoader), "Load")]
	[HarmonyPostfix]
	private static void AfterBaseLoaders(string mainPath)
	{
		try
		{
			string path = Path.Combine(Singleton<LoadManager>.Instance.LoadedGameFolderPath, "Modded", "Saveables");
			foreach (Saveable registeredSaveable in SaveableAutoRegistry.GetRegisteredSaveables())
			{
				Saveable saveable = registeredSaveable;
				LoadManager lm;
				if (saveable.LoadOrder == SaveableLoadOrder.AfterBaseGame)
				{
					string name = saveable.GetType().Name;
					string text = Path.Combine(path, name);
					if (Directory.Exists(text))
					{
						saveable.LoadInternal(text);
						continue;
					}
					lm = Singleton<LoadManager>.Instance;
					EventHelper.AddListener(InitializeOnLoadComplete, lm.onLoadComplete);
				}
				void InitializeOnLoadComplete()
				{
					try
					{
						EventHelper.RemoveListener(InitializeOnLoadComplete, lm.onLoadComplete);
						((IRegisterable)saveable).CreateInternal();
					}
					catch (Exception ex2)
					{
						try
						{
							MelonLogger.Warning("[Saveables] InitializeOnLoadComplete (After) failed: " + ex2.Message + "\n" + ex2.StackTrace);
						}
						catch
						{
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			try
			{
				MelonLogger.Warning("[Saveables] AfterBaseLoaders failed: " + ex.Message + "\n" + ex.StackTrace);
			}
			catch
			{
			}
		}
	}
}

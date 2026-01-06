using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json;
using S1API.Internal.Abstraction;
using S1API.Internal.Utils;
using S1API.Logging;
using S1API.Quests;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal class QuestPatches
{
	protected static readonly Log Logger = new Log("QuestPatches");

	private static readonly Dictionary<string, QuestData> _pendingQuestDataByGuid = new Dictionary<string, QuestData>();

	[HarmonyPatch(typeof(SaveManager), "Save", new Type[] { typeof(string) })]
	[HarmonyPostfix]
	private static void SaveManager_Save_Postfix(string saveFolderPath)
	{
		try
		{
			SaveManager instance = Singleton<SaveManager>.Instance;
			string[] array = new string[2]
			{
				"Modded",
				Path.Combine("Modded", "Quests")
			};
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (!instance.ApprovedBaseLevelPaths.Contains(text))
				{
					instance.ApprovedBaseLevelPaths.Add(text);
				}
			}
			string text2 = Path.Combine(saveFolderPath, "Modded", "Quests");
			Directory.CreateDirectory(text2);
			try
			{
				string[] directories = Directory.GetDirectories(text2);
				for (int j = 0; j < directories.Length; j++)
				{
					string fileName = Path.GetFileName(directories[j]);
					if (string.IsNullOrEmpty(fileName))
					{
						continue;
					}
					string text3 = ((fileName.StartsWith("Quest_") && fileName.Length > 6) ? fileName.Substring(6) : string.Empty);
					bool flag = false;
					if (!string.IsNullOrEmpty(text3))
					{
						for (int k = 0; k < QuestManager.Quests.Count; k++)
						{
							Quest quest = QuestManager.Quests[k];
							if (quest != null && (Object)(object)quest.S1Quest != (Object)null && quest.S1Quest.StaticGUID == text3)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						try
						{
							Directory.Delete(directories[j], recursive: true);
						}
						catch
						{
						}
					}
				}
			}
			catch (Exception)
			{
			}
			foreach (Quest quest2 in QuestManager.Quests)
			{
				if (!quest2.GetType().Namespace.StartsWith("ScheduleOne"))
				{
					List<string> extraSaveables = new List<string>();
					quest2.SaveInternal(text2, ref extraSaveables);
				}
			}
		}
		catch (Exception ex2)
		{
			Logger.Error("[S1API] ❌ Failed to save modded quests:\n" + ex2);
		}
	}

	[HarmonyPatch(typeof(QuestsLoader), "Load")]
	[HarmonyPrefix]
	private static void QuestsLoaderLoad_Prefix(string mainPath)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(mainPath))
		{
			return;
		}
		string text = File.ReadAllText(mainPath);
		QuestManagerData val = JsonUtility.FromJson<QuestManagerData>(text);
		if (((val != null) ? val.Quests : null) == null)
		{
			return;
		}
		foreach (QuestData item in (Il2CppArrayBase<QuestData>)(object)val.Quests)
		{
			if (item == null || string.IsNullOrEmpty(item.GUID))
			{
				continue;
			}
			try
			{
				Quest val2 = GUIDManager.GetObject<Quest>(new Guid(item.GUID));
				if ((Object)(object)val2 == (Object)null)
				{
					_pendingQuestDataByGuid[item.GUID] = item;
				}
			}
			catch
			{
				_pendingQuestDataByGuid[item.GUID] = item;
			}
		}
	}

	[HarmonyPatch(typeof(QuestsLoader), "Load")]
	[HarmonyPostfix]
	private static void QuestsLoaderLoad_Postfix(QuestsLoader __instance, string mainPath)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Invalid comparison between Unknown and I4
		string directoryName = Path.GetDirectoryName(mainPath);
		string path = Path.Combine(directoryName, "Quests.json");
		if (File.Exists(path))
		{
			try
			{
				string text = File.ReadAllText(path);
				QuestManagerData val = JsonUtility.FromJson<QuestManagerData>(text);
				if (((val != null) ? val.Quests : null) != null)
				{
					foreach (QuestData item in (Il2CppArrayBase<QuestData>)(object)val.Quests)
					{
						if (item == null || string.IsNullOrEmpty(item.GUID))
						{
							continue;
						}
						try
						{
							Quest val2 = GUIDManager.GetObject<Quest>(new Guid(item.GUID));
							if ((Object)(object)val2 == (Object)null)
							{
								_pendingQuestDataByGuid[item.GUID] = item;
							}
						}
						catch
						{
							_pendingQuestDataByGuid[item.GUID] = item;
						}
					}
				}
			}
			catch (Exception value)
			{
				Logger.Error($"Failed to load quest data from main Quests.json: {value}");
			}
		}
		string text2 = Path.Combine(Singleton<LoadManager>.Instance.LoadedGameFolderPath, "Modded", "Quests");
		if (!Directory.Exists(text2))
		{
			Directory.CreateDirectory(text2);
			return;
		}
		string[] array = (from directory in Directory.GetDirectories(text2).Select(Path.GetFileName)
			where directory?.StartsWith("Quest_") ?? false
			select directory).ToArray();
		string[] array2 = array;
		string text6 = default(string);
		foreach (string text3 in array2)
		{
			string text4 = Path.Combine(text2, text3);
			string text5 = Path.Combine(text4, "QuestData");
			if (!((Loader)__instance).TryLoadFile(text5, ref text6, true))
			{
				Logger.Warning("Failed to load QuestData.json from: " + text5);
				continue;
			}
			QuestData questData = JsonConvert.DeserializeObject<QuestData>(text6, ISaveable.SerializerSettings);
			if (questData?.ClassName == null)
			{
				Logger.Warning("QuestData has no ClassName");
				continue;
			}
			Type typeByName = ReflectionUtils.GetTypeByName(questData.ClassName);
			if (typeByName == null || !typeof(Quest).IsAssignableFrom(typeByName))
			{
				Logger.Warning("Failed to find quest type: " + questData.ClassName);
				continue;
			}
			string value2 = (text3.StartsWith("Quest_") ? text3.Substring(6) : text3);
			QuestData val3 = null;
			foreach (KeyValuePair<string, QuestData> item2 in _pendingQuestDataByGuid)
			{
				if (item2.Key.StartsWith(value2, StringComparison.OrdinalIgnoreCase))
				{
					val3 = item2.Value;
					break;
				}
			}
			if (val3 == null)
			{
				Logger.Warning("No QuestData found for quest directory: " + text3);
			}
			else if ((int)val3.State == 1)
			{
				Quest quest = QuestManager.CreateQuest(typeByName, val3.GUID);
				quest.S1Quest.StaticGUID = val3.GUID;
				quest.LoadInternal(text4);
			}
		}
	}

	[HarmonyPatch(typeof(Quest), "Start")]
	[HarmonyPrefix]
	private static void QuestStart(Quest __instance)
	{
		Quest quest = QuestManager.Quests.FirstOrDefault((Quest q) => (Object)(object)q.S1Quest == (Object)(object)__instance);
		if (quest != null)
		{
			quest.CreateInternal();
			string staticGUID = __instance.StaticGUID;
			if (!string.IsNullOrEmpty(staticGUID) && _pendingQuestDataByGuid.TryGetValue(staticGUID, out QuestData value))
			{
				__instance.Load(value);
				_pendingQuestDataByGuid.Remove(staticGUID);
			}
		}
	}

	[HarmonyPatch(typeof(QuestEntry), "CreateCompassElement")]
	[HarmonyPrefix]
	private static bool QuestEntry_CreateCompassElement_Prefix(QuestEntry __instance)
	{
		object obj = ReflectionUtils.TryGetFieldOrProperty(__instance, "PoILocation");
		if (obj == null)
		{
			return false;
		}
		return true;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Il2CppScheduleOne.Quests;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using S1API.Quests.Identifiers;
using UnityEngine;

namespace S1API.Quests;

public static class QuestManager
{
	internal static readonly List<Quest> Quests = new List<Quest>();

	public static Quest CreateQuest<T>(string? guid = null) where T : Quest
	{
		return CreateQuest(typeof(T), guid);
	}

	public static Quest CreateQuest(Type questType, string? guid = null)
	{
		Quest quest = (Quest)Activator.CreateInstance(questType);
		if (quest == null)
		{
			throw new Exception("Unable to create quest instance of " + questType.FullName + "!");
		}
		Quests.Add(quest);
		return quest;
	}

	public static Quest? GetQuestByGuid(string guid)
	{
		return Quests.FirstOrDefault((Quest x) => x.S1Quest.StaticGUID == guid);
	}

	public static Quest? GetQuestByName(string questName)
	{
		return Quests.FirstOrDefault((Quest x) => x.S1Quest.Title == questName);
	}

	internal static object? GetBaseGameQuestByName(string questTitle)
	{
		try
		{
			List<Quest> quests = Quest.Quests;
			if (quests != null)
			{
				for (int i = 0; i < quests.Count; i++)
				{
					Quest val = quests[i];
					if ((Object)(object)val != (Object)null && val.Title == questTitle)
					{
						return val;
					}
				}
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[QuestManager] Exception while searching for base game quest '" + questTitle + "': " + ex.Message);
		}
		return null;
	}

	public static QuestWrapper? Get<T>() where T : IQuestIdentifier
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		Type typeFromHandle = typeof(T);
		string text = TryGetNameFromIdentifier(typeFromHandle);
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		Quest questByName = GetQuestByName(text);
		if (questByName != null)
		{
			return new QuestWrapper(questByName);
		}
		object baseGameQuestByName = GetBaseGameQuestByName(text);
		if (baseGameQuestByName != null)
		{
			return new QuestWrapper((Quest)baseGameQuestByName);
		}
		return null;
	}

	private static string TryGetNameFromIdentifier(Type t)
	{
		try
		{
			object obj = t.GetCustomAttributes(inherit: false).FirstOrDefault((object a) => a.GetType().FullName == typeof(QuestNameAttribute).FullName);
			if (obj != null)
			{
				return obj.GetType().GetProperty("Name", BindingFlags.Instance | BindingFlags.Public)?.GetValue(obj) as string;
			}
		}
		catch
		{
		}
		return null;
	}
}

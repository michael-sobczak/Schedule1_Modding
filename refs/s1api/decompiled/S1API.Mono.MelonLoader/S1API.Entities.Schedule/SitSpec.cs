using System;
using System.Text;
using FishNet.Object;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.NPCs.Schedules;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class SitSpec : IScheduleActionSpec
{
	public int StartTime { get; set; }

	public string Name { get; set; }

	public bool WarpIfSkipped { get; set; }

	public Object SeatSetReference { get; set; }

	public string SeatSetPath { get; set; }

	public string SeatSetName { get; set; }

	public bool IncludeInactiveSearch { get; set; } = true;

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		if (schedule == null)
		{
			return;
		}
		NPCEvent_Sit val = schedule.AddActionInternal<NPCEvent_Sit>(StartTime, string.IsNullOrEmpty(Name) ? "Sit" : Name);
		if (!((Object)(object)val == (Object)null))
		{
			try
			{
				((NetworkBehaviour)val).NetworkInitializeIfDisabled();
			}
			catch
			{
			}
			AvatarSeatSet val2 = ResolveSeatSet(schedule);
			if ((Object)(object)val2 != (Object)null)
			{
				val.SeatSet = val2;
			}
			else
			{
				string text = (((Object)(object)schedule.NPC?.gameObject != (Object)null) ? ((Object)schedule.NPC.gameObject).name : "Unknown");
				Debug.LogWarning((object)("[S1API] SitSpec could not resolve a seat set (Name=" + SeatSetName + ", Path=" + SeatSetPath + ") for NPC '" + text + "'."));
			}
			val.WarpIfSkipped = WarpIfSkipped;
		}
	}

	private AvatarSeatSet ResolveSeatSet(NPCSchedule schedule)
	{
		AvatarSeatSet val = TryGetFromObject(SeatSetReference);
		if ((Object)(object)val != (Object)null)
		{
			return val;
		}
		AvatarSeatSet[] cache = null;
		if (!string.IsNullOrEmpty(SeatSetPath))
		{
			AvatarSeatSet val2 = TryResolveFromPath(SeatSetPath, ref cache);
			if ((Object)(object)val2 != (Object)null)
			{
				return val2;
			}
		}
		if (!string.IsNullOrEmpty(SeatSetName))
		{
			AvatarSeatSet val3 = TryResolveFromName(SeatSetName, ref cache);
			if ((Object)(object)val3 != (Object)null)
			{
				return val3;
			}
		}
		if ((Object)(object)schedule?.NPC?.gameObject != (Object)null)
		{
			Transform transform = schedule.NPC.gameObject.transform;
			if ((Object)(object)transform != (Object)null)
			{
				AvatarSeatSet componentInChildren = ((Component)transform).GetComponentInChildren<AvatarSeatSet>(IncludeInactiveSearch);
				if ((Object)(object)componentInChildren != (Object)null)
				{
					return componentInChildren;
				}
			}
		}
		return null;
	}

	private AvatarSeatSet TryResolveFromPath(string path, ref AvatarSeatSet[] cache)
	{
		if (string.IsNullOrEmpty(path))
		{
			return null;
		}
		try
		{
			GameObject obj = GameObject.Find(path);
			AvatarSeatSet val = TryGetFromObject((Object)(object)obj);
			if ((Object)(object)val != (Object)null)
			{
				return val;
			}
		}
		catch
		{
		}
		AvatarSeatSet[] array = cache ?? (cache = FindAllSeatSets());
		if (array == null || array.Length == 0)
		{
			return null;
		}
		foreach (AvatarSeatSet val2 in array)
		{
			if (!((Object)(object)val2 == (Object)null))
			{
				Transform transform = ((Component)val2).transform;
				if (!((Object)(object)transform == (Object)null) && MatchesPath(transform, path))
				{
					return val2;
				}
			}
		}
		return null;
	}

	private AvatarSeatSet TryResolveFromName(string name, ref AvatarSeatSet[] cache)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		AvatarSeatSet[] array = cache ?? (cache = FindAllSeatSets());
		if (array == null || array.Length == 0)
		{
			return null;
		}
		foreach (AvatarSeatSet val in array)
		{
			if (!((Object)(object)val == (Object)null))
			{
				GameObject gameObject = ((Component)val).gameObject;
				if (!((Object)(object)gameObject == (Object)null) && string.Equals(((Object)gameObject).name, name, StringComparison.OrdinalIgnoreCase))
				{
					return val;
				}
			}
		}
		return null;
	}

	private AvatarSeatSet[] FindAllSeatSets()
	{
		try
		{
			return Object.FindObjectsOfType<AvatarSeatSet>(IncludeInactiveSearch);
		}
		catch
		{
			return Array.Empty<AvatarSeatSet>();
		}
	}

	private static bool MatchesPath(Transform transform, string expectedPath)
	{
		if ((Object)(object)transform == (Object)null || string.IsNullOrEmpty(expectedPath))
		{
			return false;
		}
		string text = expectedPath.Replace('\\', '/');
		if (text.Length == 0)
		{
			return false;
		}
		string text2 = BuildHierarchyPath(transform);
		if (string.Equals(text2, text, StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		return text2.EndsWith(text, StringComparison.OrdinalIgnoreCase);
	}

	private static string BuildHierarchyPath(Transform transform)
	{
		if ((Object)(object)transform == (Object)null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(128);
		BuildPathRecursive(transform, stringBuilder);
		return stringBuilder.ToString();
	}

	private static void BuildPathRecursive(Transform node, StringBuilder builder)
	{
		if ((Object)(object)node == (Object)null)
		{
			return;
		}
		if ((Object)(object)node.parent != (Object)null)
		{
			BuildPathRecursive(node.parent, builder);
			if (builder.Length > 0)
			{
				builder.Append('/');
			}
		}
		builder.Append(((Object)node).name);
	}

	private static AvatarSeatSet TryGetFromObject(Object obj)
	{
		if (obj == (Object)null)
		{
			return null;
		}
		AvatarSeatSet val = (AvatarSeatSet)(object)((obj is AvatarSeatSet) ? obj : null);
		if (val != null)
		{
			return val;
		}
		GameObject val2 = (GameObject)(object)((obj is GameObject) ? obj : null);
		if (val2 != null)
		{
			return val2.GetComponent<AvatarSeatSet>();
		}
		Component val3 = (Component)(object)((obj is Component) ? obj : null);
		if (val3 != null)
		{
			return val3.GetComponent<AvatarSeatSet>();
		}
		return null;
	}
}

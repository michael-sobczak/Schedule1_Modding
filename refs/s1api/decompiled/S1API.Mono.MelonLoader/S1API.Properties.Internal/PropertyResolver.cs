using System;
using System.Collections.Generic;
using System.Linq;
using S1API.Properties.Interfaces;
using ScheduleOne.Effects;
using UnityEngine;

namespace S1API.Properties.Internal;

internal static class PropertyResolver
{
	private static readonly string[] SearchPaths = new string[5] { "Properties/Tier1", "Properties/Tier2", "Properties/Tier3", "Properties/Tier4", "Properties/Tier5" };

	internal static List<Effect> ResolveToGameProperties(IEnumerable<PropertyBase> items)
	{
		List<Effect> list = new List<Effect>();
		if (items == null)
		{
			return list;
		}
		foreach (PropertyBase item in items)
		{
			if (item == null)
			{
				continue;
			}
			if (item is ProductPropertyWrapper productPropertyWrapper)
			{
				Effect innerProperty = productPropertyWrapper.InnerProperty;
				if ((Object)(object)innerProperty != (Object)null && !list.Contains(innerProperty))
				{
					list.Add(innerProperty);
				}
			}
			else
			{
				Effect val = FindByIdOrName(item.ID, item.name);
				if ((Object)(object)val != (Object)null && !list.Contains(val))
				{
					list.Add(val);
				}
			}
		}
		return list;
	}

	private static Effect FindByIdOrName(string id, string unityName)
	{
		string idNorm = (id ?? string.Empty).Trim();
		string nameNorm = (unityName ?? string.Empty).Trim();
		string[] searchPaths = SearchPaths;
		foreach (string text in searchPaths)
		{
			Effect[] array = Resources.LoadAll<Effect>(text);
			if (array == null || array.Length == 0)
			{
				continue;
			}
			if (!string.IsNullOrEmpty(idNorm))
			{
				Effect val = ((IEnumerable<Effect>)array).FirstOrDefault((Func<Effect, bool>)((Effect p) => (Object)(object)p != (Object)null && string.Equals(p.ID, idNorm, StringComparison.OrdinalIgnoreCase)));
				if ((Object)(object)val != (Object)null)
				{
					return val;
				}
			}
			if (!string.IsNullOrEmpty(nameNorm))
			{
				Effect val2 = ((IEnumerable<Effect>)array).FirstOrDefault((Func<Effect, bool>)((Effect p) => (Object)(object)p != (Object)null && string.Equals(((Object)p).name, nameNorm, StringComparison.OrdinalIgnoreCase)));
				if ((Object)(object)val2 != (Object)null)
				{
					return val2;
				}
			}
		}
		return null;
	}
}

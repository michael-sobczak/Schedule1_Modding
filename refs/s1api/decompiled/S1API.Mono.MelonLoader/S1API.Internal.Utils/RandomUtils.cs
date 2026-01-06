using System;
using System.Collections.Generic;
using UnityEngine;

namespace S1API.Internal.Utils;

[Obsolete("This class is for internal API use only. Mod developers should use S1API.Utils.RandomUtils instead. This class will be made internal in a future version.")]
public static class RandomUtils
{
	private static readonly Random SystemRng = new Random();

	public static T PickOne<T>(this IList<T> list)
	{
		if (list == null || list.Count == 0)
		{
			return default(T);
		}
		return list[Random.Range(0, list.Count)];
	}

	public static T PickUnique<T>(this IList<T> list, Func<T, bool> isDuplicate, int maxTries = 10)
	{
		if (list.Count == 0)
		{
			return default(T);
		}
		for (int i = 0; i < maxTries; i++)
		{
			T val = list.PickOne();
			if (!isDuplicate(val))
			{
				return val;
			}
		}
		return default(T);
	}

	public static List<T> PickMany<T>(this IList<T> list, int count)
	{
		if (list.Count == 0)
		{
			return new List<T>();
		}
		List<T> list2 = new List<T>(list);
		List<T> list3 = new List<T>();
		for (int i = 0; i < count; i++)
		{
			if (list2.Count <= 0)
			{
				break;
			}
			int index = Random.Range(0, list2.Count);
			list3.Add(list2[index]);
			list2.RemoveAt(index);
		}
		return list3;
	}

	public static int RangeInt(int minInclusive, int maxExclusive)
	{
		return SystemRng.Next(minInclusive, maxExclusive);
	}
}

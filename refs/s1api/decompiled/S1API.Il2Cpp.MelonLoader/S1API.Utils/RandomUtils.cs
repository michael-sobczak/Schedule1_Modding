using System;
using System.Collections.Generic;
using S1API.Internal.Utils;

namespace S1API.Utils;

public static class RandomUtils
{
	public static T PickOne<T>(this IList<T> list)
	{
		return global::S1API.Internal.Utils.RandomUtils.PickOne(list);
	}

	public static T PickUnique<T>(this IList<T> list, Func<T, bool> isDuplicate, int maxTries = 10)
	{
		return global::S1API.Internal.Utils.RandomUtils.PickUnique(list, isDuplicate, maxTries);
	}

	public static List<T> PickMany<T>(this IList<T> list, int count)
	{
		return global::S1API.Internal.Utils.RandomUtils.PickMany(list, count);
	}

	public static int RangeInt(int minInclusive, int maxExclusive)
	{
		return global::S1API.Internal.Utils.RandomUtils.RangeInt(minInclusive, maxExclusive);
	}
}

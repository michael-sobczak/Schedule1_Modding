using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.Economy;
using UnityEngine;

namespace S1API.DeadDrops;

public static class DeadDropManager
{
	public static DeadDropInstance[] All => ((IEnumerable<DeadDrop>)DeadDrop.DeadDrops.ToArray()).Select((DeadDrop deadDrop) => new DeadDropInstance(deadDrop)).ToArray();

	public static DeadDropInstance[] Empty => All.Where((DeadDropInstance d) => d.IsEmpty).ToArray();

	public static DeadDropInstance? GetByGUID(string guid)
	{
		return All.FirstOrDefault((DeadDropInstance d) => string.Equals(d.GUID, guid, StringComparison.OrdinalIgnoreCase));
	}

	public static DeadDropInstance? GetClosest(Vector3 origin, bool mustBeEmpty = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		DeadDropInstance[] source = (mustBeEmpty ? Empty : All);
		return source.OrderBy((DeadDropInstance d) => Vector3.Distance(d.Position, origin)).FirstOrDefault();
	}

	public static DeadDropInstance? GetRandomEmptyNear(Vector3 origin)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		List<DeadDropInstance> list = Empty.OrderBy((DeadDropInstance d) => Vector3.Distance(d.Position, origin)).ToList();
		if (list.Count == 0)
		{
			return null;
		}
		if (list.Count > 1)
		{
			list.RemoveAt(0);
		}
		if (list.Count > 1)
		{
			list.RemoveRange(list.Count / 2, list.Count / 2);
		}
		if (list.Count == 0)
		{
			return null;
		}
		return list[Random.Range(0, list.Count)];
	}
}

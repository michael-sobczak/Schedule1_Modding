using System;
using System.Collections.Generic;
using Il2CppScheduleOne.Cartel;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace S1API.Cartel;

public class GoonManager
{
	internal readonly GoonPool S1GoonPool;

	public int AvailableGoonCount => S1GoonPool.UnspawnedGoonCount;

	internal GoonManager(GoonPool goonPool)
	{
		S1GoonPool = goonPool;
	}

	public CartelGoon? SpawnGoon(Vector3 position)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (AvailableGoonCount == 0)
		{
			return null;
		}
		List<CartelGoon> val = S1GoonPool.SpawnMultipleGoons(position, 1, true);
		if (val == null || val.Count == 0)
		{
			return null;
		}
		return new CartelGoon(val[0]);
	}

	public List<CartelGoon> SpawnGoons(Vector3 position, int count)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		List<CartelGoon> list = new List<CartelGoon>();
		if (count <= 0 || AvailableGoonCount == 0)
		{
			return list;
		}
		int num = Math.Min(count, AvailableGoonCount);
		List<CartelGoon> val = S1GoonPool.SpawnMultipleGoons(position, num, true);
		if (val == null)
		{
			return list;
		}
		Enumerator<CartelGoon> enumerator = val.GetEnumerator();
		while (enumerator.MoveNext())
		{
			CartelGoon current = enumerator.Current;
			if ((Object)(object)current != (Object)null)
			{
				list.Add(new CartelGoon(current));
			}
		}
		return list;
	}

	public List<CartelGoon> SpawnGoonsAtPositions(Vector3[] positions)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		List<CartelGoon> list = new List<CartelGoon>();
		if (positions == null || positions.Length == 0)
		{
			return list;
		}
		List<CartelGoon> list2 = SpawnGoons(positions[0], positions.Length);
		for (int i = 0; i < list2.Count && i < positions.Length; i++)
		{
			list2[i].WarpTo(positions[i]);
			list.Add(list2[i]);
		}
		return list;
	}
}

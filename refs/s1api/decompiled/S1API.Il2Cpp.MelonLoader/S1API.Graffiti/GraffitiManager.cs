using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Graffiti;
using S1API.Internal.Utils;
using UnityEngine;

namespace S1API.Graffiti;

public static class GraffitiManager
{
	private static GraffitiManager Instance => NetworkSingleton<GraffitiManager>.Instance;

	public static List<SpraySurface> UntaggedSpraySurfaces => (from surface in GetAllSpraySurfaces()
		where surface.StrokeCount == 0 && !surface.HasDrawingBeenFinalized
		select surface).ToList();

	public static List<SpraySurface> GetAllSpraySurfaces()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		GraffitiManager instance = Instance;
		if ((Object)(object)instance == (Object)null)
		{
			return new List<SpraySurface>();
		}
		object obj = ReflectionUtils.TryGetFieldOrProperty(instance, "SpraySurfaces");
		if (obj is IList list)
		{
			List<SpraySurface> list2 = new List<SpraySurface>();
			foreach (object item in list)
			{
				if (item != null)
				{
					list2.Add(new SpraySurface((SpraySurface)item));
				}
			}
			return list2;
		}
		return new List<SpraySurface>();
	}

	public static List<SpraySurface> GetUntaggedSpraySurfaces()
	{
		return UntaggedSpraySurfaces;
	}

	public static SpraySurface? FindNearestUntaggedSurface(Vector3 position)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		List<SpraySurface> untaggedSpraySurfaces = GetUntaggedSpraySurfaces();
		if (untaggedSpraySurfaces.Count == 0)
		{
			return null;
		}
		SpraySurface result = null;
		float num = float.MaxValue;
		foreach (SpraySurface item in untaggedSpraySurfaces)
		{
			float num2 = Vector3.Distance(position, item.Position);
			if (num2 < num)
			{
				num = num2;
				result = item;
			}
		}
		return result;
	}
}

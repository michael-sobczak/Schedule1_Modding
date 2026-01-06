using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using S1API.Internal.Map;
using ScheduleOne.Map;
using UnityEngine;

namespace S1API.Map;

public static class ParkingLotRegistry
{
	internal static readonly List<ParkingLotWrapper> All = new List<ParkingLotWrapper>();

	public static ParkingLotWrapper[] GetAll()
	{
		return All.OrderBy((ParkingLotWrapper l) => l.GameObjectName).ToArray();
	}

	public static ParkingLotWrapper GetByGUID(string guid)
	{
		if (string.IsNullOrEmpty(guid))
		{
			return null;
		}
		return All.FirstOrDefault((ParkingLotWrapper l) => string.Equals(l?.GUID, guid, StringComparison.OrdinalIgnoreCase));
	}

	public static ParkingLotWrapper GetByName(string gameObjectName)
	{
		if (string.IsNullOrEmpty(gameObjectName))
		{
			return null;
		}
		ParkingLotWrapper parkingLotWrapper = All.FirstOrDefault((ParkingLotWrapper l) => string.Equals(l?.GameObjectName, gameObjectName, StringComparison.OrdinalIgnoreCase));
		if (parkingLotWrapper != null)
		{
			return parkingLotWrapper;
		}
		if (DeferredMapResolver.IsMenuScene())
		{
			ParkingLotWrapper deferredWrapper = new ParkingLotWrapper(typeof(object), gameObjectName);
			DeferredMapResolver.RegisterDeferredLookup(new DeferredLookup(gameObjectName, delegate(object resolved)
			{
				if (resolved is ParkingLotWrapper parkingLotWrapper2 && parkingLotWrapper2 != null && (Object)(object)parkingLotWrapper2._lot != (Object)null)
				{
					deferredWrapper._lot = parkingLotWrapper2._lot;
					deferredWrapper._guid = parkingLotWrapper2._guid;
					deferredWrapper._gameObjectName = parkingLotWrapper2._gameObjectName;
					deferredWrapper._isDeferred = false;
				}
			}));
			return deferredWrapper;
		}
		return null;
	}

	public static ParkingSpotWrapper[] GetFreeSpots(string lotGuid)
	{
		ParkingLotWrapper byGUID = GetByGUID(lotGuid);
		if (byGUID == null)
		{
			return Array.Empty<ParkingSpotWrapper>();
		}
		try
		{
			List<ParkingSpot> freeParkingSpots = byGUID.ResolveGameLot().GetFreeParkingSpots();
			List<ParkingSpotWrapper> list = new List<ParkingSpotWrapper>();
			foreach (ParkingSpot item in freeParkingSpots)
			{
				list.Add(new ParkingSpotWrapper(item));
			}
			return list.ToArray();
		}
		catch
		{
			return Array.Empty<ParkingSpotWrapper>();
		}
	}

	public static ParkingSpotWrapper[] GetFreeSpotsByName(string lotGameObjectName)
	{
		ParkingLotWrapper byName = GetByName(lotGameObjectName);
		if (byName == null)
		{
			return Array.Empty<ParkingSpotWrapper>();
		}
		try
		{
			List<ParkingSpot> freeParkingSpots = byName.ResolveGameLot().GetFreeParkingSpots();
			List<ParkingSpotWrapper> list = new List<ParkingSpotWrapper>();
			foreach (ParkingSpot item in freeParkingSpots)
			{
				list.Add(new ParkingSpotWrapper(item));
			}
			return list.ToArray();
		}
		catch
		{
			return Array.Empty<ParkingSpotWrapper>();
		}
	}

	internal static void Register(object gameParkingLot)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (gameParkingLot == null)
		{
			return;
		}
		try
		{
			ParkingLot val = (ParkingLot)gameParkingLot;
			string guid = val.GUID.ToString();
			if (!All.Any((ParkingLotWrapper l) => string.Equals(l?.GUID, guid, StringComparison.OrdinalIgnoreCase)))
			{
				All.Add(new ParkingLotWrapper(val));
			}
		}
		catch
		{
		}
	}

	internal static void Unregister(object gameParkingLot)
	{
		if (gameParkingLot == null)
		{
			return;
		}
		try
		{
			for (int num = All.Count - 1; num >= 0; num--)
			{
				if (All[num]?._lot == gameParkingLot)
				{
					All.RemoveAt(num);
				}
			}
		}
		catch
		{
		}
	}

	public static ParkingLotWrapper Get<T>() where T : IParkingLotIdentifier
	{
		Type typeFromHandle = typeof(T);
		string text = TryGetNameFromIdentifier(typeFromHandle);
		if (!string.IsNullOrEmpty(text))
		{
			ParkingLotWrapper byName = GetByName(text);
			if (byName != null)
			{
				return byName;
			}
		}
		ParkingLotWrapper byName2 = GetByName(typeFromHandle.Name);
		if (byName2 != null)
		{
			return byName2;
		}
		if (DeferredMapResolver.IsMenuScene())
		{
			string name = ((!string.IsNullOrEmpty(text)) ? text : typeFromHandle.Name);
			ParkingLotWrapper deferredWrapper = new ParkingLotWrapper(typeFromHandle, name);
			DeferredMapResolver.RegisterDeferredLookup(new DeferredLookup(typeFromHandle, delegate(object resolved)
			{
				if (resolved is ParkingLotWrapper parkingLotWrapper && parkingLotWrapper != null && (Object)(object)parkingLotWrapper._lot != (Object)null)
				{
					deferredWrapper._lot = parkingLotWrapper._lot;
					deferredWrapper._guid = parkingLotWrapper._guid;
					deferredWrapper._gameObjectName = parkingLotWrapper._gameObjectName;
					deferredWrapper._isDeferred = false;
				}
			}));
			return deferredWrapper;
		}
		return null;
	}

	internal static void Clear()
	{
		All.Clear();
	}

	private static string TryGetNameFromIdentifier(Type t)
	{
		try
		{
			object obj = t.GetCustomAttributes(inherit: false).FirstOrDefault((object a) => a.GetType().FullName == typeof(ParkingLotNameAttribute).FullName);
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

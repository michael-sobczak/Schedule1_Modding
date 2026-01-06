using System;
using System.Collections.Generic;
using S1API.Internal.Map;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace S1API.Vehicles;

public static class VehicleRegistry
{
	private static readonly Dictionary<object, LandVehicle> _cache = new Dictionary<object, LandVehicle>();

	public static LandVehicle[] GetAll()
	{
		try
		{
			List<LandVehicle> allVehicles = NetworkSingleton<VehicleManager>.Instance.AllVehicles;
			if (allVehicles == null)
			{
				return Array.Empty<LandVehicle>();
			}
			List<LandVehicle> list = new List<LandVehicle>();
			foreach (LandVehicle item in allVehicles)
			{
				if ((Object)(object)item != (Object)null)
				{
					LandVehicle landVehicle = Wrap(item);
					if (landVehicle != null)
					{
						list.Add(landVehicle);
					}
				}
			}
			return list.ToArray();
		}
		catch
		{
			return Array.Empty<LandVehicle>();
		}
	}

	public static LandVehicle GetByGUID(string guid)
	{
		if (string.IsNullOrEmpty(guid))
		{
			return null;
		}
		try
		{
			Guid guid2 = new Guid(guid);
			LandVehicle val = GUIDManager.GetObject<LandVehicle>(guid2);
			if ((Object)(object)val == (Object)null)
			{
				return null;
			}
			return Wrap(val);
		}
		catch
		{
			return null;
		}
	}

	public static LandVehicle GetByName(string gameObjectName)
	{
		if (string.IsNullOrEmpty(gameObjectName))
		{
			return null;
		}
		try
		{
			GameObject val = GameObject.Find(gameObjectName);
			if ((Object)(object)val != (Object)null)
			{
				LandVehicle component = val.GetComponent<LandVehicle>();
				if ((Object)(object)component != (Object)null)
				{
					return Wrap(component);
				}
			}
			List<LandVehicle> allVehicles = NetworkSingleton<VehicleManager>.Instance.AllVehicles;
			if (allVehicles != null)
			{
				for (int i = 0; i < allVehicles.Count; i++)
				{
					LandVehicle val2 = allVehicles[i];
					if ((Object)(object)val2 != (Object)null && ((Object)((Component)val2).gameObject).name == gameObjectName)
					{
						return Wrap(val2);
					}
				}
			}
			if (DeferredMapResolver.IsMenuScene())
			{
				LandVehicle deferredVehicle = new LandVehicle(gameObjectName, isDeferred: true);
				DeferredMapResolver.RegisterDeferredLookup(new DeferredLookup(gameObjectName, delegate(object resolved)
				{
					if (resolved is LandVehicle landVehicle && landVehicle != null && (Object)(object)landVehicle.S1LandVehicle != (Object)null)
					{
						deferredVehicle.S1LandVehicle = landVehicle.S1LandVehicle;
						deferredVehicle._isDeferredByName = false;
					}
				}));
				return deferredVehicle;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public static LandVehicle CreateVehicle(string vehicleCode)
	{
		if (!string.IsNullOrEmpty(vehicleCode))
		{
			try
			{
				return new LandVehicle(vehicleCode);
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	public static void RemoveVehicle(string guidString)
	{
		if (string.IsNullOrEmpty(guidString))
		{
			return;
		}
		VehicleManager instance = NetworkSingleton<VehicleManager>.Instance;
		if ((Object)(object)instance == (Object)null)
		{
			return;
		}
		Guid g = new Guid(guidString);
		int? num = null;
		LandVehicle val = null;
		List<LandVehicle> allVehicles = instance.AllVehicles;
		if (allVehicles != null)
		{
			for (int i = 0; i < allVehicles.Count; i++)
			{
				LandVehicle obj = allVehicles[i];
				if (obj != null && obj.GUID.Equals(g))
				{
					num = i;
					val = allVehicles[i];
					break;
				}
			}
		}
		int? num2 = null;
		List<LandVehicle> playerOwnedVehicles = instance.PlayerOwnedVehicles;
		if (playerOwnedVehicles != null)
		{
			for (int j = 0; j < playerOwnedVehicles.Count; j++)
			{
				LandVehicle obj2 = playerOwnedVehicles[j];
				if (obj2 != null && obj2.GUID.Equals(g))
				{
					num2 = j;
					break;
				}
			}
		}
		if (num.HasValue)
		{
			allVehicles?.RemoveAt(num.Value);
		}
		if (num2.HasValue)
		{
			playerOwnedVehicles?.RemoveAt(num2.Value);
		}
		if ((Object)(object)val != (Object)null && _cache.ContainsKey(val))
		{
			_cache.Remove(val);
		}
	}

	private static LandVehicle Wrap(LandVehicle veh)
	{
		if ((Object)(object)veh == (Object)null)
		{
			return null;
		}
		if (_cache.TryGetValue(veh, out LandVehicle value))
		{
			return value;
		}
		LandVehicle landVehicle = new LandVehicle(veh);
		_cache[veh] = landVehicle;
		return landVehicle;
	}
}

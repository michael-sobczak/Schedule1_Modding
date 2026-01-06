using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using S1API.Internal.Map;
using S1API.Map.DeliveryLocations;
using ScheduleOne.Economy;
using UnityEngine;

namespace S1API.Map;

public sealed class DeliveryLocation
{
	internal static readonly List<DeliveryLocation> All = new List<DeliveryLocation>();

	internal DeliveryLocation S1Location;

	private bool _isDeferred;

	private Type _deferredIdentifierType;

	public string Name
	{
		get
		{
			if (_isDeferred && (Object)(object)S1Location == (Object)null)
			{
				TryResolveDeferred();
			}
			return ((Object)(object)S1Location != (Object)null) ? S1Location.LocationName : string.Empty;
		}
	}

	public string Description => ((Object)(object)S1Location != (Object)null) ? S1Location.LocationDescription : string.Empty;

	public string GUID
	{
		get
		{
			try
			{
				return ((Object)(object)S1Location != (Object)null) ? S1Location.GUID.ToString() : string.Empty;
			}
			catch
			{
				return string.Empty;
			}
		}
	}

	public Transform CustomerStandPoint => ((Object)(object)S1Location != (Object)null) ? S1Location.CustomerStandPoint : null;

	public Transform TeleportPoint => ((Object)(object)S1Location != (Object)null) ? S1Location.TeleportPoint : null;

	internal DeliveryLocation(DeliveryLocation s1)
	{
		S1Location = s1;
		_isDeferred = false;
	}

	internal DeliveryLocation(Type identifierType, string name)
	{
		S1Location = null;
		_isDeferred = true;
		_deferredIdentifierType = identifierType;
	}

	private void TryResolveDeferred()
	{
		if (!_isDeferred || (Object)(object)S1Location != (Object)null || !(_deferredIdentifierType != null))
		{
			return;
		}
		string text = TryGetNameFromIdentifier(_deferredIdentifierType);
		if (!string.IsNullOrEmpty(text))
		{
			DeliveryLocation byName = GetByName(text);
			if (byName != null && !byName._isDeferred && (Object)(object)byName.S1Location != (Object)null)
			{
				S1Location = byName.S1Location;
				_isDeferred = false;
				return;
			}
		}
		DeliveryLocation byName2 = GetByName(_deferredIdentifierType.Name);
		if (byName2 != null && !byName2._isDeferred && (Object)(object)byName2.S1Location != (Object)null)
		{
			S1Location = byName2.S1Location;
			_isDeferred = false;
		}
	}

	public static DeliveryLocation[] GetAll()
	{
		return All.OrderBy((DeliveryLocation l) => l.Name).ToArray();
	}

	public static DeliveryLocation GetByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		DeliveryLocation deliveryLocation = All.FirstOrDefault((DeliveryLocation l) => string.Equals(l?.Name, name, StringComparison.OrdinalIgnoreCase));
		if (deliveryLocation != null)
		{
			return deliveryLocation;
		}
		if (DeferredMapResolver.IsMenuScene())
		{
			DeliveryLocation deferredWrapper = new DeliveryLocation(typeof(object), name);
			DeferredMapResolver.RegisterDeferredLookup(new DeferredLookup(name, delegate(object resolved)
			{
				if (resolved is DeliveryLocation deliveryLocation2 && deliveryLocation2 != null && (Object)(object)deliveryLocation2.S1Location != (Object)null)
				{
					deferredWrapper.S1Location = deliveryLocation2.S1Location;
					deferredWrapper._isDeferred = false;
				}
			}));
			return deferredWrapper;
		}
		return null;
	}

	public static DeliveryLocation GetByGuid(string guid)
	{
		if (string.IsNullOrEmpty(guid))
		{
			return null;
		}
		return All.FirstOrDefault((DeliveryLocation l) => string.Equals(l?.GUID, guid, StringComparison.OrdinalIgnoreCase));
	}

	internal static void Register(object gameDeliveryLocation)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		if (gameDeliveryLocation == null)
		{
			return;
		}
		try
		{
			Type type = gameDeliveryLocation.GetType();
			string guid = (type.GetProperty("GUID", BindingFlags.Instance | BindingFlags.Public)?.GetValue(gameDeliveryLocation))?.ToString() ?? string.Empty;
			if (!string.IsNullOrEmpty(guid) && !All.Any((DeliveryLocation l) => string.Equals(l?.GUID, guid, StringComparison.OrdinalIgnoreCase)))
			{
				All.Add(new DeliveryLocation((DeliveryLocation)gameDeliveryLocation));
			}
		}
		catch
		{
		}
	}

	internal static void Unregister(object gameDeliveryLocation)
	{
		if (gameDeliveryLocation == null)
		{
			return;
		}
		try
		{
			for (int num = All.Count - 1; num >= 0; num--)
			{
				if (All[num]?.S1Location == gameDeliveryLocation)
				{
					All.RemoveAt(num);
				}
			}
		}
		catch
		{
		}
	}

	internal static void Clear()
	{
		All.Clear();
	}

	public static DeliveryLocation Get<T>() where T : IDeliveryLocationIdentifier
	{
		Type typeFromHandle = typeof(T);
		string text = TryGetNameFromIdentifier(typeFromHandle);
		if (!string.IsNullOrEmpty(text))
		{
			DeliveryLocation byName = GetByName(text);
			if (byName != null)
			{
				return byName;
			}
		}
		DeliveryLocation byName2 = GetByName(typeFromHandle.Name);
		if (byName2 != null)
		{
			return byName2;
		}
		if (DeferredMapResolver.IsMenuScene())
		{
			string name = ((!string.IsNullOrEmpty(text)) ? text : typeFromHandle.Name);
			DeliveryLocation deferredWrapper = new DeliveryLocation(typeFromHandle, name);
			DeferredMapResolver.RegisterDeferredLookup(new DeferredLookup(typeFromHandle, delegate(object resolved)
			{
				if (resolved is DeliveryLocation deliveryLocation && deliveryLocation != null && (Object)(object)deliveryLocation.S1Location != (Object)null)
				{
					deferredWrapper.S1Location = deliveryLocation.S1Location;
					deferredWrapper._isDeferred = false;
				}
			}));
			return deferredWrapper;
		}
		return null;
	}

	private static string TryGetNameFromIdentifier(Type t)
	{
		try
		{
			object obj = t.GetCustomAttributes(inherit: false).FirstOrDefault((object a) => a.GetType().FullName == typeof(DeliveryLocationNameAttribute).FullName);
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

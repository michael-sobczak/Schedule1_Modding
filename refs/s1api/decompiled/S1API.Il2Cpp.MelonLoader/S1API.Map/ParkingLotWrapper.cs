using System;
using System.Linq;
using System.Reflection;
using Il2CppScheduleOne.Map;
using UnityEngine;

namespace S1API.Map;

public sealed class ParkingLotWrapper
{
	internal string _guid;

	internal string _gameObjectName;

	internal ParkingLot _lot;

	internal bool _isDeferred;

	private Type _deferredIdentifierType;

	public string GUID => _guid;

	public string GameObjectName => _gameObjectName;

	public Vector3? EntryPointPosition
	{
		get
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			ParkingLot lot = _lot;
			return ((Object)(object)((lot != null) ? lot.EntryPoint : null) != (Object)null) ? new Vector3?(_lot.EntryPoint.position) : ((Vector3?)null);
		}
	}

	public int ParkingSpotsCount => (!((Object)(object)_lot == (Object)null)) ? _lot.ParkingSpots.Count : 0;

	internal ParkingLotWrapper(ParkingLot lot)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_lot = lot;
		_guid = ((object)lot.GUID/*cast due to .constrained prefix*/).ToString();
		_gameObjectName = ((Object)((Component)lot).gameObject).name;
		_isDeferred = false;
	}

	internal ParkingLotWrapper(Type identifierType, string name)
	{
		_guid = string.Empty;
		_gameObjectName = name;
		_lot = null;
		_isDeferred = true;
		_deferredIdentifierType = identifierType;
	}

	public ParkingSpotWrapper GetSpot(int index)
	{
		return new ParkingSpotWrapper(_lot.ParkingSpots[index]);
	}

	internal ParkingLot ResolveGameLot()
	{
		if (_isDeferred && (Object)(object)_lot == (Object)null)
		{
			if (_deferredIdentifierType != null)
			{
				ParkingLotWrapper parkingLotWrapper = TryResolveDeferred(_deferredIdentifierType);
				if (parkingLotWrapper != null)
				{
					_lot = parkingLotWrapper._lot;
					_isDeferred = false;
					return _lot;
				}
			}
			else if (!string.IsNullOrEmpty(_gameObjectName))
			{
				ParkingLotWrapper byName = ParkingLotRegistry.GetByName(_gameObjectName);
				if (byName != null && !byName._isDeferred)
				{
					_lot = byName._lot;
					_isDeferred = false;
					return _lot;
				}
			}
		}
		return _lot;
	}

	private static ParkingLotWrapper TryResolveDeferred(Type identifierType)
	{
		try
		{
			string text = TryGetNameFromIdentifier(identifierType);
			if (!string.IsNullOrEmpty(text))
			{
				return ParkingLotRegistry.GetByName(text);
			}
			return ParkingLotRegistry.GetByName(identifierType.Name);
		}
		catch
		{
			return null;
		}
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

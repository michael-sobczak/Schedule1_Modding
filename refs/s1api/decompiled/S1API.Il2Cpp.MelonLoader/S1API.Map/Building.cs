using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Map;
using S1API.Entities.Schedule;
using S1API.Internal.Map;
using S1API.Map.Buildings;
using UnityEngine;

namespace S1API.Map;

public sealed class Building
{
	public static readonly List<Building> All = new List<Building>();

	private string _name;

	internal object _gameBuilding;

	private bool _isDeferred;

	private Type _deferredIdentifierType;

	public string Name => _name;

	internal Type DeferredIdentifierType => _isDeferred ? _deferredIdentifierType : null;

	internal bool IsDeferred => _isDeferred;

	internal Building(string name, object gameBuilding)
	{
		_name = name;
		_gameBuilding = gameBuilding;
		_isDeferred = false;
	}

	internal Building(Type identifierType, string name)
	{
		_name = name;
		_gameBuilding = null;
		_isDeferred = true;
		_deferredIdentifierType = identifierType;
	}

	internal object ResolveGameBuilding()
	{
		if (_gameBuilding != null)
		{
			return _gameBuilding;
		}
		if (_isDeferred)
		{
			if (_deferredIdentifierType != null)
			{
				Building building = TryResolveDeferred(_deferredIdentifierType);
				if (building != null)
				{
					_gameBuilding = building._gameBuilding;
					_name = building._name;
					_isDeferred = false;
					return _gameBuilding;
				}
			}
			else if (!string.IsNullOrEmpty(_name))
			{
				Building byName = GetByName(_name);
				if (byName != null && !byName._isDeferred)
				{
					_gameBuilding = byName._gameBuilding;
					_isDeferred = false;
					return _gameBuilding;
				}
			}
		}
		try
		{
			Il2CppArrayBase<NPCEnterableBuilding> val = Object.FindObjectsOfType<NPCEnterableBuilding>(true);
			for (int i = 0; i < val.Length; i++)
			{
				NPCEnterableBuilding val2 = val[i];
				if (!((Object)(object)val2 == (Object)null))
				{
					Type type = ((object)val2).GetType();
					string text = type.GetField("BuildingName", BindingFlags.Instance | BindingFlags.Public)?.GetValue(val2) as string;
					if (!string.IsNullOrEmpty(text) && string.Equals(text, _name, StringComparison.OrdinalIgnoreCase))
					{
						_gameBuilding = val2;
						break;
					}
				}
			}
		}
		catch
		{
		}
		return _gameBuilding;
	}

	private static Building TryResolveDeferred(Type identifierType)
	{
		try
		{
			string text = TryGetNameFromIdentifier(identifierType);
			if (!string.IsNullOrEmpty(text))
			{
				return GetByName(text);
			}
			return GetByName(identifierType.Name);
		}
		catch
		{
			return null;
		}
	}

	internal static void Register(object gameBuilding)
	{
		if (gameBuilding == null)
		{
			return;
		}
		try
		{
			Type type = gameBuilding.GetType();
			FieldInfo field = type.GetField("BuildingName", BindingFlags.Instance | BindingFlags.Public);
			PropertyInfo property = type.GetProperty("BuildingName", BindingFlags.Instance | BindingFlags.Public);
			string name = field?.GetValue(gameBuilding) as string;
			if (string.IsNullOrEmpty(name))
			{
				name = property?.GetValue(gameBuilding) as string;
			}
			if (!string.IsNullOrEmpty(name))
			{
				Building building = All.FirstOrDefault((Building b) => b != null && string.Equals(b._name, name, StringComparison.OrdinalIgnoreCase));
				if (building != null)
				{
					building._gameBuilding = gameBuilding;
					building._isDeferred = false;
					TryResolvePendingScheduleActions(name, gameBuilding);
				}
				else
				{
					Building item = new Building(name, gameBuilding);
					All.Add(item);
					TryResolvePendingScheduleActions(name, gameBuilding);
				}
			}
		}
		catch
		{
		}
	}

	internal static void Unregister(object gameBuilding)
	{
		if (gameBuilding == null)
		{
			return;
		}
		try
		{
			for (int num = All.Count - 1; num >= 0; num--)
			{
				if (All[num]?._gameBuilding == gameBuilding)
				{
					All.RemoveAt(num);
				}
			}
		}
		catch
		{
		}
	}

	public static Building[] GetAll()
	{
		return All.OrderBy((Building b) => b.Name).ToArray();
	}

	public static Building GetByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		Building building = GetAll().FirstOrDefault((Building b) => string.Equals(b.Name, name, StringComparison.OrdinalIgnoreCase));
		if (building != null)
		{
			return building;
		}
		if (DeferredMapResolver.IsMenuScene())
		{
			Building deferredWrapper = new Building(typeof(object), name);
			DeferredMapResolver.RegisterDeferredLookup(new DeferredLookup(name, delegate(object resolved)
			{
				if (resolved is Building building2 && building2 != null && building2._gameBuilding != null)
				{
					deferredWrapper._gameBuilding = building2._gameBuilding;
					deferredWrapper._name = building2._name;
					deferredWrapper._isDeferred = false;
				}
			}));
			return deferredWrapper;
		}
		return null;
	}

	public static Building Get<T>() where T : IBuildingIdentifier
	{
		Type typeFromHandle = typeof(T);
		string text = TryGetNameFromIdentifier(typeFromHandle);
		if (!string.IsNullOrEmpty(text))
		{
			Building byName = GetByName(text);
			if (byName != null)
			{
				return byName;
			}
		}
		Building byName2 = GetByName(typeFromHandle.Name);
		if (byName2 != null)
		{
			return byName2;
		}
		if (DeferredMapResolver.IsMenuScene())
		{
			string name = ((!string.IsNullOrEmpty(text)) ? text : typeFromHandle.Name);
			Building deferredWrapper = new Building(typeFromHandle, name);
			DeferredMapResolver.RegisterDeferredLookup(new DeferredLookup(typeFromHandle, delegate(object resolved)
			{
				if (resolved is Building building && building != null && building._gameBuilding != null)
				{
					deferredWrapper._gameBuilding = building._gameBuilding;
					deferredWrapper._name = building._name;
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
			object obj = t.GetCustomAttributes(inherit: false).FirstOrDefault((object a) => a.GetType().FullName == typeof(BuildingNameAttribute).FullName);
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

	private static void TryResolvePendingScheduleActions(string buildingName, object gameBuilding)
	{
		try
		{
			StayInBuildingSpec.TryResolvePendingActions();
		}
		catch
		{
		}
	}
}

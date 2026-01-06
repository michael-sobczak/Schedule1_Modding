using System;
using System.Reflection;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using S1API.Logging;
using S1API.Map;
using S1API.Storages;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.Modification;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace S1API.Vehicles;

public class LandVehicle
{
	internal LandVehicle S1LandVehicle = null;

	internal bool _isDeferredByName = false;

	internal StorageInstance _storage;

	private static readonly Log _logger = new Log("S1API.LandVehicle");

	private static readonly FieldInfo? VehiclePriceField = typeof(LandVehicle).GetField("vehiclePrice", BindingFlags.NonPublic);

	private NetworkConnection? _conn;

	private string _guid = string.Empty;

	public float VehiclePrice
	{
		get
		{
			return S1LandVehicle.VehiclePrice;
		}
		set
		{
			VehiclePriceField?.SetValue(S1LandVehicle, value);
		}
	}

	public float TopSpeed
	{
		get
		{
			return S1LandVehicle.TopSpeed;
		}
		set
		{
			S1LandVehicle.TopSpeed = value;
		}
	}

	public bool IsPlayerOwned
	{
		get
		{
			return S1LandVehicle.IsPlayerOwned;
		}
		set
		{
			SetIsPlayerOwned(value);
		}
	}

	public bool IsOccupied
	{
		get
		{
			return S1LandVehicle.IsOccupied;
		}
		set
		{
			S1LandVehicle.IsOccupied = value;
		}
	}

	public VehicleColor Color
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			return (VehicleColor)S1LandVehicle.OwnedColor;
		}
		set
		{
			SetColor(value);
		}
	}

	public string GUID => _guid;

	public StorageInstance Storage => _storage;

	public event Action OnVehicleStart
	{
		add
		{
			LandVehicle s1LandVehicle = S1LandVehicle;
			s1LandVehicle.onVehicleStart = (Action)Delegate.Combine(s1LandVehicle.onVehicleStart, value);
		}
		remove
		{
			LandVehicle s1LandVehicle = S1LandVehicle;
			s1LandVehicle.onVehicleStart = (Action)Delegate.Remove(s1LandVehicle.onVehicleStart, value);
		}
	}

	public event Action OnVehicleStop
	{
		add
		{
			LandVehicle s1LandVehicle = S1LandVehicle;
			s1LandVehicle.onVehicleStop = (Action)Delegate.Combine(s1LandVehicle.onVehicleStop, value);
		}
		remove
		{
			LandVehicle s1LandVehicle = S1LandVehicle;
			s1LandVehicle.onVehicleStop = (Action)Delegate.Remove(s1LandVehicle.onVehicleStop, value);
		}
	}

	public event Action OnHandbrakeApplied
	{
		add
		{
			LandVehicle s1LandVehicle = S1LandVehicle;
			s1LandVehicle.onHandbrakeApplied = (Action)Delegate.Combine(s1LandVehicle.onHandbrakeApplied, value);
		}
		remove
		{
			LandVehicle s1LandVehicle = S1LandVehicle;
			s1LandVehicle.onHandbrakeApplied = (Action)Delegate.Remove(s1LandVehicle.onHandbrakeApplied, value);
		}
	}

	public event Action<Collision> OnCollision
	{
		add
		{
			LandVehicle s1LandVehicle = S1LandVehicle;
			s1LandVehicle.onCollision = (Action<Collision>)Delegate.Combine(s1LandVehicle.onCollision, value);
		}
		remove
		{
			LandVehicle s1LandVehicle = S1LandVehicle;
			s1LandVehicle.onCollision = (Action<Collision>)Delegate.Remove(s1LandVehicle.onCollision, value);
		}
	}

	public LandVehicle(string vehicleCode)
	{
		LandVehicle vehiclePrefab = NetworkSingleton<VehicleManager>.Instance.GetVehiclePrefab(vehicleCode);
		if ((Object)(object)vehiclePrefab == (Object)null)
		{
			_logger.Error("SpawnVehicle: '" + vehicleCode + "' is not a valid vehicle code!");
			return;
		}
		LandVehicle component = Object.Instantiate<GameObject>(((Component)vehiclePrefab).gameObject).GetComponent<LandVehicle>();
		component.SetGUID(GUIDManager.GenerateUniqueGUID());
		NetworkSingleton<VehicleManager>.Instance.AllVehicles.Add(component);
		S1LandVehicle = component;
		SetConnection();
		UpdateGuidFromGame();
		_storage = new StorageInstance(component.Storage);
	}

	public void Spawn(Vector3 position, Quaternion rotation)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!InstanceFinder.IsServer)
		{
			_logger.Warning("Spawn can only be called on the server!");
			return;
		}
		if ((Object)(object)S1LandVehicle == (Object)null)
		{
			throw new Exception("Unable to spawn vehicle, S1LandVehicle is null!");
		}
		((Component)S1LandVehicle).transform.position = position;
		((Component)S1LandVehicle).transform.rotation = rotation;
		((NetworkBehaviour)NetworkSingleton<VehicleManager>.Instance).Spawn(((Component)S1LandVehicle).gameObject, (NetworkConnection)null, default(Scene));
	}

	public void AlignTo(Transform target, ParkingAlignment type, bool network = false)
	{
		if ((Object)(object)S1LandVehicle == (Object)null)
		{
			throw new Exception("Unable to align to position, S1LandVehicle is null!");
		}
		S1LandVehicle.AlignTo(target, (EParkingAlignment)type, network);
	}

	public void ExitPark(bool moveToExitPoint = true)
	{
		S1LandVehicle.ExitPark(moveToExitPoint);
	}

	public void SetVisible(bool vis)
	{
		S1LandVehicle.SetVisible(vis);
	}

	public void DestroyVehichle()
	{
		S1LandVehicle.DestroyVehicle();
	}

	public void ApplyColor(VehicleColor col)
	{
		S1LandVehicle.ApplyColor((EVehicleColor)col);
	}

	public void Park(ParkingData parkData, bool network)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ParkData val = new ParkData
		{
			lotGUID = Guid.Parse(parkData.LotId),
			spotIndex = parkData.Index,
			alignment = (EParkingAlignment)parkData.Alignment
		};
		S1LandVehicle.Park(_conn, val, network);
	}

	internal LandVehicle(LandVehicle landVehicle)
	{
		S1LandVehicle = landVehicle;
		SetConnection();
		UpdateGuidFromGame();
		_storage = new StorageInstance(landVehicle.Storage);
		_isDeferredByName = false;
	}

	internal LandVehicle(string vehicleName, bool isDeferred)
	{
		_isDeferredByName = isDeferred;
	}

	private void SetConnection()
	{
		NetworkManager networkManager = InstanceFinder.NetworkManager;
		if (networkManager.IsClientOnly)
		{
			NetworkConnection connection = InstanceFinder.ClientManager.Connection;
			if (connection != (NetworkConnection)null && connection.IsValid)
			{
				_conn = connection;
			}
		}
		else if (networkManager.IsServerOnly || (networkManager.IsServer && !networkManager.IsClient))
		{
			NetworkConnection owner = ((NetworkBehaviour)S1LandVehicle).Owner;
			if (owner != (NetworkConnection)null && owner.IsValid)
			{
				_conn = owner;
			}
		}
	}

	private void SetIsPlayerOwned(bool isPlayerOwned)
	{
		S1LandVehicle.SetIsPlayerOwned(_conn, isPlayerOwned);
		if (isPlayerOwned)
		{
			NetworkSingleton<VehicleManager>.Instance.PlayerOwnedVehicles.Add(S1LandVehicle);
		}
		else
		{
			NetworkSingleton<VehicleManager>.Instance.PlayerOwnedVehicles.Remove(S1LandVehicle);
		}
	}

	private void SetColor(VehicleColor color)
	{
		MethodInfo method = typeof(LandVehicle).GetMethod("SetOwnedColor", BindingFlags.Instance | BindingFlags.NonPublic);
		if (method == null)
		{
			_logger.Error("SetOwnedColor method not found!");
			return;
		}
		method.Invoke(S1LandVehicle, new object[2]
		{
			_conn,
			(object)(EVehicleColor)color
		});
	}

	private void UpdateGuidFromGame()
	{
		try
		{
			PropertyInfo property = typeof(LandVehicle).GetProperty("GUID", BindingFlags.Instance | BindingFlags.Public);
			if (!(property == null))
			{
				_guid = ((Guid)(property.GetValue(S1LandVehicle) ?? ((object)Guid.Empty))/*cast due to .constrained prefix*/).ToString();
			}
		}
		catch
		{
		}
	}
}

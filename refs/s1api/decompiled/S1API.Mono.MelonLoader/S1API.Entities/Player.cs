using System;
using System.Collections.Generic;
using System.Linq;
using S1API.Entities.Interfaces;
using S1API.Internal.Abstraction;
using S1API.Law;
using S1API.Map;
using S1API.Property;
using S1API.Vehicles;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using UnityEngine;

namespace S1API.Entities;

public class Player : IEntity, IHealth
{
	private const float InvincibleHealth = 1E+09f;

	private const float MortalHealth = 100f;

	public static readonly List<Player> All = new List<Player>();

	internal Player S1Player;

	private static readonly HashSet<Player> InvinciblePlayers = new HashSet<Player>();

	public static Player Local => All.FirstOrDefault((Player player) => player.IsLocal);

	public bool IsLocal => S1Player.IsLocalPlayer;

	public string Name => S1Player.PlayerName;

	GameObject IEntity.gameObject => ((Component)S1Player).gameObject;

	public Vector3 Position
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			return ((IEntity)this).gameObject.transform.position;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			((IEntity)this).gameObject.transform.position = value;
		}
	}

	public Transform Transform => ((IEntity)this).gameObject.transform;

	public float Scale
	{
		get
		{
			return S1Player.Scale;
		}
		set
		{
			S1Player.SetScale(value);
		}
	}

	public PlayerCrimeData CrimeData => new PlayerCrimeData(S1Player.CrimeData);

	public float CurrentHealth => S1Player.Health.CurrentHealth;

	public float MaxHealth
	{
		get
		{
			return 100f;
		}
		set
		{
			S1Player.Health.SetHealth(value);
		}
	}

	public bool IsDead => !S1Player.Health.IsAlive;

	public bool IsInvincible
	{
		get
		{
			return InvinciblePlayers.Contains(S1Player);
		}
		set
		{
			if (value)
			{
				InvinciblePlayers.Add(S1Player);
			}
			else
			{
				InvinciblePlayers.Remove(S1Player);
			}
		}
	}

	public LandVehicle? LastDrivenVehicle
	{
		get
		{
			if ((Object)(object)S1Player.LastDrivenVehicle == (Object)null)
			{
				return null;
			}
			LandVehicle[] all = VehicleRegistry.GetAll();
			foreach (LandVehicle landVehicle in all)
			{
				if ((Object)(object)landVehicle.S1LandVehicle == (Object)(object)S1Player.LastDrivenVehicle)
				{
					return landVehicle;
				}
			}
			return null;
		}
	}

	public bool IsInVehicle => S1Player.IsInVehicle;

	public float TimeSinceVehicleExit => S1Player.TimeSinceVehicleExit;

	public bool Crouched => S1Player.Crouched;

	public bool IsReadyToSleep => S1Player.IsReadyToSleep;

	public bool IsSkating => S1Player.IsSkating;

	public bool IsSleeping => S1Player.IsSleeping;

	public bool IsRagdolled => S1Player.IsRagdolled;

	public bool IsArrested => S1Player.IsArrested;

	public bool IsTased => S1Player.IsTased;

	public bool IsUnconscious => S1Player.IsUnconscious;

	public PropertyWrapper? CurrentProperty
	{
		get
		{
			if ((Object)(object)S1Player.CurrentProperty == (Object)null)
			{
				return null;
			}
			foreach (PropertyWrapper allProperty in PropertyManager.GetAllProperties())
			{
				if ((Object)(object)allProperty.InnerProperty == (Object)(object)S1Player.CurrentProperty)
				{
					return allProperty;
				}
			}
			return null;
		}
	}

	public PropertyWrapper? LastVisitedProperty
	{
		get
		{
			Property lastVisitedProperty = S1Player.LastVisitedProperty;
			if ((Object)(object)lastVisitedProperty == (Object)null)
			{
				return null;
			}
			foreach (PropertyWrapper allProperty in PropertyManager.GetAllProperties())
			{
				if ((Object)(object)allProperty.InnerProperty == (Object)(object)lastVisitedProperty)
				{
					return allProperty;
				}
			}
			return null;
		}
	}

	public Region CurrentRegion => (Region)S1Player.CurrentRegion;

	public object CurrentAvatarSettings => S1Player.CurrentAvatarSettings;

	public static event Action<Player>? PlayerSpawned;

	public static event Action<Player>? LocalPlayerSpawned;

	public static event Action<Player>? PlayerDespawned;

	public event Action OnDeath
	{
		add
		{
			EventHelper.AddListener(value, S1Player.Health.onDie);
		}
		remove
		{
			EventHelper.RemoveListener(value, S1Player.Health.onDie);
		}
	}

	internal Player(Player player)
	{
		S1Player = player;
		All.Add(this);
	}

	public void Revive()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		S1Player.Health.Revive(Position, Quaternion.identity);
	}

	public void Damage(int amount)
	{
		if (amount > 0)
		{
			S1Player.Health.TakeDamage((float)amount, true, true);
		}
	}

	public void Heal(int amount)
	{
		if (amount > 0)
		{
			S1Player.Health.SetHealth(CurrentHealth + (float)amount);
		}
	}

	public void Kill()
	{
		S1Player.Health.SetHealth(0f);
	}

	internal static bool IsPlayerInvincible(Player player)
	{
		return InvinciblePlayers.Contains(player);
	}

	internal static void RaisePlayerSpawned(Player player)
	{
		Player.PlayerSpawned?.Invoke(player);
	}

	internal static void RaiseLocalPlayerSpawned(Player player)
	{
		Player.LocalPlayerSpawned?.Invoke(player);
	}

	internal static void RaisePlayerDespawned(Player player)
	{
		Player.PlayerDespawned?.Invoke(player);
	}
}

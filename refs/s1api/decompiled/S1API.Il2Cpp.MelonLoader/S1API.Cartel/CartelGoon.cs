using Il2CppFishNet.Object;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Cartel;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using S1API.Entities.Interfaces;
using UnityEngine;

namespace S1API.Cartel;

public class CartelGoon
{
	internal readonly CartelGoon S1Goon;

	public bool IsConscious => ((NPC)S1Goon).IsConscious;

	public bool IsSpawned => ((NetworkBehaviour)S1Goon).IsSpawned;

	public Vector3 Position => ((Component)S1Goon).transform.position;

	public GameObject GameObject => ((Component)S1Goon).gameObject;

	internal CartelGoon(CartelGoon goon)
	{
		S1Goon = goon;
	}

	public void WarpTo(Vector3 position)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		NPCMovement movement = ((NPC)S1Goon).Movement;
		if (movement != null)
		{
			movement.Warp(position);
		}
	}

	public void AttackPlayer()
	{
		Player local = Player.Local;
		if (!((Object)(object)local == (Object)null))
		{
			ICombatTargetable component = ((Component)local).GetComponent<ICombatTargetable>();
			if (component != null)
			{
				S1Goon.AttackEntity(component, true);
			}
		}
	}

	public void Attack(IEntity target)
	{
		if (!((Object)(object)target?.gameObject == (Object)null))
		{
			ICombatTargetable component = target.gameObject.GetComponent<ICombatTargetable>();
			if (component != null)
			{
				S1Goon.AttackEntity(component, true);
			}
		}
	}

	public void Despawn()
	{
		S1Goon.Despawn();
	}

	public void SetDefaultWeapon(string? weaponAssetPath)
	{
		NPCBehaviour behaviour = ((NPC)S1Goon).Behaviour;
		CombatBehaviour val = ((behaviour != null) ? behaviour.CombatBehaviour : null);
		if ((Object)(object)val == (Object)null)
		{
			return;
		}
		if (string.IsNullOrEmpty(weaponAssetPath))
		{
			val.DefaultWeapon = null;
			return;
		}
		Object obj = Resources.Load(weaponAssetPath);
		GameObject val2 = (GameObject)(object)((obj is GameObject) ? obj : null);
		if ((Object)(object)val2 != (Object)null)
		{
			AvatarWeapon component = Object.Instantiate<GameObject>(val2).GetComponent<AvatarWeapon>();
			val.DefaultWeapon = component;
		}
	}
}

using System.Reflection;
using FishNet.Object;
using S1API.Entities.Interfaces;
using S1API.Items;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Combat;
using UnityEngine;

namespace S1API.Entities.Behaviour;

public class CombatBehaviour
{
	internal readonly NPC NPC;

	public float GiveUpRange
	{
		get
		{
			return NPC.S1NPC.Behaviour.CombatBehaviour.GiveUpRange;
		}
		set
		{
			NPC.S1NPC.Behaviour.CombatBehaviour.GiveUpRange = value;
		}
	}

	public float GiveUpTime
	{
		get
		{
			return NPC.S1NPC.Behaviour.CombatBehaviour.DefaultSearchTime;
		}
		set
		{
			NPC.S1NPC.Behaviour.CombatBehaviour.DefaultSearchTime = value;
		}
	}

	public string DefaultWeaponAssetPath
	{
		get
		{
			return ((AvatarEquippable)(NPC.S1NPC.Behaviour.CombatBehaviour.DefaultWeapon?)).AssetPath ?? string.Empty;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				NPC.S1NPC.Behaviour.CombatBehaviour.DefaultWeapon = null;
				return;
			}
			Object obj = Resources.Load(value);
			GameObject val = (GameObject)(object)((obj is GameObject) ? obj : null);
			if ((Object)(object)val == (Object)null)
			{
				Debug.LogError((object)("Could not find weapon at path: " + value));
				return;
			}
			AvatarEquippable component = Object.Instantiate<GameObject>(val).GetComponent<AvatarEquippable>();
			if ((Object)(object)component == (Object)null)
			{
				Debug.LogError((object)("Could not get AvatarEquippable from weapon at path: " + value));
			}
			else
			{
				NPC.S1NPC.Behaviour.CombatBehaviour.DefaultWeapon = (AvatarWeapon)(object)((component is AvatarWeapon) ? component : null);
			}
		}
	}

	internal CombatBehaviour(NPC npc)
	{
		NPC = npc;
	}

	public void SetAndAttackTarget(IEntity target)
	{
		NetworkObject component = target.gameObject.GetComponent<NetworkObject>();
		NPC.S1NPC.Behaviour.CombatBehaviour.SetTargetAndEnable_Server(component);
	}

	public void SetCurrentWeapon(string weaponPath)
	{
		typeof(CombatBehaviour).GetMethod("SetWeapon", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(NPC.S1NPC.Behaviour.CombatBehaviour, new object[1] { weaponPath });
	}

	public void SetCurrentWeapon(Equippable equippable)
	{
		if (equippable == null)
		{
			Debug.LogError((object)"Cannot set weapon: Equippable is null");
			return;
		}
		string assetPathFromEquippable = GetAssetPathFromEquippable(equippable);
		if (string.IsNullOrEmpty(assetPathFromEquippable))
		{
			Debug.LogError((object)"Cannot set weapon: Could not extract asset path from Equippable");
		}
		else
		{
			SetCurrentWeapon(assetPathFromEquippable);
		}
	}

	public void SetDefaultWeapon(Equippable equippable)
	{
		if (equippable == null)
		{
			Debug.LogError((object)"Cannot set default weapon: Equippable is null");
			return;
		}
		string assetPathFromEquippable = GetAssetPathFromEquippable(equippable);
		if (string.IsNullOrEmpty(assetPathFromEquippable))
		{
			Debug.LogError((object)"Cannot set default weapon: Could not extract asset path from Equippable");
		}
		else
		{
			DefaultWeaponAssetPath = assetPathFromEquippable;
		}
	}

	public void SetCurrentWeapon(EquippableBuilder equippableBuilder)
	{
		if (equippableBuilder == null)
		{
			Debug.LogError((object)"Cannot set weapon: EquippableBuilder is null");
			return;
		}
		Equippable currentWeapon = equippableBuilder.Build();
		SetCurrentWeapon(currentWeapon);
	}

	public void SetDefaultWeapon(EquippableBuilder equippableBuilder)
	{
		if (equippableBuilder == null)
		{
			Debug.LogError((object)"Cannot set default weapon: EquippableBuilder is null");
			return;
		}
		Equippable defaultWeapon = equippableBuilder.Build();
		SetDefaultWeapon(defaultWeapon);
	}

	private string GetAssetPathFromEquippable(Equippable equippable)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		if ((Object)(object)equippable?.S1Equippable == (Object)null)
		{
			return null;
		}
		GameObject gameObject = ((Component)equippable.S1Equippable).gameObject;
		if ((Object)(object)gameObject == (Object)null)
		{
			return null;
		}
		AvatarEquippable val = gameObject.GetComponent<AvatarEquippable>();
		if ((Object)(object)val == (Object)null)
		{
			val = gameObject.GetComponentInChildren<AvatarEquippable>();
		}
		if ((Object)(object)val == (Object)null)
		{
			foreach (Transform item in gameObject.transform)
			{
				Transform val2 = item;
				val = ((Component)val2).GetComponent<AvatarEquippable>();
				if ((Object)(object)val != (Object)null)
				{
					break;
				}
			}
		}
		return val?.AssetPath;
	}
}

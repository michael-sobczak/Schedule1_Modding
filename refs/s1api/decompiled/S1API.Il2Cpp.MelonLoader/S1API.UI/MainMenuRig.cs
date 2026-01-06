using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.UI.MainMenu;
using S1API.Avatar;
using UnityEngine;

namespace S1API.UI;

public sealed class MainMenuRig
{
	internal readonly MainMenuRig S1MainMenuRig;

	public global::S1API.Avatar.Avatar? Avatar
	{
		get
		{
			if ((Object)(object)S1MainMenuRig == (Object)null || (Object)(object)S1MainMenuRig.Avatar == (Object)null)
			{
				return null;
			}
			return new global::S1API.Avatar.Avatar(S1MainMenuRig.Avatar);
		}
	}

	internal MainMenuRig(MainMenuRig mainMenuRig)
	{
		S1MainMenuRig = mainMenuRig;
	}

	public static MainMenuRig[] FindInScene(bool includeInactive = false)
	{
		Il2CppArrayBase<MainMenuRig> val = Object.FindObjectsOfType<MainMenuRig>(includeInactive);
		if (val == null || val.Length == 0)
		{
			return Array.Empty<MainMenuRig>();
		}
		return (from r in (IEnumerable<MainMenuRig>)val
			where (Object)(object)r != (Object)null
			select new MainMenuRig(r)).ToArray();
	}
}

using System;
using System.Linq;
using S1API.Avatar;
using ScheduleOne.UI.MainMenu;
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
		MainMenuRig[] array = Object.FindObjectsOfType<MainMenuRig>(includeInactive);
		if (array == null || array.Length == 0)
		{
			return Array.Empty<MainMenuRig>();
		}
		return (from r in array
			where (Object)(object)r != (Object)null
			select new MainMenuRig(r)).ToArray();
	}
}

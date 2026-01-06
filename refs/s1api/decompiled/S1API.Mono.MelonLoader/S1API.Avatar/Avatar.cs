using System;
using System.Linq;
using ScheduleOne.AvatarFramework;
using UnityEngine;

namespace S1API.Avatar;

public sealed class Avatar
{
	internal readonly Avatar S1Avatar;

	public GameObject GameObject
	{
		get
		{
			Avatar s1Avatar = S1Avatar;
			return (s1Avatar != null) ? ((Component)s1Avatar).gameObject : null;
		}
	}

	public bool IsActive => (Object)(object)S1Avatar != (Object)null && (Object)(object)((Component)S1Avatar).gameObject != (Object)null && ((Component)S1Avatar).gameObject.activeSelf;

	internal Avatar(Avatar avatar)
	{
		S1Avatar = avatar;
	}

	public void LoadAvatarSettings(AvatarSettings settings)
	{
		if (!((Object)(object)S1Avatar == (Object)null) && !((Object)(object)settings?.S1AvatarSettings == (Object)null))
		{
			S1Avatar.LoadAvatarSettings(settings.S1AvatarSettings);
		}
	}

	public static Avatar[] FindInScene(bool includeInactive = false)
	{
		Avatar[] array = Object.FindObjectsOfType<Avatar>(includeInactive);
		if (array == null || array.Length == 0)
		{
			return Array.Empty<Avatar>();
		}
		return (from a in array
			where (Object)(object)a != (Object)null
			select new Avatar(a)).ToArray();
	}
}

using System.Collections.Generic;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace S1API.Avatar;

public sealed class BasicAvatarSettings
{
	internal readonly BasicAvatarSettings S1BasicAvatarSettings;

	public int Gender
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.Gender : 0;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.Gender = value;
			}
		}
	}

	public float Weight
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.Weight : 0.5f;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.Weight = value;
			}
		}
	}

	public Color SkinColor
	{
		get
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (Color)((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.SkinColor : new Color(0.6f, 0.5f, 0.4f));
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.SkinColor = value;
			}
		}
	}

	public string HairStyle
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return ((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.HairStyle : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.HairStyle = value ?? string.Empty;
			}
		}
	}

	public Color HairColor
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.HairColor : Color.black;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.HairColor = value;
			}
		}
	}

	public string Mouth
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return ((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.Mouth : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.Mouth = value ?? string.Empty;
			}
		}
	}

	public string FacialHair
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return ((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.FacialHair : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.FacialHair = value ?? string.Empty;
			}
		}
	}

	public string FacialDetails
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return ((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.FacialDetails : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.FacialDetails = value ?? string.Empty;
			}
		}
	}

	public float FacialDetailsIntensity
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.FacialDetailsIntensity : 0f;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.FacialDetailsIntensity = value;
			}
		}
	}

	public Color EyeballColor
	{
		get
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (Color)((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.EyeballColor : new Color(0.2f, 0.4f, 0.6f));
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.EyeballColor = value;
			}
		}
	}

	public float UpperEyeLidRestingPosition
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.UpperEyeLidRestingPosition : 0.5f;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.UpperEyeLidRestingPosition = value;
			}
		}
	}

	public float LowerEyeLidRestingPosition
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.LowerEyeLidRestingPosition : 0.5f;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.LowerEyeLidRestingPosition = value;
			}
		}
	}

	public float PupilDilation
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.PupilDilation : 1f;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.PupilDilation = value;
			}
		}
	}

	public float EyebrowScale
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.EyebrowScale : 1f;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.EyebrowScale = value;
			}
		}
	}

	public float EyebrowThickness
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.EyebrowThickness : 1f;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.EyebrowThickness = value;
			}
		}
	}

	public float EyebrowRestingHeight
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.EyebrowRestingHeight : 0f;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.EyebrowRestingHeight = value;
			}
		}
	}

	public float EyebrowRestingAngle
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.EyebrowRestingAngle : 0f;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.EyebrowRestingAngle = value;
			}
		}
	}

	public string Top
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return ((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.Top : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.Top = value ?? string.Empty;
			}
		}
	}

	public Color TopColor
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.TopColor : Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.TopColor = value;
			}
		}
	}

	public string Bottom
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return ((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.Bottom : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.Bottom = value ?? string.Empty;
			}
		}
	}

	public Color BottomColor
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.BottomColor : Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.BottomColor = value;
			}
		}
	}

	public string Shoes
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return ((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.Shoes : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.Shoes = value ?? string.Empty;
			}
		}
	}

	public Color ShoesColor
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.ShoesColor : Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.ShoesColor = value;
			}
		}
	}

	public string Headwear
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return ((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.Headwear : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.Headwear = value ?? string.Empty;
			}
		}
	}

	public Color HeadwearColor
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.HeadwearColor : Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.HeadwearColor = value;
			}
		}
	}

	public string Eyewear
	{
		get
		{
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return ((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.Eyewear : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.Eyewear = value ?? string.Empty;
			}
		}
	}

	public Color EyewearColor
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
			return (s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.EyewearColor : Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1BasicAvatarSettings != (Object)null)
			{
				S1BasicAvatarSettings.EyewearColor = value;
			}
		}
	}

	internal BasicAvatarSettings(BasicAvatarSettings settings)
	{
		S1BasicAvatarSettings = settings;
	}

	public static BasicAvatarSettings Create()
	{
		BasicAvatarSettings val = ScriptableObject.CreateInstance<BasicAvatarSettings>();
		((Object)val).hideFlags = (HideFlags)32;
		return new BasicAvatarSettings(val);
	}

	public List<string> GetTattoos()
	{
		List<string> list = new List<string>();
		BasicAvatarSettings s1BasicAvatarSettings = S1BasicAvatarSettings;
		if (((s1BasicAvatarSettings != null) ? s1BasicAvatarSettings.Tattoos : null) == null)
		{
			return list;
		}
		for (int i = 0; i < S1BasicAvatarSettings.Tattoos.Count; i++)
		{
			list.Add(S1BasicAvatarSettings.Tattoos[i] ?? string.Empty);
		}
		return list;
	}

	public void SetTattoos(List<string> tattoos)
	{
		if ((Object)(object)S1BasicAvatarSettings == (Object)null)
		{
			return;
		}
		List<string> val = new List<string>();
		if (tattoos != null)
		{
			foreach (string tattoo in tattoos)
			{
				if (!string.IsNullOrWhiteSpace(tattoo))
				{
					val.Add(tattoo);
				}
			}
		}
		S1BasicAvatarSettings.Tattoos = val;
	}

	public void AddTattoo(string tattooPath)
	{
		if (!((Object)(object)S1BasicAvatarSettings == (Object)null) && !string.IsNullOrWhiteSpace(tattooPath))
		{
			if (S1BasicAvatarSettings.Tattoos == null)
			{
				S1BasicAvatarSettings.Tattoos = new List<string>();
			}
			S1BasicAvatarSettings.Tattoos.Add(tattooPath);
		}
	}

	public AvatarSettings ToAvatarSettings()
	{
		if ((Object)(object)S1BasicAvatarSettings == (Object)null)
		{
			return AvatarSettings.Create();
		}
		AvatarSettings avatarSettings = S1BasicAvatarSettings.GetAvatarSettings();
		return new AvatarSettings(avatarSettings);
	}

	public void SetValue<T>(string fieldName, T value)
	{
		if (!((Object)(object)S1BasicAvatarSettings == (Object)null) && !string.IsNullOrWhiteSpace(fieldName))
		{
			S1BasicAvatarSettings.SetValue<T>(fieldName, value);
		}
	}

	public T GetValue<T>(string fieldName)
	{
		if ((Object)(object)S1BasicAvatarSettings == (Object)null || string.IsNullOrWhiteSpace(fieldName))
		{
			return default(T);
		}
		return S1BasicAvatarSettings.GetValue<T>(fieldName);
	}
}

using System.Collections.Generic;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Customization;
using UnityEngine;

namespace S1API.Avatar;

public sealed class BasicAvatarSettings
{
	internal readonly BasicAvatarSettings S1BasicAvatarSettings;

	public int Gender
	{
		get
		{
			return S1BasicAvatarSettings?.Gender ?? 0;
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
			return S1BasicAvatarSettings?.Weight ?? 0.5f;
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
			return (Color)(((_003F?)S1BasicAvatarSettings?.SkinColor) ?? new Color(0.6f, 0.5f, 0.4f));
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
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
			return S1BasicAvatarSettings?.HairStyle ?? string.Empty;
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
			return S1BasicAvatarSettings?.HairColor ?? Color.black;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
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
			return S1BasicAvatarSettings?.Mouth ?? string.Empty;
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
			return S1BasicAvatarSettings?.FacialHair ?? string.Empty;
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
			return S1BasicAvatarSettings?.FacialDetails ?? string.Empty;
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
			return S1BasicAvatarSettings?.FacialDetailsIntensity ?? 0f;
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
			return (Color)(((_003F?)S1BasicAvatarSettings?.EyeballColor) ?? new Color(0.2f, 0.4f, 0.6f));
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
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
			return S1BasicAvatarSettings?.UpperEyeLidRestingPosition ?? 0.5f;
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
			return S1BasicAvatarSettings?.LowerEyeLidRestingPosition ?? 0.5f;
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
			return S1BasicAvatarSettings?.PupilDilation ?? 1f;
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
			return S1BasicAvatarSettings?.EyebrowScale ?? 1f;
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
			return S1BasicAvatarSettings?.EyebrowThickness ?? 1f;
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
			return S1BasicAvatarSettings?.EyebrowRestingHeight ?? 0f;
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
			return S1BasicAvatarSettings?.EyebrowRestingAngle ?? 0f;
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
			return S1BasicAvatarSettings?.Top ?? string.Empty;
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
			return S1BasicAvatarSettings?.TopColor ?? Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
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
			return S1BasicAvatarSettings?.Bottom ?? string.Empty;
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
			return S1BasicAvatarSettings?.BottomColor ?? Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
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
			return S1BasicAvatarSettings?.Shoes ?? string.Empty;
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
			return S1BasicAvatarSettings?.ShoesColor ?? Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
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
			return S1BasicAvatarSettings?.Headwear ?? string.Empty;
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
			return S1BasicAvatarSettings?.HeadwearColor ?? Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
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
			return S1BasicAvatarSettings?.Eyewear ?? string.Empty;
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
			return S1BasicAvatarSettings?.EyewearColor ?? Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
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
		if (S1BasicAvatarSettings?.Tattoos == null)
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
		List<string> list = new List<string>();
		if (tattoos != null)
		{
			foreach (string tattoo in tattoos)
			{
				if (!string.IsNullOrWhiteSpace(tattoo))
				{
					list.Add(tattoo);
				}
			}
		}
		S1BasicAvatarSettings.Tattoos = list;
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

using System.Collections.Generic;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace S1API.Avatar;

public sealed class AvatarSettings
{
	public sealed class EyeLidConfiguration
	{
		public float TopLidOpen { get; set; }

		public float BottomLidOpen { get; set; }
	}

	public sealed class LayerSetting
	{
		public string LayerPath { get; set; } = string.Empty;

		public Color LayerTint { get; set; }
	}

	public sealed class AccessorySetting
	{
		public string Path { get; set; } = string.Empty;

		public Color Color { get; set; }
	}

	internal readonly AvatarSettings S1AvatarSettings;

	public float Gender
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.Gender : 0.5f;
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.Gender = value;
			}
		}
	}

	public float Height
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.Height : 1f;
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.Height = value;
			}
		}
	}

	public float Weight
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.Weight : 0.5f;
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.Weight = value;
			}
		}
	}

	public Color32 SkinColor
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return Color32.op_Implicit((s1AvatarSettings != null) ? s1AvatarSettings.SkinColor : Color32.op_Implicit(new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue)));
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.SkinColor = Color32.op_Implicit(value);
			}
		}
	}

	public string HairPath
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return ((s1AvatarSettings != null) ? s1AvatarSettings.HairPath : null) ?? string.Empty;
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.HairPath = value ?? string.Empty;
			}
		}
	}

	public Color HairColor
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.HairColor : Color.black;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.HairColor = value;
			}
		}
	}

	public Color32 LeftEyeLidColor
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return Color32.op_Implicit((s1AvatarSettings != null) ? s1AvatarSettings.LeftEyeLidColor : Color32.op_Implicit(SkinColor));
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.LeftEyeLidColor = Color32.op_Implicit(value);
			}
		}
	}

	public Color32 RightEyeLidColor
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return Color32.op_Implicit((s1AvatarSettings != null) ? s1AvatarSettings.RightEyeLidColor : Color32.op_Implicit(SkinColor));
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.RightEyeLidColor = Color32.op_Implicit(value);
			}
		}
	}

	public Color EyeBallTint
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.EyeBallTint : Color.white;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.EyeBallTint = value;
			}
		}
	}

	public float PupilDilation
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.PupilDilation : 0.5f;
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.PupilDilation = value;
			}
		}
	}

	public string EyeballMaterialIdentifier
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return ((s1AvatarSettings != null) ? s1AvatarSettings.EyeballMaterialIdentifier : null) ?? "Default";
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.EyeballMaterialIdentifier = value ?? "Default";
			}
		}
	}

	public float EyebrowScale
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.EyebrowScale : 1f;
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.EyebrowScale = value;
			}
		}
	}

	public float EyebrowThickness
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.EyebrowThickness : 1f;
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.EyebrowThickness = value;
			}
		}
	}

	public float EyebrowRestingHeight
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.EyebrowRestingHeight : 0f;
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.EyebrowRestingHeight = value;
			}
		}
	}

	public float EyebrowRestingAngle
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return (s1AvatarSettings != null) ? s1AvatarSettings.EyebrowRestingAngle : 0f;
		}
		set
		{
			if ((Object)(object)S1AvatarSettings != (Object)null)
			{
				S1AvatarSettings.EyebrowRestingAngle = value;
			}
		}
	}

	public EyeLidConfiguration LeftEyeRestingState
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			if (s1AvatarSettings != null)
			{
				_ = s1AvatarSettings.LeftEyeRestingState;
				if (0 == 0)
				{
					return new EyeLidConfiguration
					{
						TopLidOpen = S1AvatarSettings.LeftEyeRestingState.topLidOpen,
						BottomLidOpen = S1AvatarSettings.LeftEyeRestingState.bottomLidOpen
					};
				}
			}
			return new EyeLidConfiguration
			{
				TopLidOpen = 0.5f,
				BottomLidOpen = 0.5f
			};
		}
		set
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1AvatarSettings != (Object)null && value != null)
			{
				S1AvatarSettings.LeftEyeRestingState = new EyeLidConfiguration
				{
					topLidOpen = value.TopLidOpen,
					bottomLidOpen = value.BottomLidOpen
				};
			}
		}
	}

	public EyeLidConfiguration RightEyeRestingState
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			if (s1AvatarSettings != null)
			{
				_ = s1AvatarSettings.RightEyeRestingState;
				if (0 == 0)
				{
					return new EyeLidConfiguration
					{
						TopLidOpen = S1AvatarSettings.RightEyeRestingState.topLidOpen,
						BottomLidOpen = S1AvatarSettings.RightEyeRestingState.bottomLidOpen
					};
				}
			}
			return new EyeLidConfiguration
			{
				TopLidOpen = 0.5f,
				BottomLidOpen = 0.5f
			};
		}
		set
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)S1AvatarSettings != (Object)null && value != null)
			{
				S1AvatarSettings.RightEyeRestingState = new EyeLidConfiguration
				{
					topLidOpen = value.TopLidOpen,
					bottomLidOpen = value.BottomLidOpen
				};
			}
		}
	}

	public int FaceLayerCount
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return ((s1AvatarSettings == null) ? ((int?)null) : s1AvatarSettings.FaceLayerSettings?.Count).GetValueOrDefault();
		}
	}

	public int BodyLayerCount
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return ((s1AvatarSettings == null) ? ((int?)null) : s1AvatarSettings.BodyLayerSettings?.Count).GetValueOrDefault();
		}
	}

	public int AccessoryCount
	{
		get
		{
			AvatarSettings s1AvatarSettings = S1AvatarSettings;
			return ((s1AvatarSettings == null) ? ((int?)null) : s1AvatarSettings.AccessorySettings?.Count).GetValueOrDefault();
		}
	}

	internal AvatarSettings(AvatarSettings settings)
	{
		S1AvatarSettings = settings;
	}

	public static AvatarSettings Create()
	{
		AvatarSettings val = ScriptableObject.CreateInstance<AvatarSettings>();
		((Object)val).hideFlags = (HideFlags)32;
		return new AvatarSettings(val);
	}

	public void AddFaceLayer(string layerPath, Color layerTint)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		if (!((Object)(object)S1AvatarSettings == (Object)null) && !string.IsNullOrWhiteSpace(layerPath))
		{
			if (S1AvatarSettings.FaceLayerSettings == null)
			{
				S1AvatarSettings.FaceLayerSettings = new List<LayerSetting>();
			}
			S1AvatarSettings.FaceLayerSettings.Add(new LayerSetting
			{
				layerPath = layerPath,
				layerTint = layerTint
			});
		}
	}

	public void AddBodyLayer(string layerPath, Color layerTint)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		if (!((Object)(object)S1AvatarSettings == (Object)null) && !string.IsNullOrWhiteSpace(layerPath))
		{
			if (S1AvatarSettings.BodyLayerSettings == null)
			{
				S1AvatarSettings.BodyLayerSettings = new List<LayerSetting>();
			}
			S1AvatarSettings.BodyLayerSettings.Add(new LayerSetting
			{
				layerPath = layerPath,
				layerTint = layerTint
			});
		}
	}

	public void AddAccessory(string path, Color color)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		if (!((Object)(object)S1AvatarSettings == (Object)null) && !string.IsNullOrWhiteSpace(path))
		{
			if (S1AvatarSettings.AccessorySettings == null)
			{
				S1AvatarSettings.AccessorySettings = new List<AccessorySetting>();
			}
			S1AvatarSettings.AccessorySettings.Add(new AccessorySetting
			{
				path = path,
				color = color
			});
		}
	}

	public void SetFaceLayers(List<LayerSetting> layers)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		if ((Object)(object)S1AvatarSettings == (Object)null)
		{
			return;
		}
		List<LayerSetting> val = new List<LayerSetting>();
		if (layers != null)
		{
			foreach (LayerSetting layer in layers)
			{
				if (!string.IsNullOrWhiteSpace(layer.LayerPath))
				{
					val.Add(new LayerSetting
					{
						layerPath = layer.LayerPath,
						layerTint = layer.LayerTint
					});
				}
			}
		}
		S1AvatarSettings.FaceLayerSettings = val;
	}

	public void SetBodyLayers(List<LayerSetting> layers)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		if ((Object)(object)S1AvatarSettings == (Object)null)
		{
			return;
		}
		List<LayerSetting> val = new List<LayerSetting>();
		if (layers != null)
		{
			foreach (LayerSetting layer in layers)
			{
				if (!string.IsNullOrWhiteSpace(layer.LayerPath))
				{
					val.Add(new LayerSetting
					{
						layerPath = layer.LayerPath,
						layerTint = layer.LayerTint
					});
				}
			}
		}
		S1AvatarSettings.BodyLayerSettings = val;
	}

	public void SetAccessories(List<AccessorySetting> accessories)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		if ((Object)(object)S1AvatarSettings == (Object)null)
		{
			return;
		}
		List<AccessorySetting> val = new List<AccessorySetting>();
		if (accessories != null)
		{
			foreach (AccessorySetting accessory in accessories)
			{
				if (!string.IsNullOrWhiteSpace(accessory.Path))
				{
					val.Add(new AccessorySetting
					{
						path = accessory.Path,
						color = accessory.Color
					});
				}
			}
		}
		S1AvatarSettings.AccessorySettings = val;
	}

	public List<LayerSetting> GetFaceLayers()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		List<LayerSetting> list = new List<LayerSetting>();
		AvatarSettings s1AvatarSettings = S1AvatarSettings;
		if (((s1AvatarSettings != null) ? s1AvatarSettings.FaceLayerSettings : null) == null)
		{
			return list;
		}
		for (int i = 0; i < S1AvatarSettings.FaceLayerSettings.Count; i++)
		{
			LayerSetting val = S1AvatarSettings.FaceLayerSettings[i];
			list.Add(new LayerSetting
			{
				LayerPath = (val.layerPath ?? string.Empty),
				LayerTint = val.layerTint
			});
		}
		return list;
	}

	public List<LayerSetting> GetBodyLayers()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		List<LayerSetting> list = new List<LayerSetting>();
		AvatarSettings s1AvatarSettings = S1AvatarSettings;
		if (((s1AvatarSettings != null) ? s1AvatarSettings.BodyLayerSettings : null) == null)
		{
			return list;
		}
		for (int i = 0; i < S1AvatarSettings.BodyLayerSettings.Count; i++)
		{
			LayerSetting val = S1AvatarSettings.BodyLayerSettings[i];
			list.Add(new LayerSetting
			{
				LayerPath = (val.layerPath ?? string.Empty),
				LayerTint = val.layerTint
			});
		}
		return list;
	}

	public List<AccessorySetting> GetAccessories()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		List<AccessorySetting> list = new List<AccessorySetting>();
		AvatarSettings s1AvatarSettings = S1AvatarSettings;
		if (((s1AvatarSettings != null) ? s1AvatarSettings.AccessorySettings : null) == null)
		{
			return list;
		}
		for (int i = 0; i < S1AvatarSettings.AccessorySettings.Count; i++)
		{
			AccessorySetting val = S1AvatarSettings.AccessorySettings[i];
			list.Add(new AccessorySetting
			{
				Path = (val.path ?? string.Empty),
				Color = val.color
			});
		}
		return list;
	}
}

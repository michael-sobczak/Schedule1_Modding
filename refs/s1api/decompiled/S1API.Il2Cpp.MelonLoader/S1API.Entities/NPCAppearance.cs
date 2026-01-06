using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using MelonLoader;
using S1API.Entities.Appearances.AccessoryFields;
using S1API.Entities.Appearances.Base;
using S1API.Entities.Appearances.BodyLayerFields;
using S1API.Entities.Appearances.CustomizationFields;
using S1API.Entities.Appearances.FaceLayerFields;
using S1API.Internal.Utils;
using S1API.Logging;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace S1API.Entities;

public class NPCAppearance
{
	private static readonly Log _logger = new Log("NPCAppearance");

	internal readonly NPC NPC;

	private Avatar _runtimeAvatar;

	private AvatarSettings _customAvatarSettings;

	private static readonly Dictionary<Type, Action<NPCAppearance, object>> _setters = new Dictionary<Type, Action<NPCAppearance, object>>
	{
		[typeof(HairStyle)] = delegate(NPCAppearance self, object value)
		{
			self._customAvatarSettings.HairPath = (value as string) ?? string.Empty;
		},
		[typeof(HairColor)] = delegate(NPCAppearance self, object value)
		{
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings customAvatarSettings = self._customAvatarSettings;
			if (1 == 0)
			{
			}
			Color hairColor = ((value is uint hexColor) ? hexColor.ToColor() : ((!(value is Color val)) ? self._customAvatarSettings.HairColor : val));
			if (1 == 0)
			{
			}
			customAvatarSettings.HairColor = hairColor;
		},
		[typeof(SkinColor)] = delegate(NPCAppearance self, object value)
		{
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings customAvatarSettings = self._customAvatarSettings;
			if (1 == 0)
			{
			}
			Color skinColor = ((value is uint hexColor) ? hexColor.ToColor() : ((!(value is Color val)) ? self._customAvatarSettings.SkinColor : val));
			if (1 == 0)
			{
			}
			customAvatarSettings.SkinColor = skinColor;
		},
		[typeof(EyeBallTint)] = delegate(NPCAppearance self, object value)
		{
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			AvatarSettings customAvatarSettings = self._customAvatarSettings;
			if (1 == 0)
			{
			}
			Color eyeBallTint = ((value is uint hexColor) ? hexColor.ToColor() : ((!(value is Color val)) ? self._customAvatarSettings.EyeBallTint : val));
			if (1 == 0)
			{
			}
			customAvatarSettings.EyeBallTint = eyeBallTint;
		},
		[typeof(Gender)] = delegate(NPCAppearance self, object value)
		{
			self._customAvatarSettings.Gender = Convert.ToSingle(value);
		},
		[typeof(Height)] = delegate(NPCAppearance self, object value)
		{
			self._customAvatarSettings.Height = Convert.ToSingle(value);
		},
		[typeof(Weight)] = delegate(NPCAppearance self, object value)
		{
			self._customAvatarSettings.Weight = Convert.ToSingle(value);
		},
		[typeof(PupilDilation)] = delegate(NPCAppearance self, object value)
		{
			self._customAvatarSettings.PupilDilation = Convert.ToSingle(value);
		},
		[typeof(EyebrowRestingAngle)] = delegate(NPCAppearance self, object value)
		{
			self._customAvatarSettings.EyebrowRestingAngle = Convert.ToSingle(value);
		},
		[typeof(EyebrowRestingHeight)] = delegate(NPCAppearance self, object value)
		{
			self._customAvatarSettings.EyebrowRestingHeight = Convert.ToSingle(value);
		},
		[typeof(EyebrowScale)] = delegate(NPCAppearance self, object value)
		{
			self._customAvatarSettings.EyebrowScale = Convert.ToSingle(value);
		},
		[typeof(EyebrowThickness)] = delegate(NPCAppearance self, object value)
		{
			self._customAvatarSettings.EyebrowThickness = Convert.ToSingle(value);
		},
		[typeof(EyeLidRestingStateLeft)] = delegate(NPCAppearance self, object value)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			object[] valueTupleItems = value.GetValueTupleItems();
			self._customAvatarSettings.LeftEyeRestingState = new EyeLidConfiguration
			{
				topLidOpen = Convert.ToSingle(valueTupleItems[0]),
				bottomLidOpen = Convert.ToSingle(valueTupleItems[1])
			};
		},
		[typeof(EyeLidRestingStateRight)] = delegate(NPCAppearance self, object value)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			object[] valueTupleItems = value.GetValueTupleItems();
			self._customAvatarSettings.RightEyeRestingState = new EyeLidConfiguration
			{
				topLidOpen = Convert.ToSingle(valueTupleItems[0]),
				bottomLidOpen = Convert.ToSingle(valueTupleItems[1])
			};
		}
	};

	private const int MaxFaceLayers = 6;

	private const int MaxBodyLayers = 6;

	private const int MaxAccessoryLayers = 9;

	private static readonly object _mugshotQueueLock = new object();

	private static readonly Queue<NPCAppearance> _mugshotQueue = new Queue<NPCAppearance>();

	private static bool _isProcessingMugshots = false;

	internal static bool MugshotsProcessingComplete
	{
		get
		{
			lock (_mugshotQueueLock)
			{
				return !_isProcessingMugshots && _mugshotQueue.Count == 0;
			}
		}
	}

	internal NPCAppearance(NPC npc, Avatar runtimeAvatar)
	{
		NPC = npc;
		_runtimeAvatar = runtimeAvatar;
		AvatarSettings val = null;
		if ((Object)(object)_runtimeAvatar != (Object)null)
		{
			if ((Object)(object)_runtimeAvatar.CurrentSettings != (Object)null)
			{
				val = _runtimeAvatar.CurrentSettings;
			}
			else if ((Object)(object)_runtimeAvatar.InitialAvatarSettings != (Object)null)
			{
				val = _runtimeAvatar.InitialAvatarSettings;
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			_customAvatarSettings = Object.Instantiate<AvatarSettings>(val);
		}
		else
		{
			_customAvatarSettings = ScriptableObject.CreateInstance<AvatarSettings>();
			ApplyDefaultSettings(_customAvatarSettings);
		}
		AvatarSettings val2 = Resources.Load<AvatarSettings>("charactersettings/" + NPC.S1NPC.FirstName);
		if ((Object)(object)val2 != (Object)null)
		{
			_customAvatarSettings = Object.Instantiate<AvatarSettings>(val2);
		}
		ApplyToAvatar(_runtimeAvatar);
	}

	internal void GenerateMugshot()
	{
		MugshotGenerator instance = Singleton<MugshotGenerator>.Instance;
		if ((Object)(object)instance == (Object)null || (Object)(object)instance.MugshotRig == (Object)null)
		{
			return;
		}
		lock (_mugshotQueueLock)
		{
			_mugshotQueue.Enqueue(this);
			if (!_isProcessingMugshots)
			{
				_isProcessingMugshots = true;
				MelonCoroutines.Start(ProcessMugshotQueue());
			}
		}
	}

	private static IEnumerator ProcessMugshotQueue()
	{
		while (true)
		{
			NPCAppearance next = null;
			lock (_mugshotQueueLock)
			{
				if (_mugshotQueue.Count <= 0)
				{
					_isProcessingMugshots = false;
					break;
				}
				next = _mugshotQueue.Dequeue();
			}
			if (next == null)
			{
				yield return null;
				continue;
			}
			MugshotGenerator generator = Singleton<MugshotGenerator>.Instance;
			Avatar mugshotRig = (((Object)(object)generator != (Object)null) ? generator.MugshotRig : null);
			IconGenerator iconGenerator = (((Object)(object)generator != (Object)null) ? generator.Generator : null);
			if ((Object)(object)mugshotRig == (Object)null)
			{
				lock (_mugshotQueueLock)
				{
					_mugshotQueue.Enqueue(next);
				}
				yield return null;
				continue;
			}
			Avatar previousAvatar = next.NPC.S1NPC.Avatar;
			next.NPC.S1NPC.Avatar = mugshotRig;
			Transform mugshotParent = ((Component)mugshotRig).transform.parent;
			if ((Object)(object)mugshotParent != (Object)null)
			{
				((Component)mugshotParent).gameObject.SetActive(true);
			}
			((Component)mugshotRig).gameObject.SetActive(true);
			bool previousAllowCulling = (Object)(object)mugshotRig.Animation != (Object)null && mugshotRig.Animation.AllowCulling;
			if ((Object)(object)mugshotRig.Animation != (Object)null)
			{
				mugshotRig.Animation.AllowCulling = false;
			}
			mugshotRig.SetVisible(true);
			mugshotRig.Impostor.DisableImpostor();
			AvatarSettings mugshotSettings = Object.Instantiate<AvatarSettings>(next._customAvatarSettings);
			mugshotSettings.Height = 1f;
			next.NPC.S1NPC.Avatar.LoadAvatarSettings(mugshotSettings);
			SetLayerRecursively(((Component)mugshotRig).gameObject, LayerMask.NameToLayer("IconGeneration"));
			Il2CppArrayBase<SkinnedMeshRenderer> skinnedMeshRenderers = ((Component)mugshotRig).GetComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
			{
				smr.updateWhenOffscreen = true;
			}
			AmbientMode previousAmbientMode = RenderSettings.ambientMode;
			Color previousAmbientLight = RenderSettings.ambientLight;
			float previousAmbientIntensity = RenderSettings.ambientIntensity;
			bool? previousModifyLighting = (((Object)(object)iconGenerator != (Object)null) ? new bool?(iconGenerator.ModifyLighting) : ((bool?)null));
			if ((Object)(object)iconGenerator != (Object)null)
			{
				iconGenerator.ModifyLighting = true;
			}
			bool completed = false;
			next.NPC.S1NPC.Avatar.GetMugshot(Action<Texture2D>.op_Implicit((Action<Texture2D>)delegate(Texture2D generatedMugshot)
			{
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Unknown result type (might be due to invalid IL or missing references)
				try
				{
					generatedMugshot.Apply();
					float num = 0.92f;
					int num2 = Mathf.RoundToInt((float)((Texture)generatedMugshot).width * num);
					int num3 = Mathf.RoundToInt((float)((Texture)generatedMugshot).height * num);
					int num4 = (((Texture)generatedMugshot).width - num2) / 2;
					int num5 = Mathf.RoundToInt((float)((Texture)generatedMugshot).height * 0.04f);
					num4 = Mathf.Clamp(num4, 0, ((Texture)generatedMugshot).width - num2);
					num5 = Mathf.Clamp(num5, 0, ((Texture)generatedMugshot).height - num3);
					Rect val = default(Rect);
					((Rect)(ref val))._002Ector(0f, 0f, (float)((Texture)generatedMugshot).width, (float)((Texture)generatedMugshot).height);
					Sprite val2 = Sprite.Create(generatedMugshot, val, Vector2.zero);
					next.NPC.Icon = val2;
					next.NPC.RefreshMessagingIcons();
					UpdatePoiIcons(next.NPC.S1NPC, val2);
				}
				catch (Exception ex)
				{
					_logger.Error("Failed to finalize mugshot: " + ex.Message);
				}
				finally
				{
					completed = true;
				}
			}));
			while (!completed)
			{
				yield return null;
			}
			if ((Object)(object)iconGenerator != (Object)null && previousModifyLighting.HasValue)
			{
				iconGenerator.ModifyLighting = previousModifyLighting.Value;
			}
			RenderSettings.ambientMode = previousAmbientMode;
			RenderSettings.ambientLight = previousAmbientLight;
			RenderSettings.ambientIntensity = previousAmbientIntensity;
			next.NPC.S1NPC.Avatar = previousAvatar ?? next._runtimeAvatar;
			next.ApplyToAvatar(next._runtimeAvatar);
			if ((Object)(object)generator.DefaultSettings != (Object)null)
			{
				mugshotRig.LoadAvatarSettings(generator.DefaultSettings);
			}
			((Component)mugshotRig).gameObject.SetActive(false);
			if ((Object)(object)mugshotRig.Animation != (Object)null)
			{
				mugshotRig.Animation.AllowCulling = previousAllowCulling;
			}
			yield return (object)new WaitForSeconds(0.1f);
		}
	}

	internal void ApplyToAvatar(Avatar avatar)
	{
		if (!((Object)(object)avatar == (Object)null))
		{
			avatar.LoadAvatarSettings(_customAvatarSettings);
		}
	}

	public NPCAppearance Set<T>(object appearanceValue) where T : BaseAppearance
	{
		if (_setters.TryGetValue(typeof(T), out Action<NPCAppearance, object> value))
		{
			try
			{
				value(this, appearanceValue);
			}
			catch (Exception ex)
			{
				_logger.Error("Failed to set " + typeof(T).Name + ": " + ex.Message);
			}
		}
		else
		{
			_logger.Error("No setter registered for appearance type " + typeof(T).Name);
		}
		return this;
	}

	public NPCAppearance WithFaceLayer<T>(string path, uint hexColor) where T : BaseFaceAppearance
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return WithFaceLayer<T>(path, hexColor.ToColor());
	}

	public NPCAppearance WithFaceLayer<T>(string path, Color color) where T : BaseFaceAppearance
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		if (_customAvatarSettings.FaceLayerSettings.Count > 6)
		{
			return this;
		}
		_customAvatarSettings.FaceLayerSettings.Add(new LayerSetting
		{
			layerPath = path,
			layerTint = color
		});
		return this;
	}

	public NPCAppearance WithBodyLayer<T>(string path, uint hexColor) where T : BaseBodyAppearance
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return WithBodyLayer<T>(path, hexColor.ToColor());
	}

	public NPCAppearance WithBodyLayer<T>(string path, Color color) where T : BaseBodyAppearance
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		if (_customAvatarSettings.BodyLayerSettings.Count > 6)
		{
			return this;
		}
		_customAvatarSettings.BodyLayerSettings.Add(new LayerSetting
		{
			layerPath = path,
			layerTint = color
		});
		return this;
	}

	public NPCAppearance WithAccessoryLayer<T>(string path, uint hexColor) where T : BaseAccessoryAppearance
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return WithAccessoryLayer<T>(path, hexColor.ToColor());
	}

	public NPCAppearance WithAccessoryLayer<T>(string path, Color color) where T : BaseAccessoryAppearance
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		if (_customAvatarSettings.AccessorySettings.Count > 9)
		{
			return this;
		}
		_customAvatarSettings.AccessorySettings.Add(new AccessorySetting
		{
			path = path,
			color = color
		});
		return this;
	}

	public NPCAppearance Build()
	{
		GenerateMugshot();
		return this;
	}

	public void GenerateRandomAppearance()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		Set<EyeBallTint>(RandomColor());
		Set<EyebrowRestingAngle>(RandomRange(0f, 1f));
		Set<EyebrowRestingHeight>(RandomRange(0f, 1f));
		Set<EyebrowScale>(RandomRange(0f, 1f));
		Set<EyebrowThickness>(RandomRange(0f, 1f));
		float item = RandomRange(0f, 1f);
		float item2 = RandomRange(0f, 1f);
		Set<EyeLidRestingStateLeft>((item, item2));
		Set<EyeLidRestingStateRight>((item, item2));
		Color val = RandomColor();
		Set<HairColor>(val);
		List<string> constPaths = BaseAppearance.GetConstPaths<HairStyle>();
		if (constPaths.Count > 0)
		{
			Set<HairStyle>(RandomFromList(constPaths));
		}
		Set<Gender>(RandomRange(0f, 1f));
		Set<Height>(RandomRange(0.8f, 1.2f));
		Set<PupilDilation>(RandomRange(0f, 1f));
		Set<SkinColor>(RandomColor());
		Set<Weight>(RandomRange(0f, 1f));
		Color color = RandomColor();
		List<string> constPaths2 = BaseFaceAppearance.GetConstPaths<Eyes>();
		if (constPaths2.Count > 0)
		{
			WithFaceLayer<Eyes>(RandomFromList(constPaths2), color);
		}
		List<string> constPaths3 = BaseFaceAppearance.GetConstPaths<Face>();
		if (constPaths3.Count > 0)
		{
			WithFaceLayer<Face>(RandomFromList(constPaths3), color);
		}
		if (Random.value < 0.5f)
		{
			List<string> constPaths4 = BaseFaceAppearance.GetConstPaths<FacialHair>();
			if (constPaths4.Count > 0)
			{
				WithFaceLayer<FacialHair>(RandomFromList(constPaths4), val);
			}
		}
		(Type, Action<string, Color>)[] source = new(Type, Action<string, Color>)[2]
		{
			(typeof(Shirts), delegate(string path, Color color2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				WithBodyLayer<Shirts>(path, color2);
			}),
			(typeof(Pants), delegate(string path, Color color2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				WithBodyLayer<Pants>(path, color2);
			})
		};
		foreach (var item7 in source.OrderBy(((Type type, Action<string, Color> apply) _) => Guid.NewGuid()).Take(Random.Range(1, 3)))
		{
			Type item3 = item7.type;
			Action<string, Color> item4 = item7.apply;
			MethodInfo methodInfo = AccessTools.Method(typeof(BaseBodyAppearance), "GetConstPaths", (Type[])null, (Type[])null).MakeGenericMethod(item3);
			List<string> list = (List<string>)methodInfo.Invoke(null, null);
			if (list != null && list.Count > 0)
			{
				item4(RandomFromList(list), RandomColor());
			}
		}
		(Type, Action<string, Color>)[] source2 = new(Type, Action<string, Color>)[7]
		{
			(typeof(Bottom), delegate(string path, Color color2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				WithAccessoryLayer<Bottom>(path, color2);
			}),
			(typeof(Chest), delegate(string path, Color color2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				WithAccessoryLayer<Chest>(path, color2);
			}),
			(typeof(Feet), delegate(string path, Color color2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				WithAccessoryLayer<Feet>(path, color2);
			}),
			(typeof(Hands), delegate(string path, Color color2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				WithAccessoryLayer<Hands>(path, color2);
			}),
			(typeof(Head), delegate(string path, Color color2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				WithAccessoryLayer<Head>(path, color2);
			}),
			(typeof(Neck), delegate(string path, Color color2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				WithAccessoryLayer<Neck>(path, color2);
			}),
			(typeof(Waist), delegate(string path, Color color2)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				WithAccessoryLayer<Waist>(path, color2);
			})
		};
		foreach (var item8 in source2.OrderBy(((Type type, Action<string, Color> apply) _) => Guid.NewGuid()).Take(Random.Range(2, 6)))
		{
			Type item5 = item8.type;
			Action<string, Color> item6 = item8.apply;
			MethodInfo methodInfo2 = AccessTools.Method(typeof(BaseAccessoryAppearance), "GetConstPaths", (Type[])null, (Type[])null).MakeGenericMethod(item5);
			List<string> list2 = (List<string>)methodInfo2.Invoke(null, null);
			if (list2 != null && list2.Count > 0)
			{
				item6(RandomFromList(list2), RandomColor());
			}
		}
		static Color RandomColor()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			return new Color(Random.value, Random.value, Random.value);
		}
		static string RandomFromList(List<string> list3)
		{
			return list3[Random.Range(0, list3.Count)];
		}
		static float RandomRange(float min, float max)
		{
			return Random.Range(min, max);
		}
	}

	private static void ApplyDefaultSettings(AvatarSettings avatarSettings)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		avatarSettings.SkinColor = Color32.op_Implicit(new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue));
		avatarSettings.Height = 0.98f;
		avatarSettings.Gender = 0f;
		avatarSettings.Weight = 0.4f;
		avatarSettings.EyebrowScale = 1f;
		avatarSettings.EyebrowThickness = 1f;
		avatarSettings.EyebrowRestingHeight = 0f;
		avatarSettings.EyebrowRestingAngle = 0f;
		avatarSettings.LeftEyeLidColor = Color32.op_Implicit(new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue));
		avatarSettings.RightEyeLidColor = Color32.op_Implicit(new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue));
		avatarSettings.LeftEyeRestingState = new EyeLidConfiguration
		{
			bottomLidOpen = 0.5f,
			topLidOpen = 0.5f
		};
		avatarSettings.RightEyeRestingState = new EyeLidConfiguration
		{
			bottomLidOpen = 0.5f,
			topLidOpen = 0.5f
		};
		avatarSettings.EyeballMaterialIdentifier = "Default";
		avatarSettings.EyeBallTint = Color.white;
		avatarSettings.PupilDilation = 1f;
		avatarSettings.HairPath = string.Empty;
		avatarSettings.HairColor = Color.black;
	}

	private static void SetLayerRecursively(GameObject obj, int layer)
	{
		if (!((Object)(object)obj == (Object)null))
		{
			obj.layer = layer;
			for (int i = 0; i < obj.transform.childCount; i++)
			{
				SetLayerRecursively(((Component)obj.transform.GetChild(i)).gameObject, layer);
			}
		}
	}

	private static void UpdatePoiIcons(NPC npc, Sprite iconSprite)
	{
		if ((Object)(object)npc == (Object)null || (Object)(object)iconSprite == (Object)null)
		{
			return;
		}
		try
		{
			Il2CppArrayBase<NPCPoI> val = Object.FindObjectsOfType<NPCPoI>();
			foreach (NPCPoI item in val)
			{
				if (!((Object)(object)item.NPC == (Object)(object)npc) || !((Object)(object)((POI)item).IconContainer != (Object)null))
				{
					continue;
				}
				Transform val2 = ((Transform)((POI)item).IconContainer).Find("Outline/Icon");
				if ((Object)(object)val2 != (Object)null)
				{
					Image component = ((Component)val2).GetComponent<Image>();
					if ((Object)(object)component != (Object)null)
					{
						component.sprite = iconSprite;
					}
				}
			}
		}
		catch (Exception ex)
		{
			_logger.Error("Failed to update POI icons: " + ex.Message);
		}
	}
}

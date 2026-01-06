using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppInterop.Runtime.Attributes;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using S1API.Entities;
using S1API.Entities.Relation;
using S1API.Internal.Map;
using S1API.Internal.Utils;
using S1API.Logging;
using S1API.Map;
using UnityEngine;

namespace S1API.Internal.Entities;

[RegisterTypeInIl2Cpp]
public sealed class NPCPrefabIdentity : MonoBehaviour
{
	private struct IdentityData
	{
		public string Id;

		public string FirstName;

		public string LastName;

		public Sprite Icon;

		public AvatarSettingsData AppearanceDefaults;

		public string DealerHomeBuildingName;

		public float? RelationDelta;

		public bool? Unlocked;

		public int? UnlockType;

		public List<string> ConnectionIDs;

		public string PrefabName;
	}

	private sealed class AvatarSettingsData
	{
		public float Gender;

		public float Height;

		public float Weight;

		public Color32 SkinColor;

		public Color EyeBallTint;

		public float PupilDilation;

		public float EyebrowScale;

		public float EyebrowThickness;

		public float EyebrowRestingHeight;

		public float EyebrowRestingAngle;

		public string HairPath;

		public Color HairColor;

		public Color LeftEyeLidColor;

		public Color RightEyeLidColor;

		public string EyeballMaterialIdentifier;

		public EyeStateData LeftEye = new EyeStateData();

		public EyeStateData RightEye = new EyeStateData();

		public List<LayerSettingData> FaceLayers = new List<LayerSettingData>();

		public List<LayerSettingData> BodyLayers = new List<LayerSettingData>();

		public List<AccessorySettingData> Accessories = new List<AccessorySettingData>();
	}

	private sealed class EyeStateData
	{
		public float TopLidOpen;

		public float BottomLidOpen;
	}

	private sealed class LayerSettingData
	{
		public string Path;

		public Color Color;
	}

	private sealed class AccessorySettingData
	{
		public string Path;

		public Color Color;
	}

	private static readonly Log Logger = new Log("NPCPrefabIdentity");

	public string Id;

	public string FirstName;

	public string LastName;

	public Sprite Icon;

	public AvatarSettings AppearanceDefaults;

	public string DealerHomeBuildingName;

	public string PrefabName;

	public float? RelationDelta;

	public bool? Unlocked;

	public NPCRelationship.UnlockType? UnlockType;

	public List<string> ConnectionIDs;

	private static readonly Dictionary<string, IdentityData> _registry = new Dictionary<string, IdentityData>();

	private bool _applied;

	private AvatarSettingsData _cachedAppearanceDefaults;

	private void Awake()
	{
		TryRestoreFromRegistry();
	}

	private void Start()
	{
		TryRestoreFromRegistry();
		TryApplyNow();
		if (!_applied)
		{
			MelonCoroutines.Start(DelayedApply());
		}
	}

	[HideFromIl2Cpp]
	internal static void RegisterRelationshipDataToStaticCache(string prefabName, NPCRelationshipDataBuilder builder)
	{
		if (string.IsNullOrEmpty(prefabName) || builder == null)
		{
			return;
		}
		try
		{
			string text = prefabName;
			if (text.EndsWith("(Clone)"))
			{
				text = text.Substring(0, text.Length - 7);
			}
			NPCRelationshipDataBuilder.RelationshipDefaultsData relationshipDefaultsData = builder.CaptureData();
			float? relationDelta = relationshipDefaultsData?.RelationDelta;
			bool? unlocked = relationshipDefaultsData?.Unlocked;
			NPCRelationship.UnlockType? unlockType = relationshipDefaultsData?.UnlockType;
			List<string> list = ((relationshipDefaultsData?.ConnectionIDs != null && relationshipDefaultsData.ConnectionIDs.Count > 0) ? new List<string>(relationshipDefaultsData.ConnectionIDs) : null);
			if (!_registry.TryGetValue(text, out var value))
			{
				value = default(IdentityData);
			}
			IdentityData value2 = value;
			if (relationDelta.HasValue)
			{
				value2.RelationDelta = relationDelta;
			}
			if (unlocked.HasValue)
			{
				value2.Unlocked = unlocked;
			}
			if (unlockType.HasValue)
			{
				value2.UnlockType = (int)unlockType.Value;
			}
			if (list != null && list.Count > 0)
			{
				value2.ConnectionIDs = new List<string>(list);
			}
			_registry[text] = value2;
		}
		catch (Exception ex)
		{
			Logger.Error("[Relationship Data] RegisterRelationshipDataToStaticCache: Exception storing relationship data for prefab '" + prefabName + "': " + ex.Message);
		}
	}

	[HideFromIl2Cpp]
	internal void RegisterToStaticCache(string prefabName)
	{
		if (string.IsNullOrEmpty(prefabName) || !DeferredMapResolver.IsMenuScene())
		{
			return;
		}
		string text = prefabName;
		if (text.EndsWith("(Clone)"))
		{
			text = text.Substring(0, text.Length - 7);
		}
		if (((Object)((Component)this).gameObject).name.EndsWith("(Clone)"))
		{
			return;
		}
		AvatarSettingsData source = CaptureAvatarSettings(AppearanceDefaults);
		_cachedAppearanceDefaults = CloneAvatarSettingsData(source);
		float? relationDelta = RelationDelta;
		bool? unlocked = Unlocked;
		int? unlockType = (UnlockType.HasValue ? new int?((int)UnlockType.Value) : ((int?)null));
		PrefabName = text;
		List<string> list = null;
		string dealerHomeBuildingName = DealerHomeBuildingName;
		if (_registry.TryGetValue(text, out var value))
		{
			if (!relationDelta.HasValue && value.RelationDelta.HasValue)
			{
				relationDelta = value.RelationDelta;
			}
			if (!unlocked.HasValue && value.Unlocked.HasValue)
			{
				unlocked = value.Unlocked;
			}
			if (!unlockType.HasValue && value.UnlockType.HasValue)
			{
				unlockType = value.UnlockType;
			}
			if (string.IsNullOrEmpty(dealerHomeBuildingName) && !string.IsNullOrEmpty(value.DealerHomeBuildingName))
			{
				dealerHomeBuildingName = value.DealerHomeBuildingName;
			}
			if (value.ConnectionIDs != null && value.ConnectionIDs.Count > 0)
			{
				list = new List<string>(value.ConnectionIDs);
			}
		}
		if ((list == null || list.Count == 0) && ConnectionIDs != null && ConnectionIDs.Count > 0)
		{
			list = new List<string>(ConnectionIDs);
		}
		IdentityData value2 = new IdentityData
		{
			Id = Id,
			FirstName = FirstName,
			LastName = LastName,
			Icon = Icon,
			AppearanceDefaults = CloneAvatarSettingsData(source),
			DealerHomeBuildingName = dealerHomeBuildingName,
			RelationDelta = relationDelta,
			Unlocked = unlocked,
			UnlockType = unlockType,
			ConnectionIDs = list,
			PrefabName = text
		};
		_registry[text] = value2;
		if (value2.AppearanceDefaults != null)
		{
			AppearanceDefaults = CreateAvatarSettings(value2.AppearanceDefaults);
		}
	}

	private void TryRestoreFromRegistry()
	{
		string text = ((Object)((Component)this).gameObject).name;
		if (text.EndsWith("(Clone)"))
		{
			text = text.Substring(0, text.Length - 7);
		}
		if (!string.IsNullOrEmpty(PrefabName))
		{
			text = PrefabName;
		}
		IdentityData? identityData = null;
		if (_registry.TryGetValue(text, out var value))
		{
			identityData = value;
		}
		else
		{
			foreach (KeyValuePair<string, IdentityData> item in _registry)
			{
				IdentityData value2 = item.Value;
				if (!string.IsNullOrEmpty(value2.PrefabName) && string.Equals(value2.PrefabName, text, StringComparison.OrdinalIgnoreCase))
				{
					identityData = value2;
					PrefabName = value2.PrefabName;
					break;
				}
			}
			if (!identityData.HasValue)
			{
				try
				{
					NPC component = ((Component)this).GetComponent<NPC>();
					if ((Object)(object)component != (Object)null && !string.IsNullOrEmpty(component.ID))
					{
						foreach (KeyValuePair<string, IdentityData> item2 in _registry)
						{
							IdentityData value3 = item2.Value;
							if (!string.IsNullOrEmpty(value3.Id) && string.Equals(value3.Id, component.ID, StringComparison.OrdinalIgnoreCase))
							{
								identityData = value3;
								PrefabName = value3.PrefabName ?? item2.Key;
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
					Logger.Warning("[NPCPrefabIdentity] Exception during ID-based registry lookup: " + ex.Message);
				}
			}
			if (!identityData.HasValue && text.StartsWith("S1API_", StringComparison.OrdinalIgnoreCase) && _registry.TryGetValue(text, out var value4))
			{
				identityData = value4;
				PrefabName = text;
			}
		}
		if (!identityData.HasValue)
		{
			return;
		}
		IdentityData value5 = identityData.Value;
		if (string.IsNullOrEmpty(Id) && !string.IsNullOrEmpty(value5.Id))
		{
			Id = value5.Id;
		}
		if (string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(value5.FirstName))
		{
			FirstName = value5.FirstName;
		}
		if (string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(value5.LastName))
		{
			LastName = value5.LastName;
		}
		if ((Object)(object)Icon == (Object)null && (Object)(object)value5.Icon != (Object)null)
		{
			Icon = value5.Icon;
		}
		if (string.IsNullOrEmpty(DealerHomeBuildingName) && !string.IsNullOrEmpty(value5.DealerHomeBuildingName))
		{
			DealerHomeBuildingName = value5.DealerHomeBuildingName;
		}
		RelationDelta = value5.RelationDelta;
		Unlocked = value5.Unlocked;
		UnlockType = (value5.UnlockType.HasValue ? new NPCRelationship.UnlockType?((NPCRelationship.UnlockType)value5.UnlockType.Value) : ((NPCRelationship.UnlockType?)null));
		ConnectionIDs = ((value5.ConnectionIDs != null) ? new List<string>(value5.ConnectionIDs) : null);
		PrefabName = value5.PrefabName ?? PrefabName;
		if ((Object)(object)AppearanceDefaults == (Object)null)
		{
			_cachedAppearanceDefaults = CloneAvatarSettingsData(value5.AppearanceDefaults);
			if (_cachedAppearanceDefaults != null)
			{
				AppearanceDefaults = CreateAvatarSettings(_cachedAppearanceDefaults);
			}
			else
			{
				AppearanceDefaults = null;
			}
		}
	}

	[HideFromIl2Cpp]
	private IEnumerator DelayedApply()
	{
		float start = Time.realtimeSinceStartup;
		float timeout = 3f;
		while (!_applied && Time.realtimeSinceStartup - start < timeout)
		{
			TryApplyNow();
			if (_applied)
			{
				break;
			}
			yield return (object)new WaitForSeconds(0.05f);
		}
	}

	[HideFromIl2Cpp]
	private void EnsureRelationshipDataFromRegistry()
	{
		if (ConnectionIDs == null || ConnectionIDs.Count == 0 || !Unlocked.HasValue || !RelationDelta.HasValue || !UnlockType.HasValue)
		{
			TryRestoreFromRegistry();
		}
	}

	[HideFromIl2Cpp]
	private void EnsureDealerHomeBuildingNameFromRegistry()
	{
		if (!string.IsNullOrEmpty(DealerHomeBuildingName))
		{
			return;
		}
		string text = ((Object)((Component)this).gameObject).name;
		if (text.EndsWith("(Clone)"))
		{
			text = text.Substring(0, text.Length - 7);
		}
		if (!string.IsNullOrEmpty(PrefabName))
		{
			text = PrefabName;
		}
		IdentityData? identityData = null;
		if (_registry.TryGetValue(text, out var value))
		{
			identityData = value;
		}
		else
		{
			foreach (KeyValuePair<string, IdentityData> item in _registry)
			{
				IdentityData value2 = item.Value;
				if (!string.IsNullOrEmpty(value2.PrefabName) && string.Equals(value2.PrefabName, text, StringComparison.OrdinalIgnoreCase))
				{
					identityData = value2;
					PrefabName = value2.PrefabName;
					break;
				}
			}
			if (!identityData.HasValue)
			{
				try
				{
					NPC component = ((Component)this).GetComponent<NPC>();
					if ((Object)(object)component != (Object)null && !string.IsNullOrEmpty(component.ID))
					{
						foreach (KeyValuePair<string, IdentityData> item2 in _registry)
						{
							IdentityData value3 = item2.Value;
							if (!string.IsNullOrEmpty(value3.Id) && string.Equals(value3.Id, component.ID, StringComparison.OrdinalIgnoreCase))
							{
								identityData = value3;
								PrefabName = value3.PrefabName ?? item2.Key;
								break;
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		if (identityData.HasValue && !string.IsNullOrEmpty(identityData.Value.DealerHomeBuildingName))
		{
			DealerHomeBuildingName = identityData.Value.DealerHomeBuildingName;
		}
	}

	public void ApplyRelationshipDataTo(NPC npc, bool preserveUnlockState = false)
	{
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		EnsureRelationshipDataFromRegistry();
		NPCRelationData relationData = npc.RelationData;
		if (relationData == null)
		{
			return;
		}
		try
		{
			NPCRelationshipDataBuilder nPCRelationshipDataBuilder = new NPCRelationshipDataBuilder();
			if (RelationDelta.HasValue)
			{
				nPCRelationshipDataBuilder.WithDelta(RelationDelta.Value);
			}
			if (Unlocked.HasValue)
			{
				nPCRelationshipDataBuilder.SetUnlocked(Unlocked.Value);
			}
			if (UnlockType.HasValue)
			{
				nPCRelationshipDataBuilder.SetUnlockType(UnlockType.Value);
			}
			if (ConnectionIDs != null && ConnectionIDs.Count > 0)
			{
				nPCRelationshipDataBuilder.WithConnectionsById(ConnectionIDs);
			}
			nPCRelationshipDataBuilder.ApplyTo(relationData, npc, preserveUnlockState);
		}
		catch (Exception ex)
		{
			Logger.Error("[Relationship Data] ApplyRelationshipDataTo: Exception applying relationship data to NPC '" + (((npc != null) ? npc.ID : null) ?? "<null>") + "': " + ex.Message);
		}
	}

	public void ApplyTo(NPC npc)
	{
		if ((Object)(object)npc == (Object)null)
		{
			return;
		}
		if (string.IsNullOrEmpty(Id) && string.IsNullOrEmpty(FirstName))
		{
			TryRestoreFromRegistry();
		}
		EnsureRelationshipDataFromRegistry();
		EnsureDealerHomeBuildingNameFromRegistry();
		try
		{
			if (!string.IsNullOrEmpty(FirstName))
			{
				npc.FirstName = FirstName;
			}
		}
		catch
		{
		}
		try
		{
			if (!string.IsNullOrEmpty(LastName))
			{
				npc.LastName = LastName;
			}
		}
		catch
		{
		}
		try
		{
			if (!string.IsNullOrEmpty(Id))
			{
				npc.ID = Id;
			}
		}
		catch
		{
		}
		try
		{
			if ((Object)(object)Icon != (Object)null)
			{
				npc.MugshotSprite = Icon;
			}
		}
		catch
		{
		}
		try
		{
			Avatar val = npc.Avatar ?? ((Component)npc).GetComponentInChildren<Avatar>(true);
			if ((Object)(object)val != (Object)null && (Object)(object)AppearanceDefaults != (Object)null)
			{
				val.LoadAvatarSettings(AppearanceDefaults);
			}
		}
		catch
		{
		}
		try
		{
			string text = DealerHomeBuildingName;
			if (string.IsNullOrEmpty(text))
			{
				string text2 = ((Object)((Component)this).gameObject).name;
				if (text2.EndsWith("(Clone)"))
				{
					text2 = text2.Substring(0, text2.Length - 7);
				}
				if (!string.IsNullOrEmpty(PrefabName))
				{
					text2 = PrefabName;
				}
				IdentityData? identityData = null;
				if (_registry.TryGetValue(text2, out var value))
				{
					identityData = value;
				}
				else
				{
					try
					{
						if ((Object)(object)npc != (Object)null && !string.IsNullOrEmpty(npc.ID))
						{
							foreach (KeyValuePair<string, IdentityData> item in _registry)
							{
								IdentityData value2 = item.Value;
								if (!string.IsNullOrEmpty(value2.Id) && string.Equals(value2.Id, npc.ID, StringComparison.OrdinalIgnoreCase))
								{
									identityData = value2;
									PrefabName = value2.PrefabName ?? item.Key;
									break;
								}
							}
						}
					}
					catch
					{
					}
				}
				if (identityData.HasValue && !string.IsNullOrEmpty(identityData.Value.DealerHomeBuildingName))
				{
					text = (DealerHomeBuildingName = identityData.Value.DealerHomeBuildingName);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				ApplyDealerHomeBuilding(npc, text);
			}
		}
		catch
		{
		}
	}

	[HideFromIl2Cpp]
	private void ApplyDealerHomeBuilding(NPC npc, string buildingName = null)
	{
		if (string.IsNullOrEmpty(buildingName))
		{
			buildingName = DealerHomeBuildingName;
		}
		if (DeferredMapResolver.IsMenuScene())
		{
			return;
		}
		try
		{
			if (string.IsNullOrEmpty(buildingName))
			{
				Logger.Warning("[Dealer Home] Building name is empty for NPC " + (((npc != null) ? npc.ID : null) ?? "<null>"));
				return;
			}
			Dealer component = ((Component)npc).GetComponent<Dealer>();
			if ((Object)(object)component == (Object)null)
			{
				Logger.Warning("[Dealer Home] Dealer component not found for NPC " + (((npc != null) ? npc.ID : null) ?? "<null>"));
				return;
			}
			global::S1API.Map.Building byName = global::S1API.Map.Building.GetByName(buildingName);
			if (byName == null)
			{
				Logger.Warning("[Dealer Home] Building '" + buildingName + "' not found in registry for NPC " + (((npc != null) ? npc.ID : null) ?? "<null>"));
				return;
			}
			object obj = byName.ResolveGameBuilding();
			if (obj == null)
			{
				Logger.Warning("[Dealer Home] Building '" + buildingName + "' wrapper found but game building is null for NPC " + (((npc != null) ? npc.ID : null) ?? "<null>"));
			}
			else if (!ReflectionUtils.TrySetFieldOrProperty(component, "Home", obj))
			{
				Logger.Warning("[Dealer Home] Failed to set Home property on Dealer component for NPC " + (((npc != null) ? npc.ID : null) ?? "<null>"));
			}
		}
		catch (Exception ex)
		{
			Logger.Error("[Dealer Home] Exception applying dealer home building for NPC " + (((npc != null) ? npc.ID : null) ?? "<null>") + ": " + ex.Message);
			Logger.Error("[Dealer Home] Stack trace: " + ex.StackTrace);
		}
	}

	private void TryApplyNow()
	{
		try
		{
			NPC component = ((Component)this).GetComponent<NPC>();
			if (!((Object)(object)component == (Object)null))
			{
				EnsureAppearanceDefaults();
				ApplyTo(component);
				Avatar val = component.Avatar ?? ((Component)component).GetComponentInChildren<Avatar>(true);
				_applied = (Object)(object)AppearanceDefaults == (Object)null || (Object)(object)val != (Object)null;
			}
		}
		catch
		{
		}
	}

	private void EnsureAppearanceDefaults()
	{
		if (!((Object)(object)AppearanceDefaults != (Object)null))
		{
			IdentityData data;
			if (_cachedAppearanceDefaults != null)
			{
				AppearanceDefaults = CreateAvatarSettings(_cachedAppearanceDefaults);
			}
			else if (TryGetRegistryData(out data) && data.AppearanceDefaults != null)
			{
				_cachedAppearanceDefaults = CloneAvatarSettingsData(data.AppearanceDefaults);
				AppearanceDefaults = CreateAvatarSettings(_cachedAppearanceDefaults);
			}
		}
	}

	[HideFromIl2Cpp]
	private bool TryGetRegistryData(out IdentityData data)
	{
		string text = ((Object)((Component)this).gameObject).name;
		if (text.EndsWith("(Clone)"))
		{
			text = text.Substring(0, text.Length - 7);
		}
		return _registry.TryGetValue(text, out data);
	}

	[HideFromIl2Cpp]
	internal static bool TryGetIdentityFromRegistry(string prefabName, out string id, out string firstName, out string lastName, out Sprite icon)
	{
		id = null;
		firstName = null;
		lastName = null;
		icon = null;
		if (string.IsNullOrEmpty(prefabName))
		{
			return false;
		}
		if (prefabName.EndsWith("(Clone)"))
		{
			prefabName = prefabName.Substring(0, prefabName.Length - 7);
		}
		if (_registry.TryGetValue(prefabName, out var value))
		{
			id = value.Id;
			firstName = value.FirstName;
			lastName = value.LastName;
			icon = value.Icon;
			return true;
		}
		return false;
	}

	[HideFromIl2Cpp]
	internal static bool TryGetRelationshipDataFromRegistry(string prefabName, out float? relationDelta, out bool? unlocked, out NPCRelationship.UnlockType? unlockType, out List<string> connectionIDs)
	{
		relationDelta = null;
		unlocked = null;
		unlockType = null;
		connectionIDs = null;
		if (string.IsNullOrEmpty(prefabName))
		{
			return false;
		}
		if (prefabName.EndsWith("(Clone)"))
		{
			prefabName = prefabName.Substring(0, prefabName.Length - 7);
		}
		if (_registry.TryGetValue(prefabName, out var value))
		{
			relationDelta = value.RelationDelta;
			unlocked = value.Unlocked;
			unlockType = (value.UnlockType.HasValue ? new NPCRelationship.UnlockType?((NPCRelationship.UnlockType)value.UnlockType.Value) : ((NPCRelationship.UnlockType?)null));
			connectionIDs = ((value.ConnectionIDs != null) ? new List<string>(value.ConnectionIDs) : null);
			return true;
		}
		return false;
	}

	[HideFromIl2Cpp]
	private static AvatarSettingsData CaptureAvatarSettings(AvatarSettings settings)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)settings == (Object)null)
		{
			return null;
		}
		AvatarSettingsData avatarSettingsData = new AvatarSettingsData
		{
			Gender = settings.Gender,
			Height = settings.Height,
			Weight = settings.Weight,
			SkinColor = Color32.op_Implicit(settings.SkinColor),
			EyeBallTint = settings.EyeBallTint,
			LeftEyeLidColor = settings.LeftEyeLidColor,
			RightEyeLidColor = settings.RightEyeLidColor,
			EyeballMaterialIdentifier = settings.EyeballMaterialIdentifier,
			PupilDilation = settings.PupilDilation,
			EyebrowScale = settings.EyebrowScale,
			EyebrowThickness = settings.EyebrowThickness,
			EyebrowRestingHeight = settings.EyebrowRestingHeight,
			EyebrowRestingAngle = settings.EyebrowRestingAngle,
			HairPath = settings.HairPath,
			HairColor = settings.HairColor,
			LeftEye = new EyeStateData
			{
				TopLidOpen = settings.LeftEyeRestingState.topLidOpen,
				BottomLidOpen = settings.LeftEyeRestingState.bottomLidOpen
			},
			RightEye = new EyeStateData
			{
				TopLidOpen = settings.RightEyeRestingState.topLidOpen,
				BottomLidOpen = settings.RightEyeRestingState.bottomLidOpen
			}
		};
		if (settings.FaceLayerSettings != null)
		{
			for (int i = 0; i < settings.FaceLayerSettings.Count; i++)
			{
				LayerSetting val = settings.FaceLayerSettings[i];
				avatarSettingsData.FaceLayers.Add(new LayerSettingData
				{
					Path = val.layerPath,
					Color = val.layerTint
				});
			}
		}
		if (settings.BodyLayerSettings != null)
		{
			for (int j = 0; j < settings.BodyLayerSettings.Count; j++)
			{
				LayerSetting val2 = settings.BodyLayerSettings[j];
				avatarSettingsData.BodyLayers.Add(new LayerSettingData
				{
					Path = val2.layerPath,
					Color = val2.layerTint
				});
			}
		}
		if (settings.AccessorySettings != null)
		{
			for (int k = 0; k < settings.AccessorySettings.Count; k++)
			{
				AccessorySetting val3 = settings.AccessorySettings[k];
				avatarSettingsData.Accessories.Add(new AccessorySettingData
				{
					Path = val3.path,
					Color = val3.color
				});
			}
		}
		return avatarSettingsData;
	}

	[HideFromIl2Cpp]
	private static AvatarSettingsData CloneAvatarSettingsData(AvatarSettingsData source)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		if (source == null)
		{
			return null;
		}
		AvatarSettingsData avatarSettingsData = new AvatarSettingsData
		{
			Gender = source.Gender,
			Height = source.Height,
			Weight = source.Weight,
			SkinColor = source.SkinColor,
			EyeBallTint = source.EyeBallTint,
			PupilDilation = source.PupilDilation,
			EyebrowScale = source.EyebrowScale,
			EyebrowThickness = source.EyebrowThickness,
			EyebrowRestingHeight = source.EyebrowRestingHeight,
			EyebrowRestingAngle = source.EyebrowRestingAngle,
			HairPath = source.HairPath,
			HairColor = source.HairColor,
			LeftEyeLidColor = source.LeftEyeLidColor,
			RightEyeLidColor = source.RightEyeLidColor,
			EyeballMaterialIdentifier = source.EyeballMaterialIdentifier,
			LeftEye = new EyeStateData
			{
				TopLidOpen = source.LeftEye.TopLidOpen,
				BottomLidOpen = source.LeftEye.BottomLidOpen
			},
			RightEye = new EyeStateData
			{
				TopLidOpen = source.RightEye.TopLidOpen,
				BottomLidOpen = source.RightEye.BottomLidOpen
			}
		};
		for (int i = 0; i < source.FaceLayers.Count; i++)
		{
			LayerSettingData layerSettingData = source.FaceLayers[i];
			avatarSettingsData.FaceLayers.Add(new LayerSettingData
			{
				Path = layerSettingData.Path,
				Color = layerSettingData.Color
			});
		}
		for (int j = 0; j < source.BodyLayers.Count; j++)
		{
			LayerSettingData layerSettingData2 = source.BodyLayers[j];
			avatarSettingsData.BodyLayers.Add(new LayerSettingData
			{
				Path = layerSettingData2.Path,
				Color = layerSettingData2.Color
			});
		}
		for (int k = 0; k < source.Accessories.Count; k++)
		{
			AccessorySettingData accessorySettingData = source.Accessories[k];
			avatarSettingsData.Accessories.Add(new AccessorySettingData
			{
				Path = accessorySettingData.Path,
				Color = accessorySettingData.Color
			});
		}
		return avatarSettingsData;
	}

	[HideFromIl2Cpp]
	private static AvatarSettings CreateAvatarSettings(AvatarSettingsData data)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		if (data == null)
		{
			return null;
		}
		AvatarSettings val = ScriptableObject.CreateInstance<AvatarSettings>();
		((Object)val).hideFlags = (HideFlags)32;
		val.Gender = data.Gender;
		val.Height = data.Height;
		val.Weight = data.Weight;
		val.SkinColor = Color32.op_Implicit(data.SkinColor);
		val.LeftEyeLidColor = data.LeftEyeLidColor;
		val.RightEyeLidColor = data.RightEyeLidColor;
		val.EyeBallTint = data.EyeBallTint;
		val.EyeballMaterialIdentifier = data.EyeballMaterialIdentifier;
		val.PupilDilation = data.PupilDilation;
		val.EyebrowScale = data.EyebrowScale;
		val.EyebrowThickness = data.EyebrowThickness;
		val.EyebrowRestingHeight = data.EyebrowRestingHeight;
		val.EyebrowRestingAngle = data.EyebrowRestingAngle;
		val.HairPath = data.HairPath ?? string.Empty;
		val.HairColor = data.HairColor;
		val.LeftEyeRestingState = new EyeLidConfiguration
		{
			topLidOpen = data.LeftEye.TopLidOpen,
			bottomLidOpen = data.LeftEye.BottomLidOpen
		};
		val.RightEyeRestingState = new EyeLidConfiguration
		{
			topLidOpen = data.RightEye.TopLidOpen,
			bottomLidOpen = data.RightEye.BottomLidOpen
		};
		List<LayerSetting> list = new List<LayerSetting>();
		for (int i = 0; i < data.FaceLayers.Count; i++)
		{
			LayerSettingData layerSettingData = data.FaceLayers[i];
			list.Add(new LayerSetting
			{
				layerPath = layerSettingData.Path,
				layerTint = layerSettingData.Color
			});
		}
		List<LayerSetting> list2 = new List<LayerSetting>();
		for (int j = 0; j < data.BodyLayers.Count; j++)
		{
			LayerSettingData layerSettingData2 = data.BodyLayers[j];
			list2.Add(new LayerSetting
			{
				layerPath = layerSettingData2.Path,
				layerTint = layerSettingData2.Color
			});
		}
		List<AccessorySetting> list3 = new List<AccessorySetting>();
		for (int k = 0; k < data.Accessories.Count; k++)
		{
			AccessorySettingData accessorySettingData = data.Accessories[k];
			list3.Add(new AccessorySetting
			{
				path = accessorySettingData.Path,
				color = accessorySettingData.Color
			});
		}
		val.FaceLayerSettings = ToIl2CppList(list);
		val.BodyLayerSettings = ToIl2CppList(list2);
		val.AccessorySettings = ToIl2CppList(list3);
		return val;
	}

	[HideFromIl2Cpp]
	private static List<T> ToIl2CppList<T>(List<T> source)
	{
		List<T> val = new List<T>();
		if (source == null)
		{
			return val;
		}
		for (int i = 0; i < source.Count; i++)
		{
			val.Add(source[i]);
		}
		return val;
	}
}

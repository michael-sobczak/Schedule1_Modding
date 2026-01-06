using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using S1API.Entities.Customer;
using S1API.Entities.Dealer;
using S1API.Entities.Relation;
using S1API.Entities.Schedule;
using S1API.Internal.Entities;
using S1API.Internal.Utils;
using S1API.Logging;
using UnityEngine;

namespace S1API.Entities;

public sealed class NPCPrefabBuilder
{
	public sealed class AvatarDefaultsBuilder
	{
		internal readonly List<(string path, Color color)> FaceLayers = new List<(string, Color)>();

		internal readonly List<(string path, Color color)> BodyLayers = new List<(string, Color)>();

		internal readonly List<(string path, Color color)> AccessoryLayers = new List<(string, Color)>();

		public float Gender { get; set; } = 0f;

		public float Height { get; set; } = 1f;

		public float Weight { get; set; } = 0.5f;

		public Color32 SkinColor { get; set; } = new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue);

		public Color LeftEyeLidColor { get; set; } = Color32.op_Implicit(new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue));

		public Color RightEyeLidColor { get; set; } = Color32.op_Implicit(new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue));

		public Color EyeBallTint { get; set; } = Color.white;

		public string EyeballMaterialIdentifier { get; set; } = "Default";

		public float PupilDilation { get; set; } = 1f;

		public float EyebrowScale { get; set; } = 1f;

		public float EyebrowThickness { get; set; } = 1f;

		public float EyebrowRestingHeight { get; set; } = 0f;

		public float EyebrowRestingAngle { get; set; } = 0f;

		public (float topLidOpen, float bottomLidOpen) LeftEye { get; set; } = (topLidOpen: 0.5f, bottomLidOpen: 0.5f);

		public (float topLidOpen, float bottomLidOpen) RightEye { get; set; } = (topLidOpen: 0.5f, bottomLidOpen: 0.5f);

		public string HairPath { get; set; } = string.Empty;

		public Color HairColor { get; set; } = Color.black;

		public AvatarDefaultsBuilder WithFaceLayer(string path, Color color)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if (!string.IsNullOrEmpty(path))
			{
				FaceLayers.Add((path, color));
			}
			return this;
		}

		public AvatarDefaultsBuilder WithBodyLayer(string path, Color color)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if (!string.IsNullOrEmpty(path))
			{
				BodyLayers.Add((path, color));
			}
			return this;
		}

		public AvatarDefaultsBuilder WithAccessoryLayer(string path, Color color)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if (!string.IsNullOrEmpty(path))
			{
				AccessoryLayers.Add((path, color));
			}
			return this;
		}
	}

	private static readonly Log Logger = new Log("NPCPrefabBuilder");

	private readonly GameObject prefabRoot;

	private readonly Type ownerType;

	internal NPCPrefabBuilder(GameObject prefabRoot, Type ownerType)
	{
		this.prefabRoot = prefabRoot;
		this.ownerType = ownerType;
	}

	private NPCScheduleManager EnsureScheduleManager()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		NPCScheduleManager val = prefabRoot.GetComponentInChildren<NPCScheduleManager>(true);
		if ((Object)(object)val == (Object)null)
		{
			GameObject val2 = new GameObject("NPCSchedule");
			val2.transform.SetParent(prefabRoot.transform, false);
			val = val2.AddComponent<NPCScheduleManager>();
		}
		return val;
	}

	public NPCPrefabBuilder EnsureCustomer()
	{
		Customer component = prefabRoot.GetComponent<Customer>();
		if ((Object)(object)component == (Object)null)
		{
			component = prefabRoot.AddComponent<Customer>();
			((Behaviour)component).enabled = true;
		}
		NPC.RegisterCustomerType(ownerType);
		return this;
	}

	public NPCPrefabBuilder WithIdentity(string id, string firstName, string lastName)
	{
		try
		{
			NPCPrefabIdentity nPCPrefabIdentity = EnsureIdentityComponent();
			nPCPrefabIdentity.Id = id;
			nPCPrefabIdentity.FirstName = firstName;
			nPCPrefabIdentity.LastName = lastName;
			nPCPrefabIdentity.RegisterToStaticCache(((Object)prefabRoot).name);
		}
		catch
		{
		}
		return this;
	}

	public NPCPrefabBuilder WithIcon(Sprite? icon)
	{
		try
		{
			NPCPrefabIdentity nPCPrefabIdentity = EnsureIdentityComponent();
			nPCPrefabIdentity.Icon = icon;
			nPCPrefabIdentity.RegisterToStaticCache(((Object)prefabRoot).name);
		}
		catch
		{
		}
		return this;
	}

	public NPCPrefabBuilder WithAppearanceDefaults(Action<AvatarDefaultsBuilder> configure)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		if (configure == null)
		{
			return this;
		}
		try
		{
			AvatarDefaultsBuilder avatarDefaultsBuilder = new AvatarDefaultsBuilder();
			configure(avatarDefaultsBuilder);
			AvatarSettings val = ScriptableObject.CreateInstance<AvatarSettings>();
			((Object)val).hideFlags = (HideFlags)32;
			val.Gender = avatarDefaultsBuilder.Gender;
			val.Height = avatarDefaultsBuilder.Height;
			val.Weight = avatarDefaultsBuilder.Weight;
			val.SkinColor = Color32.op_Implicit(avatarDefaultsBuilder.SkinColor);
			val.LeftEyeLidColor = avatarDefaultsBuilder.LeftEyeLidColor;
			val.RightEyeLidColor = avatarDefaultsBuilder.RightEyeLidColor;
			val.EyeBallTint = avatarDefaultsBuilder.EyeBallTint;
			val.EyeballMaterialIdentifier = avatarDefaultsBuilder.EyeballMaterialIdentifier ?? string.Empty;
			val.PupilDilation = avatarDefaultsBuilder.PupilDilation;
			val.EyebrowScale = avatarDefaultsBuilder.EyebrowScale;
			val.EyebrowThickness = avatarDefaultsBuilder.EyebrowThickness;
			val.EyebrowRestingHeight = avatarDefaultsBuilder.EyebrowRestingHeight;
			val.EyebrowRestingAngle = avatarDefaultsBuilder.EyebrowRestingAngle;
			val.HairPath = avatarDefaultsBuilder.HairPath ?? string.Empty;
			val.HairColor = avatarDefaultsBuilder.HairColor;
			val.LeftEyeRestingState = new EyeLidConfiguration
			{
				topLidOpen = avatarDefaultsBuilder.LeftEye.topLidOpen,
				bottomLidOpen = avatarDefaultsBuilder.LeftEye.bottomLidOpen
			};
			val.RightEyeRestingState = new EyeLidConfiguration
			{
				topLidOpen = avatarDefaultsBuilder.RightEye.topLidOpen,
				bottomLidOpen = avatarDefaultsBuilder.RightEye.bottomLidOpen
			};
			List<LayerSetting> source = new List<LayerSetting>();
			List<LayerSetting> source2 = new List<LayerSetting>();
			List<AccessorySetting> source3 = new List<AccessorySetting>();
			if (val.FaceLayerSettings == null)
			{
				val.FaceLayerSettings = ToIl2CppList(source);
			}
			if (val.BodyLayerSettings == null)
			{
				val.BodyLayerSettings = ToIl2CppList(source2);
			}
			if (val.AccessorySettings == null)
			{
				val.AccessorySettings = ToIl2CppList(source3);
			}
			for (int i = 0; i < avatarDefaultsBuilder.FaceLayers.Count; i++)
			{
				(string, Color) tuple = avatarDefaultsBuilder.FaceLayers[i];
				List<LayerSetting> faceLayerSettings = val.FaceLayerSettings;
				LayerSetting val2 = new LayerSetting();
				(val2.layerPath, val2.layerTint) = tuple;
				faceLayerSettings.Add(val2);
			}
			for (int j = 0; j < avatarDefaultsBuilder.BodyLayers.Count; j++)
			{
				(string, Color) tuple3 = avatarDefaultsBuilder.BodyLayers[j];
				List<LayerSetting> bodyLayerSettings = val.BodyLayerSettings;
				LayerSetting val3 = new LayerSetting();
				(val3.layerPath, val3.layerTint) = tuple3;
				bodyLayerSettings.Add(val3);
			}
			for (int k = 0; k < avatarDefaultsBuilder.AccessoryLayers.Count; k++)
			{
				(string, Color) tuple5 = avatarDefaultsBuilder.AccessoryLayers[k];
				List<AccessorySetting> accessorySettings = val.AccessorySettings;
				AccessorySetting val4 = new AccessorySetting();
				(val4.path, val4.color) = tuple5;
				accessorySettings.Add(val4);
			}
			NPCPrefabIdentity nPCPrefabIdentity = EnsureIdentityComponent();
			nPCPrefabIdentity.AppearanceDefaults = val;
			nPCPrefabIdentity.RegisterToStaticCache(((Object)prefabRoot).name);
			ApplyAvatarSettingsToPrefab(val);
		}
		catch
		{
		}
		return this;
	}

	public NPCPrefabBuilder WithSchedule(Action<PrefabScheduleBuilder> configure)
	{
		if (configure == null)
		{
			return this;
		}
		try
		{
			PrefabScheduleBuilder prefabScheduleBuilder = new PrefabScheduleBuilder();
			configure(prefabScheduleBuilder);
			List<IScheduleActionSpec> specs = prefabScheduleBuilder.Build();
			return WithSchedule(specs);
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to build schedule for NPC type " + (ownerType?.Name ?? "Unknown") + ": " + ex.Message);
			Logger.Error("Stack trace: " + ex.StackTrace);
			return this;
		}
	}

	public NPCPrefabBuilder WithSchedule(IEnumerable<IScheduleActionSpec> specs)
	{
		if (specs == null)
		{
			return this;
		}
		try
		{
			List<IScheduleActionSpec> list = (specs as List<IScheduleActionSpec>) ?? new List<IScheduleActionSpec>(specs);
			if (list.Count == 0)
			{
				return this;
			}
			NPC.RegisterSchedulePlanForType(ownerType, list);
			PrecreateActionsForSpecs(list);
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to register schedule plan for NPC type " + (ownerType?.Name ?? "Unknown") + ": " + ex.Message);
			Logger.Error("Stack trace: " + ex.StackTrace);
		}
		return this;
	}

	public NPCPrefabBuilder WithSchedule(params IScheduleActionSpec[] specs)
	{
		if (specs == null || specs.Length == 0)
		{
			return this;
		}
		return WithSchedule((IEnumerable<IScheduleActionSpec>)specs);
	}

	public NPCPrefabBuilder EnsureDealer()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		NPC.RegisterDealerType(ownerType);
		NPCScheduleManager val = EnsureScheduleManager();
		NPCBehaviour val2 = prefabRoot.GetComponentInChildren<NPCBehaviour>(true);
		if ((Object)(object)val2 == (Object)null)
		{
			GameObject val3 = new GameObject("NPCBehaviour");
			val3.transform.SetParent(((Component)val).transform, false);
			val2 = val3.AddComponent<NPCBehaviour>();
		}
		DealerAttendDealBehaviour componentInChildren = prefabRoot.GetComponentInChildren<DealerAttendDealBehaviour>(true);
		if ((Object)(object)componentInChildren == (Object)null)
		{
			GameObject val4 = new GameObject("DealerAttendDealBehaviour");
			val4.transform.SetParent(((Component)val2).transform, false);
			componentInChildren = val4.AddComponent<DealerAttendDealBehaviour>();
			val4.SetActive(false);
		}
		NPCEvent_StayInBuilding componentInChildren2 = prefabRoot.GetComponentInChildren<NPCEvent_StayInBuilding>(true);
		if ((Object)(object)componentInChildren2 == (Object)null)
		{
			GameObject val5 = new GameObject("StayInBuilding");
			val5.transform.SetParent(((Component)val).transform, false);
			componentInChildren2 = val5.AddComponent<NPCEvent_StayInBuilding>();
			val5.SetActive(false);
		}
		return this;
	}

	public NPCPrefabBuilder WithCustomerDefaults(Action<CustomerDataBuilder> configure)
	{
		if (configure == null)
		{
			return this;
		}
		EnsureCustomer();
		Customer component = prefabRoot.GetComponent<Customer>();
		if ((Object)(object)component != (Object)null)
		{
			try
			{
				CustomerDataBuilder customerDataBuilder = new CustomerDataBuilder();
				configure(customerDataBuilder);
				CustomerData customerData = customerDataBuilder.BuildInternal();
				component.customerData = customerData;
			}
			catch
			{
			}
		}
		NPC.RegisterCustomerDefaultsForType(ownerType, configure);
		return this;
	}

	public NPCPrefabBuilder WithRelationshipDefaults(Action<NPCRelationshipDataBuilder> configure)
	{
		if (configure != null)
		{
			NPC.RegisterRelationshipDefaultsForType(ownerType, configure);
			try
			{
				NPCRelationshipDataBuilder nPCRelationshipDataBuilder = new NPCRelationshipDataBuilder();
				configure(nPCRelationshipDataBuilder);
				NPCPrefabIdentity.RegisterRelationshipDataToStaticCache(((Object)prefabRoot).name, nPCRelationshipDataBuilder);
			}
			catch (Exception ex)
			{
				Logger.Error("[Relationship Data] WithRelationshipDefaults: Exception registering relationship data for prefab '" + ((Object)prefabRoot).name + "': " + ex.Message);
			}
		}
		return this;
	}

	public NPCPrefabBuilder WithSpawnPosition(Vector3 position, Quaternion rotation)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		NPC.RegisterSpawnPositionForType(ownerType, position, rotation);
		return this;
	}

	public NPCPrefabBuilder WithSpawnPosition(Vector3 position)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return WithSpawnPosition(position, Quaternion.identity);
	}

	public NPCPrefabBuilder WithDealerDefaults(Action<DealerDataBuilder> configure)
	{
		if (configure == null)
		{
			return this;
		}
		EnsureDealer();
		NPC.RegisterDealerDefaultsForType(ownerType, configure);
		return this;
	}

	public NPCPrefabBuilder WithInventoryDefaults(Action<RandomInventoryItemsBuilder> configure)
	{
		if (configure == null)
		{
			return this;
		}
		try
		{
			NPC.RegisterRandomInventoryDefaultsForType(ownerType, configure);
			NPCInventory component = prefabRoot.GetComponent<NPCInventory>();
			if ((Object)(object)component != (Object)null)
			{
				RandomInventoryItemsBuilder randomInventoryItemsBuilder = new RandomInventoryItemsBuilder();
				configure(randomInventoryItemsBuilder);
				RandomInventoryItemsBuilder.InventoryDefaultsData data = randomInventoryItemsBuilder.BuildInternal();
				ApplyInventoryDefaultsToComponent(component, data);
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(Object.op_Implicit("[S1API] Failed to register inventory defaults for " + ownerType.Name + ": " + ex.Message));
		}
		return this;
	}

	private void ApplyInventoryDefaultsToComponent(NPCInventory inventory, RandomInventoryItemsBuilder.InventoryDefaultsData data)
	{
		if ((Object)(object)inventory == (Object)null || data == null)
		{
			return;
		}
		try
		{
			if (data.RandomCashMin.HasValue || data.RandomCashMax.HasValue)
			{
				inventory.RandomCash = true;
				if (data.RandomCashMin.HasValue)
				{
					inventory.RandomCashMin = data.RandomCashMin.Value;
				}
				if (data.RandomCashMax.HasValue)
				{
					inventory.RandomCashMax = data.RandomCashMax.Value;
				}
			}
			if (data.ClearInventoryEachNight.HasValue)
			{
				inventory.ClearInventoryEachNight = data.ClearInventoryEachNight.Value;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(Object.op_Implicit("[S1API] Failed to apply inventory defaults to prefab: " + ex.Message));
		}
	}

	private void PrecreateActionsForSpecs(List<IScheduleActionSpec> specs)
	{
		if (specs == null || specs.Count == 0)
		{
			return;
		}
		NPCScheduleManager val = EnsureScheduleManager();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		for (int i = 0; i < specs.Count; i++)
		{
			IScheduleActionSpec scheduleActionSpec = specs[i];
			if (scheduleActionSpec is WalkToSpec)
			{
				num++;
			}
			else if (scheduleActionSpec is StayInBuildingSpec)
			{
				num2++;
			}
			else if (scheduleActionSpec is LocationDialogueSpec)
			{
				num3++;
			}
			else if (scheduleActionSpec is UseVendingMachineSpec)
			{
				num4++;
			}
			else if (scheduleActionSpec is DriveToCarParkSpec)
			{
				num5++;
			}
			else if (scheduleActionSpec is EnsureDealSignalSpec)
			{
				num6 = Math.Max(num6, 1);
			}
			else if (scheduleActionSpec is UseATMSpec)
			{
				num7++;
			}
		}
		if (num6 > 0)
		{
			EnsurePrefabAction<NPCSignal_WaitForDelivery>(1, "DealSignal");
			try
			{
				NPCScheduleManager val2 = EnsureScheduleManager();
				NPCSignal_WaitForDelivery componentInChildren = ((Component)val2).GetComponentInChildren<NPCSignal_WaitForDelivery>(true);
				Customer component = prefabRoot.GetComponent<Customer>();
				if ((Object)(object)componentInChildren != (Object)null && (Object)(object)component != (Object)null)
				{
					component.DealSignal = componentInChildren;
				}
			}
			catch (Exception ex)
			{
				string text = ownerType?.Name ?? "Unknown";
				Logger.Warning("Failed to wire DealSignal on prefab for NPC type " + text + ": " + ex.Message);
			}
		}
		EnsurePrefabAction<NPCSignal_WalkToLocation>(num, "WalkTo");
		EnsurePrefabAction<NPCEvent_StayInBuilding>(num2, "StayInBuilding");
		EnsurePrefabAction<NPCEvent_LocationDialogue>(num3, "LocationDialogue");
		EnsurePrefabAction<NPCSignal_UseVendingMachine>(num4, "UseVending");
		EnsurePrefabAction<NPCSignal_DriveToCarPark>(num5, "DriveToCarPark");
		EnsurePrefabAction<NPCSignal_UseATM>(num7, "UseATM");
	}

	private void EnsurePrefabAction<T>(int count, string namePrefix) where T : NPCAction
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (count <= 0)
		{
			return;
		}
		NPCScheduleManager val = EnsureScheduleManager();
		for (int i = 0; i < count; i++)
		{
			GameObject val2 = new GameObject(string.IsNullOrEmpty(namePrefix) ? typeof(T).Name : $"{namePrefix}_{i + 1}");
			val2.transform.SetParent(((Component)val).transform, false);
			T val3 = val2.AddComponent<T>();
			try
			{
				NPC component = prefabRoot.GetComponent<NPC>();
				typeof(T).GetField("npc", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(val3, component);
				typeof(T).GetField("schedule", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(val3, val);
			}
			catch (Exception ex)
			{
				Logger.Warning($"Failed to set npc/schedule fields on prefab action {typeof(T).Name} for NPC type {ownerType?.Name ?? "Unknown"}: {ex.Message}");
			}
			val2.SetActive(false);
			((Behaviour)(object)val3).enabled = false;
		}
	}

	private NPCPrefabIdentity EnsureIdentityComponent()
	{
		NPCPrefabIdentity nPCPrefabIdentity = prefabRoot.GetComponent<NPCPrefabIdentity>();
		if ((Object)(object)nPCPrefabIdentity == (Object)null)
		{
			nPCPrefabIdentity = prefabRoot.AddComponent<NPCPrefabIdentity>();
		}
		return nPCPrefabIdentity;
	}

	private void ApplyAvatarSettingsToPrefab(AvatarSettings settings)
	{
		if ((Object)(object)settings == (Object)null)
		{
			return;
		}
		try
		{
			Avatar val = prefabRoot.GetComponent<Avatar>() ?? prefabRoot.GetComponentInChildren<Avatar>(true);
			if (!((Object)(object)val == (Object)null))
			{
				((Object)settings).hideFlags = (HideFlags)32;
				if (!ReflectionUtils.TrySetFieldOrProperty(val, "InitialAvatarSettings", settings) && !ReflectionUtils.TrySetFieldOrProperty(val, "SettingsToLoad", settings))
				{
					ReflectionUtils.TrySetFieldOrProperty(val, "CurrentSettings", settings);
				}
			}
		}
		catch
		{
		}
	}

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

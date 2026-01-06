public class ProbeVolumeSceneData : ISerializationCallbackReceiver // TypeDefIndex: 13766
{
	// Fields
	private static PropertyInfo s_SceneGUID; // 0x0
	[SerializeField]
	private List<ProbeVolumeSceneData.SerializableBoundItem> serializedBounds; // 0x10
	[SerializeField]
	private List<ProbeVolumeSceneData.SerializableHasPVItem> serializedHasVolumes; // 0x18
	[SerializeField]
	private List<ProbeVolumeSceneData.SerializablePVProfile> serializedProfiles; // 0x20
	[SerializeField]
	private List<ProbeVolumeSceneData.SerializablePVBakeSettings> serializedBakeSettings; // 0x28
	[SerializeField]
	private List<ProbeVolumeSceneData.BakingSet> serializedBakingSets; // 0x30
	internal Object parentAsset; // 0x38
	internal string parentSceneDataPropertyName; // 0x40
	public Dictionary<string, Bounds> sceneBounds; // 0x48
	internal Dictionary<string, bool> hasProbeVolumes; // 0x50
	internal Dictionary<string, ProbeReferenceVolumeProfile> sceneProfiles; // 0x58
	internal Dictionary<string, ProbeVolumeBakingProcessSettings> sceneBakingSettings; // 0x60
	internal List<ProbeVolumeSceneData.BakingSet> bakingSets; // 0x68
	[SerializeField]
	private string m_LightingScenario; // 0x70
	private string m_OtherScenario; // 0x78
	private float m_ScenarioBlendingFactor; // 0x80

	// Properties
	internal string lightingScenario { get; }
	internal string otherScenario { get; }
	internal float scenarioBlendingFactor { get; }

	// Methods

	// RVA: 0x2A238B0 Offset: 0x2A222B0 VA: 0x182A238B0
	internal static string GetSceneGUID(Scene scene) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	internal string get_lightingScenario() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	internal string get_otherScenario() { }

	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300
	internal float get_scenarioBlendingFactor() { }

	// RVA: 0x2A25240 Offset: 0x2A23C40 VA: 0x182A25240
	internal void SetActiveScenario(string scenario) { }

	// RVA: 0x2A23320 Offset: 0x2A21D20 VA: 0x182A23320
	internal void BlendLightingScenario(string otherScenario, float blendingFactor) { }

	// RVA: 0x2A25AC0 Offset: 0x2A244C0 VA: 0x182A25AC0
	public void .ctor(Object parentAsset, string parentSceneDataPropertyName) { }

	// RVA: 0x2A25550 Offset: 0x2A23F50 VA: 0x182A25550
	public void SetParentObject(Object parent, string parentSceneDataPropertyName) { }

	// RVA: 0x2A23BD0 Offset: 0x2A225D0 VA: 0x182A23BD0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2A25850 Offset: 0x2A24250 VA: 0x182A25850
	private void UpdateBakingSets() { }

	// RVA: 0x2A24530 Offset: 0x2A22F30 VA: 0x182A24530 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2A23730 Offset: 0x2A22130 VA: 0x182A23730
	internal ProbeVolumeSceneData.BakingSet CreateNewBakingSet(string name) { }

	// RVA: 0x2A23980 Offset: 0x2A22380 VA: 0x182A23980
	private void InitializeBakingSet(ProbeVolumeSceneData.BakingSet set, string name) { }

	// RVA: 0x2A23AB0 Offset: 0x2A224B0 VA: 0x182A23AB0
	private void InitializeScenarios(ProbeVolumeSceneData.BakingSet set) { }

	// RVA: 0x2A255A0 Offset: 0x2A23FA0 VA: 0x182A255A0
	internal void SyncBakingSetSettings() { }

	// RVA: 0x2A25A00 Offset: 0x2A24400 VA: 0x182A25A00
	private static void .cctor() { }
}

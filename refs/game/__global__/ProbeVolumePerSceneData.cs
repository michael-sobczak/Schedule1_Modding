public class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 13760
{
	// Fields
	[SerializeField]
	internal ProbeVolumeAsset asset; // 0x20
	[SerializeField]
	internal TextAsset cellSharedDataAsset; // 0x28
	[SerializeField]
	internal TextAsset cellSupportDataAsset; // 0x30
	[SerializeField]
	private List<ProbeVolumePerSceneData.SerializablePerScenarioDataItem> serializedScenarios; // 0x38
	internal Dictionary<string, ProbeVolumePerSceneData.PerScenarioData> scenarios; // 0x40
	private bool assetLoaded; // 0x48
	private string activeScenario; // 0x50
	private string otherScenario; // 0x58

	// Methods

	// RVA: 0x2A22D30 Offset: 0x2A21730 VA: 0x182A22D30 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2A22EA0 Offset: 0x2A218A0 VA: 0x182A22EA0 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2A22300 Offset: 0x2A20D00 VA: 0x182A22300
	internal void Clear() { }

	// RVA: 0x2A22950 Offset: 0x2A21350 VA: 0x182A22950
	internal void RemoveScenario(string scenario) { }

	// RVA: 0x2A229B0 Offset: 0x2A213B0 VA: 0x182A229B0
	internal void RenameScenario(string scenario, string newName) { }

	// RVA: 0x2A22A90 Offset: 0x2A21490 VA: 0x182A22A90
	internal bool ResolveCells() { }

	// RVA: 0x2A22CA0 Offset: 0x2A216A0 VA: 0x182A22CA0
	internal bool ResolveSharedCellData() { }

	// RVA: 0x2A22AC0 Offset: 0x2A214C0 VA: 0x182A22AC0
	private bool ResolvePerScenarioCellData() { }

	// RVA: 0x2A22790 Offset: 0x2A21190 VA: 0x182A22790
	internal void QueueAssetLoading() { }

	// RVA: 0x2A22870 Offset: 0x2A21270 VA: 0x182A22870
	internal void QueueAssetRemoval() { }

	// RVA: 0x2A22560 Offset: 0x2A20F60 VA: 0x182A22560
	private void OnEnable() { }

	// RVA: 0x2A22490 Offset: 0x2A20E90 VA: 0x182A22490
	private void OnDisable() { }

	// RVA: 0x2A22350 Offset: 0x2A20D50 VA: 0x182A22350
	internal void Initialize() { }

	// RVA: 0x2A231A0 Offset: 0x2A21BA0 VA: 0x182A231A0
	internal void UpdateActiveScenario(string activeScenario, string otherScenario) { }

	// RVA: 0x2A23260 Offset: 0x2A21C60 VA: 0x182A23260
	public void .ctor() { }
}

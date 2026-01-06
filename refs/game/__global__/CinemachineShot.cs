public sealed class CinemachineShot : PlayableAsset, IPropertyPreview // TypeDefIndex: 16031
{
	// Fields
	public string DisplayName; // 0x18
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x20

	// Methods

	// RVA: 0xBF3AF0 Offset: 0xBF24F0 VA: 0x180BF3AF0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0xBF3C40 Offset: 0xBF2640 VA: 0x180BF3C40 Slot: 9
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0xBF3DE0 Offset: 0xBF27E0 VA: 0x180BF3DE0
	public void .ctor() { }
}
